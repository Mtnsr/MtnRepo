using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class RotateMap
    {
        internal char CurrentPosition { get; set; }
        internal char Directive { get; set; }
        internal char NextPosition { get; set; }
    }
}
