namespace Manifest.Api.Domain.Entities
{
    public class Manifest
    {
        public long Id { get; set; }
        public string ManifestKey { get; set; }
        public string Json { get; set; }
    }
}