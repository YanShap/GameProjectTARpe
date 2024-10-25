﻿
namespace ShardsOfMonolith.Models.Stalker
{
    public enum StalkerType
    {
        RejectedStalker, ResentfulStalker, PredatoryStalker, InitmacyStalker, InfectedStalker
    }
    public enum StalkerStatus
    {
        Dead, Alive, Guarding
    }

    public class StalkerIndexViewModel
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

        //db only 
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }







    }
}