using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiskeristyrelsen.Model
{
    internal class FiskNationalReg
    {
        public DateTime Startperiode { get; set; }
        public DateTime Slutperiode { get; set;}
        public double AntalFisk { get; set; }
        public string Art { get; set; }= " ";

        public FiskNationalReg(DateTime startperiode, DateTime slutperiode, double antalFisk, string art)
        {
            Startperiode = startperiode;
            Slutperiode = slutperiode;
            AntalFisk = antalFisk;
            Art = art;
        }
    }
    
}
