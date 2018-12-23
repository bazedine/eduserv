using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEduServ.Models
{
    public class State
    {
        public int id { get; set; }
        public int countryid { get; set; }
        public string name { get; set; }

        public State(int StateID, int CountryID, string StateName)
        {
            id = StateID;
            countryid = CountryID;
            name = StateName;
        }
        public static List<State> GetAllStates()
        {
            List<State> lstState = new List<State>();
            lstState.Add(new State(1, 1, "Arizona"));
            lstState.Add(new State(2, 1, "Alaska"));
            lstState.Add(new State(3, 1, "Florida"));
            lstState.Add(new State(4, 1, "Hawaii"));
            lstState.Add(new State(5, 2, "Gujarat"));
            lstState.Add(new State(6, 2, "Goa"));
            lstState.Add(new State(7, 2, "Punjab"));
            lstState.Add(new State(8, 3, "Queensland"));
            lstState.Add(new State(9, 3, "South Australia"));
            lstState.Add(new State(10, 3, "Tasmania"));
            lstState.Add(new State(11, 4, "Alberta"));
            lstState.Add(new State(12, 4, "Ontario"));
            lstState.Add(new State(13, 4, "Quebec"));
            lstState.Add(new State(14, 4, "Saskatchewan"));
            return lstState;
        }
    }
}
