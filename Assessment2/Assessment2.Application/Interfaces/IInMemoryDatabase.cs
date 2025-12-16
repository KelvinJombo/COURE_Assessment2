using Assessment2.Domain.Models;

namespace Assessment2.Application.Interfaces
{
    public interface IInMemoryDatabase
    {
        Country? GetCountryByCode(string prefix);
        List<CountryDetails> GetDetailsByCountryId(int id);
    }

}
