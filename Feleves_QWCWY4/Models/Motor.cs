using Feleves_QWCWY4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    public class Motor : JarmuBase
    {

        public Motor(int id, int kezdo)
        {
            MaxTeherbiras = 1;
            Raktar = kezdo;
            TartozkodasiHely = kezdo;
            Id = id;
        }

    }
}
