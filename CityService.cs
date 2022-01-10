using System;
using System.Collections.Generic;

namespace ProxyDesignPattern
{
    public class CityService : ICityService
    {
        public CityService()
        {}

        public IEnumerable<City> GetCities()
        {
            Console.WriteLine("Fetching data from remote source ...");

            return new List<City>
            {
                new City("Rio de Janeiro"),
                new City("São Paulo"),
                new City("Vitória"),
                new City("Belo Horizonte"),
            };
        }
    }
}
