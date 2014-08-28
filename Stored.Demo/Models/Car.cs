using System;
using System.Collections.Generic;


namespace Stored.Demo.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public string NumberPlate { get; set; }
    }


    public class Garage
    {
        public Guid Id { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public Address Address {get;set;}
        public List<Car> ParkedCars { get;set; }
    }


    public class Address 
    {
        public Guid Id { get; set; }
        public int Number {get;set;}
        public string StreetName {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public string Country {get;set;}
        public int Postcode {get;set;}
    }


}

