using Exiled.Events.EventArgs.Scp096;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triggering_096
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
            
            Ply.ShowHint("¡Has mirado al SCP096!",5);
        }


    }
}
