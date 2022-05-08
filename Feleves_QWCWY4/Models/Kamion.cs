using Feleves_QWCWY4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    internal class Kamion : JarmuBase
    {
        public Kamion(int id, int kezdo)
        {
            MaxTeherbiras = 15000;
            Raktar = kezdo;
            TartozkodasiHely = kezdo;
            Id = id;
        }

    }
    
}
