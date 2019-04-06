using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borSoftwareChallenge
{
    public class Recess
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public bool IsDoor { get; set; }

        public double GetArea() // Returns the wall area each side of the recess
        {
            return ((this.Depth * this.Height) * 2) + (this.Depth * this.Width);
        }

        public double GetVolume() // Returns the volume of the recess
        {
            return this.Depth * this.Height * this.Width;
        }

        public Recess(string name, string width, string height, string depth, bool isdoor)
        {
            Name = name;
            Width = Convert.ToDouble(width);
            Height = Convert.ToDouble(height);
            Depth = Convert.ToDouble(depth);
            IsDoor = isdoor;
        }

    }
}
