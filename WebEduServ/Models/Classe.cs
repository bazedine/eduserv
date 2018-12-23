using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEduServ.Models
{
    public class Classe
    {

        public int id { get; set; }
        public string name { get; set; }

        public Classe(int ClasseID, string ClasseName)
        {
            id = ClasseID;
            name = ClasseName;
        }

        public static List<Classe> GetAllClasses()
        {
            List<Classe> lstClasses= new List<Classe>();
            lstClasses.Add(new Classe(1, "USA"));
            lstClasses.Add(new Classe(2, "India"));
            lstClasses.Add(new Classe(3, "Australia"));
            lstClasses.Add(new Classe(4, "Canada"));
            return lstClasses;
        }
    }
}
