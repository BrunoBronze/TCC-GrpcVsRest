namespace Manifest.Api.Domain.Entities
{
    public class Flight
    {
        public long Id { get; set; }
        public string FlightKey { get; set; }
        public string ManifestKey { get; set; }
        public string Json { get; set; }
    }
}