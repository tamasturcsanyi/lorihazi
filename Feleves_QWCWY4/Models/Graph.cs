using Feleves_QWCWY4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    internal class Graph
    {
        private Dictionary<int,Icsomopont> Csomopontok { get; set; } //Új csomópontok hozzáadása innen
        private List<GraphEl> Elek { get; set; } //Új elek felvetele innen
        private List<Ijarmu> Jarmuvek {get; set;}
        public void AddCsomopont (Icsomopont ujCsomopont)
        {
            if (ujCsomopont is null)
            {
                throw new ArgumentNullException(nameof(ujCsomopont)); // SAJÁT KIVÉTEL OSZTÁLY
            }

            Csomopontok.Add(ujCsomopont.ID,ujCsomopont);
        }

        public void AddGraphEl(GraphEl UjGraphEl)
        {
            if (UjGraphEl is null)
            {
                throw new ArgumentNullException(nameof(UjGraphEl)); // SAJÁT KIVÉTEL OSZTÁLY
            }

            Elek.Add(UjGraphEl);
        }
        public void AddJarmu(Ijarmu ujJarmu)
        {
            if (ujJarmu is null)
            {
                throw new ArgumentNullException(nameof(ujJarmu)); // SAJÁT KIVÉTEL OSZTÁLY
            }

            Jarmuvek.Add(ujJarmu);
        }

        public void AddCsomag(Csomag csomag)
        {
            if (csomag is null)
            {
                throw new ArgumentNullException(nameof(csomag));
            }

            Raktar raktar = Csomopontok[csomag.Raktar] as Raktar;

            if (raktar != null)
            {
                raktar.AddCsomag(csomag);
            }
            else
            {
                //ToDo: exception ha nem raktár
            }

            
        }
        public List<Icsomopont> legrovidebbUt(int honnan, int hova)
        {
            return null;
        }

        

    }
}
