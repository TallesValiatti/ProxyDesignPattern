using System;
using System.Collections.Generic;
using System.Linq;

namespace ProxyDesignPattern
{
    public class CityServiceProxy : ICityService
    {
        private readonly ICityService _cityService;
        private IEnumerable<City> _dataCache; // Used as cache

        public CityServiceProxy()
        {
            _dataCache = new List<City>();
            _cityService = new CityService();
        }

        public IEnumerable<City> GetCities()
        {
            if (this.HasDataOnCache()) 
            {
                Console.WriteLine("Fetching data from cache ...");
                return this.GetDataFromCache();
            }
            else 
            {
                var cities = _cityService.GetCities();
                this.SaveDataOnCache(cities);
                return cities;
            }
        }

        private void SaveDataOnCache(IEnumerable<City> cities)
        {
            _dataCache = cities;
        }

        private IEnumerable<City> GetDataFromCache()
        {
            return _dataCache;
        }

        private bool HasDataOnCache()
        {
            return _dataCache.Any();
        }
    }
}
