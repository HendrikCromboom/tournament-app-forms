using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// List of teams in this matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }
        /// <summary>
        /// The round in the tournament this matchup belongs to
        /// </summary>
        public int MatchupRound { get; set; }
    }
}