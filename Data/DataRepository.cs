
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PuneCarRideApi.model;

namespace PuneCarRideApi.Data
{
    public class DataRepository : IDataRepository
    {
        private DataContext _dbContext;
        public DataRepository(DataContext dataContext) {
            _dbContext = dataContext;
        }
        public async Task<List<Destination>> getAllDestination()
        {
           var destination= await _dbContext.Destinations.ToListAsync();

           return destination;
        }

        public Task<Destination> getDestinationDetails(string route)
        {
            var destinationDetail = _dbContext.Destinations.Include(r=>r.Spots).Include(r=>r.Packages).FirstOrDefaultAsync(r=>r.Route==route);
            return destinationDetail;
        }

        public Task<ListedDestinations> GetListedDestinations()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Package>> getPackage(string destination)
        {
           return await _dbContext.Destinations.Where(r => r.Id == destination)
                .Include(r => r.Packages)
                .Select(r => r.Packages)
                .FirstOrDefaultAsync();
            
        }
    }
}