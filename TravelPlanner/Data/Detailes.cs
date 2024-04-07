using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelPlanner.Context;

namespace TravelPlanner.Data
{
    public class Detailes
    {
        private readonly AppDbContext _appDbContext;
        
        public Detailes(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Gets all the Trips list
        public async Task<List<Trip>> GetAllTrips()
        {
            return await _appDbContext.Trips.ToListAsync();
        }

        // Adds a new trip
        public async Task<bool> AddNewTrip(Trip trip)
        {
            await _appDbContext.Trips.AddAsync(trip);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        // Gets trip details by name
        public async Task<Trip?> GetTripByName(string tripName)
        {
            return await _appDbContext.Trips.FirstOrDefaultAsync(x => x.TripName == tripName);
        }

        // Updates trip details
        public async Task<bool> UpdateTripDetails(Trip updatedTrip)
        {
            try
            {
                _appDbContext.Trips.Update(updatedTrip);
                await _appDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Deletes a trip
        public async Task<bool> DeleteTrip(Trip trip)
        {
            try
            {
                _appDbContext.Trips.Remove(trip);
                await _appDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
