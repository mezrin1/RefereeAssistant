using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain.Models;



namespace ITU.RefereeAssistant.Consolka
{

    class Program
    {
        static void Main(string[] args)
        {
            //Создание объекта класса TournamentService
            var ts = new TournamentService();
            TournamentType type = new TournamentType();
            int count_players;


            Console.WriteLine("Выберите тип системы:");
            Console.WriteLine("1. Олимпийская\n2. Швейцарская\n3. Круговая\n4. Нокаут");


            switch (Console.ReadLine())
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
            var tour = ts.Create(raiting, type);

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

            var round = ts.GenerateRound(tour);

            foreach (var item in round.Matches)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
