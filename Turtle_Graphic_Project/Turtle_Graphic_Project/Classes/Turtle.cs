using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using static Turtle_Graphic_Project.Classes.Commands;

namespace Turtle_Graphic_Project.Classes
{
    public class Turtle
    { 
        private enum directions
        {
            NORTH,
            SOUTH,
            EAST,
            WEST
        }

        private enum pen
        {
            UP,
            DOWN
        }

        private struct point
        {
            public int x;
            public int y;

            public point(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }

        private point pos = new point(0, 0);
        private directions dir = directions.NORTH;
        private pen p = pen.UP; 

        public void processCommand(int CMD, int dist)
        {
            commands cmd = intToEnum(CMD);

            switch (cmd)
            {
                case commands.PENUP:
                    // Process pen up command
                    penUp();
                    break;
                case commands.PENDWN:
                    // Process pen down command
                    penDown();
                    break;
                case commands.RIGHT:
                    turnRight();
                    break;
                case commands.LEFT:
                    turnLeft();
                    break;
                case commands.FORWARD:
                    move(dist);
                    break;
                default:
                    break;
            }
        }

        private void penUp()
        {
            p = pen.UP;
        }

        private void penDown()
        {
            p = pen.DOWN;
        }

        private void turnRight()
        {
            if (dir == directions.NORTH) dir = directions.EAST;
            else if (dir == directions.EAST) dir = directions.SOUTH;
            else if (dir == directions.SOUTH) dir = directions.WEST;
            else dir = directions.NORTH; 
        }

        private void turnLeft()
        {
            if (dir == directions.NORTH) dir = directions.EAST;
            else if (dir == directions.EAST) dir = directions.SOUTH;
            else if (dir == directions.SOUTH) dir = directions.WEST;
            else dir = directions.NORTH;
        }

        private void move(int dist)
        {

        }
    }
}

