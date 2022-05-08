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

        public Raktar(int id)
        {
            ID = id;
        }

        internal void AddCsomag(Csomag csomag)
        {
            csomagok.Add(csomag);

            //property ami csomagokat tarol + add csomag
        }
        private List<Csomag> csomagok; //!!! benne vannak a csomagok amik a raktraban varnak ksizallitasra
        public void AssignCsomagok(List<Ijarmu> jarmuvek) // ezek vannak jelenleg a raktarban, ezeket kell hozz aassignolni a csomagokat
        {
            Ijarmu[] e = new Ijarmu[jarmuvek.Count];
            BTS(jarmuvek, 0, e);
        }

        void BTS(List<Ijarmu> jarmuvek, int szint, Ijarmu[] e) //jarmuhoh hozzatartozo rendelkezesre allo teherbiras
        {
            int i = -1;
            while (i < csomagok.Count - 1)
            {
                i++;
                if (Befer(jarmuvek[szint], csomagok[i], e))
                {
                    e[szint] = jarmuvek[szint];
                    BTS(jarmuvek, szint++, e);
                }
            }
        }

        bool Befer(Ijarmu ijarmu, Csomag csomag, Ijarmu[] e)
        {
            int sulyJarmuben = 0;

            for (int i = 0; i < e.Length; i++)
            {
                if (e[i].Id == ijarmu.Id)
                {
                    sulyJarmuben += csomagok[i].Suly;
                }
            }

            return ijarmu.Befer(sulyJarmuben + csomag.Suly);
        }
    }
}
