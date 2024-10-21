using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoOb
{
    public interface IGeographicObject
    {
        double X { get; set; }
        double Y { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        string GetInfo();
    }
}
