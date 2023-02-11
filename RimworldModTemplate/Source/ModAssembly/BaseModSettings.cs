using Verse;

namespace ModAssembly
{
    public class BaseModSettings : ModSettings
    {
        // A setting
        public bool enabled;

        public override void ExposeData()
        {
            // Save settings
            base.ExposeData();
            Scribe_Values.Look(ref enabled, "enabled");
        }
    }
}