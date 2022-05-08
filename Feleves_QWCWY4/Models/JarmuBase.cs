using Feleves_QWCWY4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    public class JarmuBase : Ijarmu
    {
        public int MaxTeherbiras { get; set; }
        public int Raktar { get; set; }
        public int TartozkodasiHely { get; set; }
        public List<Csomag> Csomagok { get; set; }
    }
}
