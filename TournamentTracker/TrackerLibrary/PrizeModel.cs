namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The position placed this prize belongs to
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Arbitrary name for this place set by the user
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Monetary value of this prize
        /// </summary>
        public decimal PriceAmount { get; set; }
        /// <summary>
        /// Represents the percentage of the total prize pool 
        /// </summary>
        public double PricePercentage { get; set; }
        
    }
}