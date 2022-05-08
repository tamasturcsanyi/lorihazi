using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Models
{
    public static class TesztAdatok
    {
        public static void InitGraph(Graph g)
        {
            // Vegyük fel a csomópontokat
            g.AddCsomopont(new Raktar(1));
            g.AddCsomopont(new Megrendelo(2));
            g.AddCsomopont(new Megrendelo(3));
            g.AddCsomopont(new Megrendelo(4));
            g.AddCsomopont(new Megrendelo(5));
            g.AddCsomopont(new Raktar(6));
            g.AddCsomopont(new Megrendelo(7));
            g.AddCsomopont(new Megrendelo(8));
            g.AddCsomopont(new Megrendelo(9));
            g.AddCsomopont(new Megrendelo(10));
            g.AddCsomopont(new Megrendelo(11));
            g.AddCsomopont(new Megrendelo(12));
            g.AddCsomopont(new Megrendelo(13));
            g.AddCsomopont(new Megrendelo(14));
            g.AddCsomopont(new Megrendelo(15));
            g.AddCsomopont(new Megrendelo(16));
            g.AddCsomopont(new Megrendelo(17));
            g.AddCsomopont(new Raktar(18));
            g.AddCsomopont(new Megrendelo(19));
            g.AddCsomopont(new Megrendelo(20));
            g.AddCsomopont(new Megrendelo(21));
            g.AddCsomopont(new Megrendelo(22));
            g.AddCsomopont(new Megrendelo(23));

            // Vegyük fel a éleket
            g.AddGraphEl(1, 1, 1);
            g.AddGraphEl(3, 1, 4);
            g.AddGraphEl(2, 1, 3);
            g.AddGraphEl(4, 1, 5);
            g.AddGraphEl(3, 5, 6);
            g.AddGraphEl(4, 6, 10);
            g.AddGraphEl(6, 6, 7);
            g.AddGraphEl(2, 6, 9);
            g.AddGraphEl(7, 7, 9);
            g.AddGraphEl(1, 9, 8);
            g.AddGraphEl(4, 6, 8);
            g.AddGraphEl(8, 8, 11);
            g.AddGraphEl(9, 10, 12);
            g.AddGraphEl(2, 11, 12);
            g.AddGraphEl(11, 12, 13);
            g.AddGraphEl(5, 12, 14);
            g.AddGraphEl(4, 18, 13);
            g.AddGraphEl(5, 14, 15);
            g.AddGraphEl(3, 15, 17);
            g.AddGraphEl(2, 15, 16);
            g.AddGraphEl(2, 16, 17);
            g.AddGraphEl(1, 18, 17);
            g.AddGraphEl(1, 18, 19);
            g.AddGraphEl(20, 18, 20);
            g.AddGraphEl(10, 20, 21);
            g.AddGraphEl(10, 21, 22);
            g.AddGraphEl(10, 21, 23);
            g.AddGraphEl(20, 5, 23);

            // Vegyük fel a járműveket
            g.AddJarmu(new Motor(1, 1));
            g.AddJarmu(new Motor(2, 1));
            g.AddJarmu(new Auto(3, 1));
            g.AddJarmu(new Kamion(4, 1));
            g.AddJarmu(new Motor(5, 5));
            g.AddJarmu(new Motor(6, 5));
            g.AddJarmu(new Motor(7, 5));
            g.AddJarmu(new Kamion(8, 5));

        }
    }
}
