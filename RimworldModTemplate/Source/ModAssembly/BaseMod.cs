using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace ModAssembly
{
    // Add references for UnityEngine, UnityEngin.CoreModule, Assembly-Csharp
    // These can be found for example in <Drive>\Steam\SteamApps\common\RimWorld\RimWorldWin64_Data\Managed
    // Right click on References and Add Reference then navigate to the folder to add the reference.
    // Add Harmony reference by navigating to the mod folder and in Assemblies, add the assembly.
    // Be sure to turn off Copy Local in the Properties window of the referenced assembly.
    public class BaseMod : Mod
    {
        // Static reference for settings
        // Use BaseMod.settings.<setting_name> to get value in other parts of code.
        public static BaseModSettings settings;

        // Uncomment out to use harmony, be sure to add the reference assembly
        //public static Harmony harmony;
        

        // Constructor to load your settings
        public BaseMod(ModContentPack content) : base(content)
        {

            // Uncomment below to use harmony.
            // Be sure to add the reference assembly.
            // This will run all patches marked with [HarmonyPatch]

            //harmony = new Harmony(Content.Name);
            //harmony.PatchAll(Assembly.GetExecutingAssembly());

            settings = GetSettings<BaseModSettings>();
        }

        // Page for mod settings
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Gap();
            listingStandard.Label("----- Welcome -----");
            listingStandard.Gap();
            listingStandard.CheckboxLabeled("Enable?", ref settings.enabled, "Enable?");
            listingStandard.Gap();
        }

        // Name of your settings
        public override string SettingsCategory()
        {
            return Content.Name;
        }
    }
}
