using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject
{
    public class River : Object
    {
        public double FlowSpeed { get; set; } // см/с
        public double Length { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Flow Speed: {FlowSpeed} cm/s, Length: {Length} km";
        }
    }
}
