using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace BetterDisarm
{
    public class MainClass : Plugin<Config>
    {
        public static MainClass Instance;
        public override string Name { get; } = "BetterDisarm";
        public override string Prefix { get; } = "better_disarm";
        public override string Author { get; } = "xNexus-ACS";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 1);

        private EventHandlers _event;

        public override void OnEnabled()
        {
            Instance = this;
            _event = new EventHandlers(this);

            Player.Hurting += _event.OnHurting;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Player.Hurting -= _event.OnHurting;

            Instance = null;
            _event = null;
            base.OnDisabled();
        }
    }
}
