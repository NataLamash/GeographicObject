using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject
{
    public abstract class Object
    {
        public double X { get; set; }
        public double Y { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        public virtual string GetInfo()
        {
            return $"Name: {Name}, Description: {Description}, Coordinates: ({X}, {Y})";
        }
    }
}
