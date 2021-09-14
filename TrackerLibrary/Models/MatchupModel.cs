using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// List of matchup entries
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The team that won
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Match up for which round
        /// </summary>
        public int MatchupRound { get; set; }
    }
    /*
     Matchup(Class) // Would be a DB Table
	- Entries(List<MatchupEntry) // List of matchup entries
	- Winner(Team)
	- MatchupRound(int) // Match up for which round
     */
}