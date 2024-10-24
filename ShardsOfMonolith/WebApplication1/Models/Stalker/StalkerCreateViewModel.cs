namespace ShardsOfMonolith.Models.Stalker
{
    public class StalkerCreateViewModel
    {
        public Guid ID { get; set; }

        public string StalkerName { get; set; }

        public int StalkerXP { get; set; }

        public int StalkerXPNextLevel { get; set; }

        public int StalkerLevel { get; set; }

        public StalkerType StalkerType { get; set; }

        public int PrimaryAttackPower { get; set; }

        public int SecondaryAttackPower { get; set; }

        public int SpecalAttackPower { get; set; }

        public int SpecalAttackPowerName { get; set; }

        public DateTime StalkerWasBorn { get; set; }

        public DateTime StalkerDied { get; }

        public List<IFormFile> Files { get; set; }

        public List<StalkerImageViewModel> Images { get; set; } = new List<StalkerImageViewModel>();

        //db only 
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }



    }
}
