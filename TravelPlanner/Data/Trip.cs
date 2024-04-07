namespace TravelPlanner.Data
{
    public class Trip
    {
        public Trip()
        {
            TripName = "";
            Country = "";
            City = "";
        }
        public int Id { get; set; }
        public string TripName { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string Country { set; get; }
        public string City { set; get; }
        public decimal Budget { get; set; }

    }
}
