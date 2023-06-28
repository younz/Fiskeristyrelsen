using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiskeristyrelsen.Model
{
    internal class SkibJura // da dette er til team jura er den kaldt dete for at skabe overblik hvad hver skib skal inholde
    {
        public string SkibNationalitet { get; private set;}
        public int Fiskezone { get; private set; }
        public DateTime Afgang { get; private set; }
        public DateTime Ankomst { get; private set; }
        public double Fangstmeande  { get; set; }
        // da disse funktioner for det meste er nogle der kun skal kunne ses på nær mængde der gerne ville kunne ændres har jeg
        // valgt at gøre dem til private 

    }
}
