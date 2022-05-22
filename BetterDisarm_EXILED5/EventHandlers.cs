using Exiled.Events.EventArgs;

namespace BetterDisarm
{
    public class EventHandlers
    {
        public readonly MainClass plugin;
        public EventHandlers(MainClass plugin)
        {
            this.plugin = plugin;
        }

        public void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Target.IsCuffed && ev.Attacker.IsHuman)
            {
                ev.IsAllowed = false;
                ev.Attacker.ShowHint(plugin.Config.AttackerHint, plugin.Config.AttackerHintDuration);
            }

            if (ev.Target.IsCuffed && ev.Attacker.IsScp)
                ev.IsAllowed = true;
        }
    }
}
