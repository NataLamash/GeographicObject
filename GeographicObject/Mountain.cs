using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject
{
    public class Mountain : Object
    {
        public double HighestPoint { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Highest Point: {HighestPoint} m";
        }
    }
}
