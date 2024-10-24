using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ShardsOfMonolith.Models.Stalker
{
    public class StalkerImageViewModel
    {
        public Guid ImageID { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        public string Image {  get; set; }
        public Guid? StalkerID { get; set; }
    }
}
