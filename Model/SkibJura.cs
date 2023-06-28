using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiskeristyrelsen.Model
{
    internal class SkibJura // da dette er til team jura er den kaldt dete for at skabe overblik hvad hver skib skal inholde
    {
        public int SkibId { get; private set; }
        public string SkibNationalitet { get; private set; } = "Dansk"; /// <summary>
        /// der blev deafualtet til at skibet flager dansk da dette er den simpleste løsning
        /// </summary>
        public int Fiskezone { get; private set; }
        public DateTime Afgang { get; private set; }
        public DateTime Ankomst { get; private set; }
        public double Fangstmeande  { get; set; }
        // da disse funktioner for det meste er nogle der kun skal kunne ses på nær mængde der gerne ville kunne ændres har jeg
        // valgt at gøre dem til private 
        public SkibJura(int skibId, string skibNationalitet, int fiskezone, DateTime afgang, DateTime ankomst, double fangstmeande)
        {
            SkibId = skibId;
            SkibNationalitet = skibNationalitet;
            Fiskezone = fiskezone;
            Afgang = afgang;
            Ankomst = ankomst;
            Fangstmeande = fangstmeande;
        }
    }
}
