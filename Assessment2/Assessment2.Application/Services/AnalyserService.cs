using Assessment2.Application.Dtos;
using Assessment2.Application.Interfaces;
using Assessment2.Domain;
 
namespace Assessment2.Application.Services
{
    public class AnalyserService : IAnalyserService
    {
        private readonly IInMemoryDatabase _inMemoryDatabase;

        public AnalyserService(IInMemoryDatabase inMemoryDatabase)
        {
            _inMemoryDatabase = inMemoryDatabase;
        }



        public ApiResponse<DecodeResponseDto> DecodeNumber(string phoneNumber)
        {
            string prefix = phoneNumber.Substring(0, 3);

            var country = _inMemoryDatabase.GetCountryByCode(prefix);

            if (country == null)
                return ApiResponse<DecodeResponseDto>.Fail("Country code not found", "COUNTRY NOT FOUND");

            var details = _inMemoryDatabase.GetDetailsByCountryId(country.Id)
                .Select(d => new CountryDetailsDto
                {
                    Operator = d.Operator,
                    OperatorCode = d.OperatorCode
                })
                .ToList();

            var responseDto = new DecodeResponseDto
            {
                Number = phoneNumber,
                Country = new CountryResponseDto
                {
                    CountryCode = country.CountryCode,
                    Name = country.Name,
                    CountryIso = country.CountryIso,
                    CountryDetails = details
                }
            };

            return ApiResponse<DecodeResponseDto>.Ok(responseDto);
        }



    }

}
