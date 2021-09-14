using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); // since C#6 we can instantite lke that and no need to use Constructor
        public string TeamName { get; set; }
    }
}
