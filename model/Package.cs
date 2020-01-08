using System.Collections.Generic;

namespace PuneCarRideApi.model
{
    public class Package
    {
        public string PackageId { get; set; }
        public ICollection<Vechiles> VechileType { get; set; }
        public int Price { get; set; }

        

    }
}