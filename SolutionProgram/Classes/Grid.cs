

using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{

    public class Grid
    {
        Dictionary<ValueTuple<int, int>, GridPoint> wires;
        public Grid() {
            wires = new Dictionary<ValueTuple<int, int>, GridPoint>(100);
        }

        public int numOfIntersects {
             get {
                  return (from wire in wires where wire.Value.isIntersection select wire).Count();
                 }  
             }

        public int getNumberOfCells() {
            return wires.Count;
        }

        public void addWire(string wireDefinition)
        {
            string[] commands = wireDefinition.Split(',');
            buildWire(commands, wireDefinition.GetHashCode());   
        }

        private void buildWire(string[] commands, int wireHash)
        {
           int xPos = 0, yPos = 0, steps = 1;
           foreach(string command in commands) {
               char direction = command[0];
               int distance = int.Parse(command.Substring(1, command.Length -1));

                switch(direction) {
                    case 'U':
                        for(int pos = yPos + 1; pos <= yPos + distance; pos++) {
                            addVertical(xPos, pos, wireHash, steps);
                            steps++;
                        }
                        yPos += distance;
                        break;
                    case 'R':
                       for(int pos = xPos + 1; pos <= xPos + distance; pos++) {
                            addHorizontal(pos, yPos, wireHash, steps);
                            steps++;
                        }
                        xPos += distance;
                        break;
                    case 'D':
                        for(int pos = yPos - 1; pos >= yPos - distance; pos--)
                        {
                            addVertical(xPos, pos, wireHash, steps);
                            steps++;
                        }
                        yPos -= distance;
                        break;
                    case 'L':
                        for(int pos = xPos - 1; pos >= xPos - distance; pos--)
                        {
                            addHorizontal(pos, yPos, wireHash, steps);
                            steps++;
                        }
                        xPos -= distance;
                        break;
                }
           }
        }

        private void addVertical(int xPos, int yPos, int hash, int steps)
        {
            GridPoint point;
            if (wires.TryGetValue((xPos, yPos), out point))
            {
                point.setVertical(true, hash);
                if(point.isIntersection) {
                    point.steps += steps;
                }
            }
            else
            {
                point = new GridPoint();
                point.steps += steps;
                point.setVertical(true, hash);
                wires.Add((xPos, yPos), point);
            }
        }

        private void addHorizontal(int xPos, int yPos, int hash, int steps)
        {
            GridPoint point;
            if (wires.TryGetValue((xPos, yPos), out point))
            {
                point.setHorizontal(true, hash);
                if(point.isIntersection) {
                    point.steps += steps;
                }
            }
            else
            {
                point = new GridPoint();
                point.steps += steps;
                point.setHorizontal(true, hash);
                wires.Add((xPos, yPos), point);
            }
        }
//Corners are acting as points of intersection
        public KeyValuePair<ValueTuple<int, int>, GridPoint> getClosestIntersection()
        {
            var intersections = (from wire in wires where wire.Value.isIntersection orderby Math.Abs(wire.Key.Item1) + Math.Abs(wire.Key.Item2) select wire);
            return intersections.First();
        }

        public int getDistance() {
            return (from wire in wires where wire.Value.isIntersection select Math.Abs(wire.Key.Item1) + Math.Abs(wire.Key.Item2)).Min();
        }

        public int getMinSteps() {
            return (from wire in wires where wire.Value.isIntersection select wire.Value.steps).Min();
        }
    }








}