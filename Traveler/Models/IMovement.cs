using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.Models
{
    interface IMovement
    {
        string Move(string leftCoor, string rightCoor, string robotCoor,string command);
        
    }
}
