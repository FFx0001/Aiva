﻿namespace Aiva.Extensions.Models.Giveaway {
    [PropertyChanged.ImplementPropertyChanged]
    public class GiveawayModel {
        public bool Admin { get; set; }
        public bool User { get; set; }
        public bool Sub { get; set; }
        public bool Mod { get; set; }
        public int SubLuck { get; set; }
        public string Keyword { get; set; }
    }

    public enum ReturnModel {
        AdminNotAllowed,
        ModNotAllowed,
        UserNotAllowed,
        SubNotAllowed,
        Successfull,
        OtherError
    }
}