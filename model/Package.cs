using System.Collections.Generic;

namespace PuneCarRideApi.model
{
    public class Package
    {
        public string id {get; set;}
        public string PackageName { get; set; }
        public int Price { get; set; }
        public int NumberOfDay { get; set; }

        public string VechileType{get;set;}

        public string VechileCapacity {get;set;}

        public string VechileExample { get; set; }

    }
}