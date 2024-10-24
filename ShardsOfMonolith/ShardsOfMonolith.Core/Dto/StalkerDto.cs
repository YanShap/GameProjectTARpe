using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShardsOfMonolith.Core.Dto
{
    public enum StalkerType
    {
        RejectedStalker, ResentfulStalker, PredatoryStalker, InitmacyStalker, InfectedStalker
    }
    public enum StalkerStatus
    {
        Dead, Alive, Guarding
    }

    public class StalkerDto
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
        public IEnumerable<FileToDatabaseDto> Image {  get; set; } = new List<FileToDatabaseDto>();

        //db only 
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }







    }
}
