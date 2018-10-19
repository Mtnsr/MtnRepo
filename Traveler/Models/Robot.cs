using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Robot : IRobot, IMovement
    {
        public Robot(string leftCoor, string rightCoor, string robotCoor, string command)
        {
            currentCoor = Move(leftCoor, rightCoor, robotCoor, command);
        }
        public string currentCoor { get; set; }
        public string Move(string leftCoor, string rightCoor, string robotCoor, string command)
        {
            char currentDirective = robotCoor.Last();
            string currentCoor = robotCoor.Split(currentDirective).First();

            int currentX = Convert.ToInt32(currentCoor[0].ToString());
            int currentY = Convert.ToInt32(currentCoor[2].ToString());

            int maxX = Convert.ToInt32(rightCoor[0].ToString());
            int maxY = Convert.ToInt32(rightCoor[2].ToString());
            int minX = Convert.ToInt32(leftCoor[0].ToString());
            int minY = Convert.ToInt32(leftCoor[2].ToString());


            foreach (var directive in command)
            {
                if (Statics.rotateValues.Contains(directive))
                    currentDirective = Statics.Rotate(currentDirective, directive);
                else
                {
                    bool IsContinueStep = Statics.Step(ref currentX, ref currentY, currentDirective, maxX, maxY, minX, minX);
                    if (!IsContinueStep)
                        break;
                }
            }

            return currentX.ToString() + "," + currentY.ToString()+" "+currentDirective;

        }
    }
}
