namespace Assessment2.Application.Dtos
{
    public class CountryResponseDto
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetailsDto> CountryDetails { get; set; }
    }
}
