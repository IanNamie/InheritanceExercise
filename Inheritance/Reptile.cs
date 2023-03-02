using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animals
    {
        public Reptile() { }
        public bool LikesToDig { get; set; }
        public bool IsAmphibious { get; set; }
        public int NumberOfLegs { get; set; }
        public bool CanRegenerate { get; set; }
        public string TypeOfLizard { get; set; }


    }
}
