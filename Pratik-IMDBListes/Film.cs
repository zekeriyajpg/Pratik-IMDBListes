using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_IMDBListes
{
    internal class Film
    {
        public string Isim {  get; set; }
        public double ImdbPuani { get; set; }

        public Film (string ısim, double ımdbPuani)
        {
            Isim = ısim;
            ImdbPuani = ımdbPuani;
        }
    }
}
