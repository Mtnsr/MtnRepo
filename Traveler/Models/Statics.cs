using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public static class Statics
    {
        public static List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static List<char> directions = new List<char> { 'N', 'S', 'E', 'W' };
        public static List<char> commands = new List<char> { 'R', 'L', 'M', };
        public static List<char> rotateValues = new List<char> { 'R', 'L',};
        public static char moveDirective = 'M';
        public static char comma = ',';
        public static string rightCoorErrorTxt = "Gireceğiniz Değer(rakam-virgül-rakam) formatında 3 karekterden oluşmalıdır. Örn; 1,3";
        public static string robotCoorErrorText = "Gireceğiniz Değer(rakam-virgül-rakam-boşluk-karakter(N,S,E,W büyük harfler) formatında 5 karekterden oluşmalıdır. Örn; 1,3 N";
        public static string commandErrorText = "Gireceğiniz Değer(L-R-M büyük harfler) harflerinden oluşan karakter dizisi olmalıdır. Örn; LMMMRRR";
        public static string leftCoor = "0,0";


        public static List<RotateMap> rotateMaps = new List<RotateMap>()
        {
            new RotateMap
            {
                 CurrentPosition='N',
                 Directive='R',
                 NextPosition='E'
            },
            new RotateMap
            {
                 CurrentPosition='N',
                 Directive='L',
                 NextPosition='W'
            },
            new RotateMap
            {
                 CurrentPosition='S',
                 Directive='R',
                 NextPosition='W'
            },
            new RotateMap
            {
                 CurrentPosition='S',
                 Directive='L',
                 NextPosition='E'
            },
            new RotateMap
            {
                 CurrentPosition='W',
                 Directive='L',
                 NextPosition='S'
            },
             new RotateMap
            {
                 CurrentPosition='W',
                 Directive='R',
                 NextPosition='N'
            },
             new RotateMap
            {
                 CurrentPosition='E',
                 Directive='L',
                 NextPosition='N'
            },
             new RotateMap
            {
                 CurrentPosition='E',
                 Directive='R',
                 NextPosition='S'
            },
        };
        public static char Rotate(char currentPosition,char directive)
        {
            return rotateMaps.Where(b => b.CurrentPosition == currentPosition && b.Directive == directive).FirstOrDefault().NextPosition;
        }
        public static bool  Step(ref int currentX, ref int currentY, char currentDirective,int maxX,int maxY, int minX, int minY)
        {
            bool result = true;
            switch (currentDirective)
            {
                case 'N':
                    currentY = currentY+1;
                    if (currentY > maxY)
                    {
                        currentY = currentY - 1;
                        result= false;
                    }
                    break;
                case 'S':
                    currentY = currentY - 1;
                    if (currentY < minY)
                    {
                        currentY = currentY + 1;
                        result = false;
                    }
                    break;
                case 'W':
                    currentX = currentX - 1;
                    if (currentX < minX)
                    {
                        currentX = currentX + 1;
                        result = false;
                    }
                    break;
                case 'E':
                    currentX = currentX + 1;
                    if (currentX > maxX)
                    {
                        currentX = currentX - 1;
                        result = false;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }


    }
}
