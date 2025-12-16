namespace Assessment2.Domain.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string CountryIso { get; set; } = string.Empty;
        public List<CountryDetails> CountryDetails { get; set; }
    }
}
