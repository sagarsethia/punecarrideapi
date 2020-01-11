using System.Collections.Generic;
using System.Threading.Tasks;
using PuneCarRideApi.model;

namespace PuneCarRideApi.Data
{
    public interface IDataRepository
    {
        public Task<List<Destination>> getAllDestination();
        public Task<Destination> getDestinationDetails(string route);

        public Task<IEnumerable<Package>> getPackage(string destination);

        public Task<ListedDestinations> GetListedDestinations();

        public void bookPackage<T> (T entity) where T:class;
        
        public Task<bool> SaveAll();

        
    }
}