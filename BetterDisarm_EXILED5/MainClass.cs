using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace BetterDisarm
{
    public class MainClass : Plugin<Config>
    {
        public override string Name { get; } = "BetterDisarm";
        public override string Prefix { get; } = "better_disarm";
        public override string Author { get; } = "xNexus-ACS";
        public override Version Version { get; } = new Version(0, 2, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        public EventHandlers _event;

        public override void OnEnabled()
        {
            _event = new EventHandlers(this);

            Player.Hurting += _event.OnHurting;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Player.Hurting -= _event.OnHurting;

            _event = null;
            base.OnDisabled();
        }
    }
}
