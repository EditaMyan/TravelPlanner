namespace BlazorApp1.Data
{
    public class Trip
    {
        public Trip()
        {
            TripName = "";
            Country = "";
            City = "";
        }
        public string TripName { set; get; }
        public int StartDate { set; get; }
        public int EndDate { set; get; }
        public string Country { set; get;}
        public string City { set; get; }
        
    }
}
