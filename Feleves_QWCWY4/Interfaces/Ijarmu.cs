using Feleves_QWCWY4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feleves_QWCWY4.Interfaces
{
    public interface Ijarmu
    {
        int MaxTeherbiras { get; set; }
        int Raktar { get; set; }
        int TartozkodasiHely { get; set; }

        List<Csomag> Csomagok { get; set; }

       
    }
}
