using Exiled.Events.EventArgs.Scp096;
namespace Triggering096
{
    public class EventHandlers
    {
        private readonly Plugin plugin;

        public EventHandlers(Plugin plugin)
        {
            this.plugin = plugin;
        }

        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            var Ply = ev.Target;
            
            Ply.ShowHint(plugin.Config.HintShown,5);
        }


    }
}