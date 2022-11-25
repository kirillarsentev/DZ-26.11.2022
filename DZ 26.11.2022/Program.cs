using DZ_26._11._2022.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_26._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> teams = new List<string>() {"Россия", "Украина", "Китай","Франция"};
            List<string> games = new List<string>() { "Пляж", "Мышеловка" ,"Море","Рыбалка","Почтальоны","Горка", "Супер игра"};
            Beach gamebeach = new Beach();
            gamebeach.PlayGame(teams,games);
            MousetrapClass gamemousetrap = new MousetrapClass();
            gamemousetrap.PlayGame(teams,games);
            SeaClass gamesea = new SeaClass();
            gamesea.PlayGame(teams,games);
            FishingClass gamefishing = new FishingClass();
            gamefishing.PlayGame(teams, games);
            PostmanClass gamepostman = new PostmanClass();
            gamepostman.PlayGame(teams,games);
            SlideClass gameslide = new SlideClass();
            gameslide.PlayGame(teams, games);
            SupergameClass supergame = new SupergameClass();
            supergame.PlayGame(teams,games);




        }
    }
}
