using System.Collections.Generic;

namespace PuneCarRideApi.model
{
    public class Destination
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Distance { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Route { get; set; }
        public ICollection<Spots> Spots{get; set;}
        public ICollection<Package> Packages { get; set; }
        public string Category{get;set;}
        
        public string ThingsToDo {get;set;}
        public int Sequence{get;set;}
    }
} 