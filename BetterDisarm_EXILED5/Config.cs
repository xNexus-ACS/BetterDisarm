using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterDisarm
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Hint that will appear to the attacker when it tried to hurt cuffed people")]
        public string AttackerHint { get; set; } = "You cant hurt cuffed people";
        public float AttackerHintDuration { get; set; } = 5;
    }
}
