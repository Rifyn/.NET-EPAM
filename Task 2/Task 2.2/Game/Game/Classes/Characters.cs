using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    
    public abstract class Characters : Coordinates
    {
        public int Health { get; set; }

        public void Move(char[,]mas,Keys key)
        {
            int x = position.X;
            int y = position.Y;
            switch (key)
            {
                //up
                case Keys.w:
                    if (position.X != 1 && mas[x - 1, y] != '*')
                    {
                        Step(position.X, position.Y, mas, --x, y);
                        position.X = position.X - 1;
                    }
                    break;
                //down
                case Keys.s:
                    if (position.X != 14 && mas[x + 1, y] != '*')
                    {
                        Step(position.X, position.Y, mas, ++x, y);
                        position.X = position.X + 1;
                    }
                    break;
                //left
                case Keys.a:
                    if (position.Y != 1 && mas[x, y - 1] != '*')
                    {
                        Step(position.X, position.Y, mas, x, --y);
                        position.Y = position.Y - 1;
                    }
                    break;
                //right
                case Keys.d:
                    if (position.Y != 17 && mas[x, y + 1] != '*')
                    {
                        Step(position.X, position.Y, mas, x, ++y);
                        position.Y = position.Y + 1;
                    }
                    break;
            }
        }
        public void Step(int x, int y, char[,]mas, int newX, int newY)
        {
            mas[x, y] = ' ';
            mas[newX, newY] = visual;
        }

        public enum Keys
        {
            w = 1,
            s = 2,
            a = 3,
            d = 4
        }
    }
}
