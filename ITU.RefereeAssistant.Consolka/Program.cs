using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Domain;
using System.Reflection;
using System.IO;


namespace ITU.RefereeAssistant.Consolka
{

    class Program
    {
        //assembly - должно выполняться минимальное количество раз
        /// <summary>
        /// Получение типа системы из dll библиотеки
        /// </summary>
        /// <returns></returns>
        static List<ITournamentType> GetTypes()
        {
            var result = new List<ITournamentType>(); // экземпляр интерфейса

            var currentDirectory = Environment.CurrentDirectory;
            var dlls = Directory.GetFiles(currentDirectory, "*.dll");

            foreach (var dll in dlls)
            {

                var assembly = Assembly.LoadFile(dll);
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    // проверить что этот класс является системой турнира
                    // для это нужно понять какие интерфейсы он реализует
                    var interfaces = type.GetInterfaces();
                    // если класс реализует ITournamentType
                    if (interfaces.Any(inter => inter.Name == "ITournamentType"))
                    {
                        // то нужно создать экземпляр класса
                        //as - если приведение типов не удалось выводит null
                        var tournamentType = Activator.CreateInstance(type) as ITournamentType;
                        // и добавить его в результативный список
                        if (tournamentType != null)
                        {
                            result.Add(tournamentType);
                        }
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {

            var tourTypes = new List<ITournamentType>();
            tourTypes = GetTypes();

            //Создание объекта класса TournamentService
            var ts = new TournamentService();


            for (int i = 0; i < tourTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {tourTypes[i].Name}"); // интерполяция, не использовать +
            }

            int numberType;

            numberType = Convert.ToInt32(Console.ReadLine());

            var tour = ts.Create(new Raiting[] {
                new Raiting(new Player() {Name = "q1"}),
                new Raiting(new Player() {Name = "q2"}),
                new Raiting(new Player() {Name = "q3"}),
                new Raiting(new Player() {Name = "q4"}),
            }, tourTypes[numberType - 1]);



            var round = ts.GenerateRound(tour);
            do
            {
                foreach (var item in round.Matches)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("\nВведите результаты матчей:");
                Console.WriteLine("1 - выиграл первый участник");
                Console.WriteLine("2 - ничья");
                Console.WriteLine("3 - выиграл второй участник\n");

                foreach (var match in round.Matches)
                {
                    Console.WriteLine(match.ToString());
                    var result = Console.ReadLine();
                    switch(result)
                    {
                        case "1":
                            match.Raitings[0].Score = 3;
                            break;
                        case "2":
                            match.Raitings[0].Score = 1;
                            match.Raitings[1].Score = 1;
                            break;
                        case "3":
                            match.Raitings[1].Score = 3;
                            break;
                    }
                }

                round = ts.GenerateRound(tour);

            } while (round != null);


            Console.WriteLine("Турнир завершен");

            Console.ReadKey();
        }
    }
}
