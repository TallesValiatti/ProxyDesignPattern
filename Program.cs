using System;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICityService cityRepository = new CityServiceProxy();

            // First request
            var cities = cityRepository.GetCities();

            // First request
            cities = cityRepository.GetCities();

            // More code ...
        }
    }
}
