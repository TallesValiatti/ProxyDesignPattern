using System.Collections.Generic;

namespace ProxyDesignPattern
{
    public interface ICityService
    {
        IEnumerable<City> GetCities();
    }
}
