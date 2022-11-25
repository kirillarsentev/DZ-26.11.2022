using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_26._11._2022.Clases
{
    internal class PostmanClass:InterfaceGame
    {
        public void PlayGame(List<string> teams, List<string> games)
        {
            Console.WriteLine("Игра в которой предстоит сразится четырём командам :" + games[4]);
            Thread.Sleep(2000);
            Console.WriteLine("На старт!");
            Thread.Sleep(2000);
            Console.WriteLine("Внимание");
            Thread.Sleep(2000);
            Console.WriteLine("Марш");
            Console.WriteLine("Игра под названием " + games[4] + " началась");
            Random rand = new Random();
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine("Выступает команда : " + teams[i]);
                Thread.Sleep(1000);
                Console.WriteLine("Команда набрала очков : " + rand.Next(0, 10));
            }
        }
    }
}
