using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Domain;
using ITU.RefereeAssistant.Domain.TourType;


namespace ITU.RefereeAssistant.Consolka
{

    class Program
    {

        static void Main(string[] args)
        {
            var tourTypes = new List<ITournamentType>()
            {
                new OlympicTourType()
            };

            //Создание объекта класса TournamentService
            var ts = new TournamentService();
           // TournamentType type = new TournamentType();
          //  int count_players;

            for (int i = 0; i < tourTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {tourTypes[i].Name}"); // интерполяция, не использовать +
            }

            int numberType;

            //Console.WriteLine("Выберите тип системы:");
            //Console.WriteLine("1. Олимпийская\n2. Швейцарская\n3. Круговая\n4. Нокаут");

            numberType = Convert.ToInt32(Console.ReadLine());

            var tour = ts.Create(new Raiting[] {
                new Raiting(new Player() {Name = "q1"}),
                new Raiting(new Player() {Name = "q2"}),
                new Raiting(new Player() {Name = "q3"}),
                new Raiting(new Player() {Name = "q4"}),
            }, tourTypes[numberType - 1]);

            //var round = ts.GenerateRound(tour);

            /*     switch (Console.ReadLine())
                 {
                     case "1":
                         type = TournamentType.Olimpic;
                         break;
                     case "2":
                         type = TournamentType.Swiss;
                         break;
                     case "3":
                         type = TournamentType.Circle;
                         break;
                     case "4":
                         type = TournamentType.KnockOut;
                         break;
                 }

                 while (true)
                 {
                     Console.WriteLine("Введите количество участников:");
                     count_players = Convert.ToInt32(Console.ReadLine());

                     if (count_players > 0 && (count_players & 0x1) == 0) break;
                     else Console.WriteLine("Число должно быть четным!\n");
                 }

                 Raiting[] raiting = new Raiting[count_players];


                 for (int i = 0; i < count_players; i++)
                 {
                     raiting[i] = new Raiting();
                     Console.WriteLine("Введите имя участника №{0}:", i + 1);
                     raiting[i].Players.name = Console.ReadLine();
                 }

                 //type = TournamentType.Olimpic;
                 var tour = ts.Create(raiting, type);*/

            /*var tour = ts.Create(new Raiting[] 
            {
                new Raiting()
                {
                    Players = new Player() { name = "q1"}
                },
                new Raiting()
                {
                    Players = new Player() { name = "q2"}
                },
                new Raiting()
                {
                    Players = new Player() { name = "q3"}
                },
                new Raiting()
                {
                    Players = new Player() { name = "q4"}
                }

            }, TournamentType.Olimpic);*/

            //var round = ts.GenerateRound(tour);

            /*foreach (var item in round.Matches)
            {
                Console.WriteLine(item.ToString());
            }
            */

            var round = ts.GenerateRound(tour);
            do
            {
                foreach (var item in round.Matches)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("Введите результаты матчей:");
                Console.WriteLine("1 - выиграл первый участник");
                Console.WriteLine("2 - ничья");
                Console.WriteLine("3 - выиграл второй участник");

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

                //var select = Console.ReadLine();
                //round = select == "1" ? ts.GenerateRound(tour) : null;
                round = ts.GenerateRound(tour);

            } while (round != null);

            Console.WriteLine("Турнир завершен");

            Console.ReadKey();
        }
    }
}
