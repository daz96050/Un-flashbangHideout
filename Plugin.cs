using BepInEx;

namespace UnflashbangHideout
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, "Un-flashbang Hideout", "1.0")]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            new PatchSuperSampling().Enable();
        }
    }
}
