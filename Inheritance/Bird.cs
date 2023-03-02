using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animals
    {
        public Bird() { }
        public bool CanFly { get; set; }
        public string ColorOfFeathers { get; set; }
        public bool IsWaterResistint { get; set; }
        public string LivesWhere { get; set; }

    }
}
