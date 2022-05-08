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

        public Auto(int id)
        {
            MaxTeherbiras = 50;
            Raktar = 10;
            TartozkodasiHely = 10;
            Id = id;
        }

    }
}
