using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Game.Classes
{
    public class ConsoleUI
    {
        char[,] fild =
        {
            {'|','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ','*',' ',' ','*','*','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ','*',' ',' ','*',' ','|' },
            {'|',' ','*','*',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|' },
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|' },
            {'|',' ',' ',' ',' ',' ',' ','*','*','*',' ',' ','*','*','*','*',' ',' ','|' },
            {'|',' ','*','*','*','*',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ','*',' ',' ',' ',' ',' ','*',' ',' ','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ','*',' ',' ',' ',' ',' ','*',' ',' ','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ','*',' ',' ',' ',' ',' ','*',' ',' ','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ','*',' ',' ',' ',' ',' ','*',' ',' ','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ','*',' ',' ',' ',' ',' ','*','*','*','|' },
            {'|',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|' },
            {'|','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','|' }
        };
        Enemies enemie1 = new Enemies(new Point(1, 17));
        Players player = new Players(new Point(1, 1));
        Food food1 = new Food(new Point(14,17));
        Food food2 = new Food(new Point(14,4));
        Food food3 = new Food(new Point(7,14));
        Item firstItem = new Item(new Point(12, 17));
        Item secondItem = new Item(new Point(1, 6));
        List<Coordinates> food = new List<Coordinates>();
        List<Coordinates> enemies = new List<Coordinates>();
        List<Coordinates> Items = new List<Coordinates>();
        

        public void Play()
        {
            food.Add(food1);
            food.Add(food2);
            food.Add(food3);
            enemies.Add(enemie1);
            Items.Add(firstItem);
            Items.Add(secondItem);
            GeneratePoint(player, fild);
            GeneratePoint(food, fild);
            GeneratePoint(enemies, fild);
            GeneratePoint(Items, fild);
            while (player.Health>0&&player.PlayerPoints != 100)
            {
                Console.Clear();
                PrintFild();
                player.Move(fild, (Characters.Keys)Players.PlayerStep());
                enemie1.Move(fild, (Characters.Keys)new Random().Next(1,5));
                foreach (var enem in enemies)
                {
                    if (enem.position == player.position)
                    {
                        player.Health -= 100;
                        Console.WriteLine(enem.position.X + " " + enem.position.Y);
                    }
                }
                foreach (var food in food)
                {
                    if (food.position==player.position)
                    {
                        player.Health += 20;
                        food.position = new Point(100, 100);
                    }
                }
                foreach (var i in Items)
                {
                    if (i.position == player.position)
                    {
                        player.PlayerPoints += 50;
                        i.position = new Point(100, 100);
                    }
                }
                GeneratePoint(player, fild);
                GeneratePoint(food, fild);
                GeneratePoint(Items, fild);
                GeneratePoint(enemies, fild);
            }
            Console.Clear();
            PrintFild();
            if (player.Health < 0)
            {
                Console.WriteLine("\nВы проиграли");
            }
            else
            {
                Console.WriteLine("\nВы выиграли!");
            }
        }

        public void PrintFild()
        {
            int rows = fild.GetUpperBound(0)+1;
            int colums = fild.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(fild[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"HP:{player.Health}\tPoints:{player.PlayerPoints}");
        }
        public void GeneratePoint(List<Coordinates> someCoordinates, char[,] mas)
        {
            foreach (var coordinates in someCoordinates)
            {
                try
                {
                    mas[coordinates.position.X, coordinates.position.Y] = coordinates.Visual;
                }
                catch
                {

                }
            }
        }
        public void GeneratePoint(Players player, char[,] mas)
        {
            mas[player.position.X, player.position.Y] = player.Visual;
        }
    }
}
