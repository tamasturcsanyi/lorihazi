using Feleves_QWCWY4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    internal class Raktar : Icsomopont
    {
        public int ID { get; set; }
        private List<Csomag> csomagok;
        internal void AddCsomag(Csomag csomag)
        {
            csomagok.Add(csomag);

            //property ami csomagokat tarol + add csomag
        }

        public void AssignCsomagok(List<Ijarmu> jarmuvek) 
        {

        }




    }
}
