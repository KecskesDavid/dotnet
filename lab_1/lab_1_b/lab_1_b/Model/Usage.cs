using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_b.Model
{
    public class Usage
    {
        public Boolean Concrete { get; set; }
        public Boolean HardBrick { get; set; }
        public Boolean HardMaterial { get; set; }
        public Boolean Metal { get; set; }
        public Boolean ScrewDriver { get; set; }
        public Boolean Wood { get; set; }

        public Usage(bool concrete, bool hardBrick, bool hardMaterial, bool metal, bool screwDriver, bool wood)
        {
            Concrete = concrete;
            HardBrick = hardBrick;
            HardMaterial = hardMaterial;
            Metal = metal;
            ScrewDriver = screwDriver;
            Wood = wood;
        }
    }
}
