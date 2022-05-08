using Feleves_QWCWY4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    internal class GraphEl
    {
        public int ElSuly { get; set; }
        public Icsomopont Honnan { get; set; }
        public Icsomopont Hova { get; set; }

        public GraphEl(int elSuly, Icsomopont honnan, Icsomopont hova)
        {
            ElSuly = elSuly;
            Honnan = honnan;
            Hova = hova;
        }
    }
}
