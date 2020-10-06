namespace TrackerLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        /// <summary>
        /// Is a string since it does not need calculation and might contain special characters
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}