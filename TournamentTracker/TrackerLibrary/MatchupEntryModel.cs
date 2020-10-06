namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents 1 team in a matchup between 2 teams
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the final score of this 1 team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents a link back to the matchup this team belongs to
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}