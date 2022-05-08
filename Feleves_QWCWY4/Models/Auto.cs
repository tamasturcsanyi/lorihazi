using Feleves_QWCWY4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    internal class Auto : JarmuBase
    {

        public Auto(int id, int kezdo)
        {
            MaxTeherbiras = 50;
            Raktar = kezdo;
            TartozkodasiHely = kezdo;
            Id = id;
        }

    }
}
