using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// The score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Which matchup they came from. E.g., If this is Round 2 , where from Round 1 they came from.
        /// </summary>
        public MatchupModel ParentMatchup{ get; set; }

        /// <summary>
        /// <
        /// </summary>
        /// <param name="InitialScore"></param>
        public MatchupEntryModel(double InitialScore)
        {
            Console.WriteLine();
        }
    }
}
