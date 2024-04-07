using BlazorApp1.Context;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class Detailes
    {
        private readonly AppDbContext _appDbContext;
        public Detailes(AppDbContext appDbContext) 
        { 
            _appDbContext= appDbContext;
        }

        //Gets all the Trips list
        public async Task<List<Trip>> GetAllTrips()
        {
            return await _appDbContext.Trips.ToListAsync();
        }

        //Adds new trips
        public async Task<bool> AddNewTrip(Trip trip)
        {
            await _appDbContext.Trips.AddAsync(trip);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        //Gets trip detailes by the name
        public async Task<Trip?> GetTripByName(string TripName)
        {
            Trip? trip = await _appDbContext.Trips.FirstOrDefaultAsync(x => x.TripName == TripName);
            return trip;
        }

        //Updates trip detailes
        public async Task<bool> UpdateTripDetailes(Trip trip)
        {
            _appDbContext.Trips.Update(trip);
            await _appDbContext.SaveChangesAsync();
            return true;        
        }

        //Deletes trip
        public async Task<bool> DeleteTrip(Trip trip)
        {
            _appDbContext.Trips.Remove(trip);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}
