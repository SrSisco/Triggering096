using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerEvents = Exiled.Events.Handlers.Scp096;
namespace Triggering_096
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        public override string Author { get; } = "SrSisco#9981";

        public override string Name { get; } = "096Trigger";

        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0);

        public EventHandlers EventHandlers { get; private set; }



        public override void OnEnabled()
        {
            Singleton = this;
            EventHandlers = new EventHandlers(this);




            PlayerEvents.AddingTarget += EventHandlers.OnAddingTarget;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerEvents.AddingTarget -= EventHandlers.OnAddingTarget;
            EventHandlers = null;

            base.OnDisabled();
        }
    }
}
