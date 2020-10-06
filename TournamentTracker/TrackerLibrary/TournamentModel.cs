using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// The name of this tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The entry fee for the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of all the teams in this tournament
        /// </summary>
        public List<TeamModel> ParticipatingTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// A list of all the prizes available
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// A list of all the possible matchups
        /// </summary>
        public List<List<MatchupModel>> Type { get; set; } = new List<List<MatchupModel>>();
    }
}