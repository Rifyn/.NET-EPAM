using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Players : Characters
    {
        private int _playerPoints = 0;
        public int PlayerPoints 
        { 
            get=>_playerPoints; 
            set => _playerPoints = value; 
        }
        public Players(Point point)
        {
            Health = 100;
            position = point;
            visual = 'X';
        }
        public static int PlayerStep()
        {
            switch (char.ToLower(Console.ReadKey().KeyChar))
            {
                case 'w':return 1;
                case 's':return 2;
                case 'a':return 3;
                case 'd':return 4;
                default: return 0;
            }
        }
    }
}
