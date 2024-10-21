using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoOb
{
    public class Mountain : IGeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public double HighestPoint { get; set; }

        public string GetInfo()
        {
            return $"Name: {Name}, Description: {Description}, Coordinates: ({X}, {Y}), Highest Point: {HighestPoint} m";
        }
    }
}
