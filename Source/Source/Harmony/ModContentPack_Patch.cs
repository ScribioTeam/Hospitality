using Harmony;
using Source = Verse.ModContentPack;

namespace Hospitality.Harmony
{
    /// <summary>
    /// Display human friendly names for mods - this should be Vanilla or CCL
    /// </summary>
    public class ModContentPack_Patch
    {
        [HarmonyPatch(typeof(Source), "ToString")]
        public class _ToString
        {
            [HarmonyPrefix]
            public bool Replacement(Source __instance, ref string __result)
            {
                __result = __instance.Name; // Changed
                return false;
            }
        }
    }
}