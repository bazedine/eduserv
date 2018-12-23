using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEduServ.Models
{
    public class Etablissement
    {
        public int id { get; set; }
        public int classeid { get; set; }
        public string name { get; set; }

        public Etablissement(int StateID, int ClasseID, string EtablissementName)
        {
            id = StateID;
            classeid = ClasseID;
            name = EtablissementName;
        }
        public static List<Etablissement> GetAllEtablissements()
        {
            List<Etablissement> lstState = new List<Etablissement>();
            lstState.Add(new Etablissement(1, 1, "Arizona"));
            lstState.Add(new Etablissement(2, 1, "Alaska"));
            lstState.Add(new Etablissement(3, 1, "Florida"));
            lstState.Add(new Etablissement(4, 1, "Hawaii"));
            lstState.Add(new Etablissement(5, 2, "Gujarat"));
            lstState.Add(new Etablissement(6, 2, "Goa"));
            lstState.Add(new Etablissement(7, 2, "Punjab"));
            lstState.Add(new Etablissement(8, 3, "Queensland"));
            lstState.Add(new Etablissement(9, 3, "South Australia"));
            lstState.Add(new Etablissement(10, 3, "Tasmania"));
            lstState.Add(new Etablissement(11, 4, "Alberta"));
            lstState.Add(new Etablissement(12, 4, "Ontario"));
            lstState.Add(new Etablissement(13, 4, "Quebec"));
            lstState.Add(new Etablissement(14, 4, "Saskatchewan"));
            return lstState;
        }
    }
}
