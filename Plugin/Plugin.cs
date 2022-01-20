using BepInEx;
using BepInEx.Configuration;
using System;
using UnityEngine;


namespace LordAshes
{
    [BepInPlugin(Guid, Name, Version)]
    public partial class HideAuraPlugin : BaseUnityPlugin
    {
        // Plugin info
        public const string Name = "Hide Aura Plug-In";              
        public const string Guid = "org.lordashes.plugins.hideaura";
        public const string Version = "1.0.0.0";                    

        // Configuration

        void Awake()
        {
            UnityEngine.Debug.Log("Hide Aura Plugin: Active.");

            Utility.PostOnMainPage(this.GetType());
        }

        void Update()
        {
            if (Utility.isBoardLoaded())
            {
                foreach(GameObject go in GameObject.FindObjectsOfType<GameObject>())
                {
                    try
                    {
                        if (go.name.StartsWith("CustomAura:"))
                        {
                            string[] parts = go.name.Split(':');
                            CreatureBoardAsset asset = null;
                            CreaturePresenter.TryGetAsset(new CreatureGuid(parts[1]), out asset);
                            if (asset != null)
                            {
                                Renderer[] renderers = go.GetComponentsInChildren<Renderer>();
                                if (renderers != null && renderers.Length > 0)
                                {
                                    // Debug.Log("Hide Aura Plugin: Syncing Hide State For " + asset.Creature.Name + " To " + asset.IsVisible.ToString());
                                    foreach (Renderer renderer in renderers)
                                    {
                                        renderer.enabled = asset.IsVisible;
                                    }
                                }
                            }
                        }
                    }
                    catch(Exception x)
                    {

                    }
                }
            }
        }
    }
}
