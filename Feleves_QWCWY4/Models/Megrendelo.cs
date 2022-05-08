using Feleves_QWCWY4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    internal class Megrendelo : Icsomopont
    {
        public int ID { get; set; }

        public Megrendelo(int id)
        {
            ID = id;
        }
    }
}
