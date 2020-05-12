using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle_Graphic_Project.Classes
{
    public class Commands
    {
        public int [,] floor = new int[20,20];
        public int[,] program = new int[100,100];

        public enum commands
        {
            EMPTY,
            PENUP,
            PENDWN,
            RIGHT,
            LEFT,
            FORWARD,
            PRINT
        }

        public static commands intToEnum(int val)
        {
            commands returnVal;
            switch (val)
            {
                case 1:
                    returnVal = commands.PENUP;
                    break;
                case 2:
                    returnVal = commands.PENDWN;
                    break;
                case 3:
                    returnVal = commands.RIGHT;
                    break;
                case 4:
                    returnVal = commands.LEFT;
                    break;
                case 5:
                    returnVal = commands.FORWARD;
                    break;
                case 6:
                    returnVal = commands.PRINT;
                    break;
                default:
                    returnVal = commands.EMPTY;
                    break;
            }

            return returnVal;
        }
    }
}
