using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerEvents = Exiled.Events.Handlers.Scp096;
namespace Triggering096
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        public override string Author { get; } = "SrSisco";

        public override string Name { get; } = "Triggering096";

        public override Version Version { get; } = new Version(1, 1, 0);
        
        public override Version RequiredExiledVersion { get; } = new Version(8, 9, 6);

        public EventHandlers EventHandlers { get; private set; }



        public override void OnEnabled()
        {
            Singleton = this;
            EventHandlers = new EventHandlers(this);




            PlayerEvents.AddingTarget += EventHandlers.OnAddingTarget;
            Log.Debug("Triggering096 has been enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerEvents.AddingTarget -= EventHandlers.OnAddingTarget;
            EventHandlers = null;
            Log.Debug("Triggering096 has been disabled.");
            base.OnDisabled();
        }
    }
}