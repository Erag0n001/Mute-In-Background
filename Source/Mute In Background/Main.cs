using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Utils;
using UnityEngine;
using HarmonyLib;
using System.Reflection;
using Game;
using MuteInBackground.Config;
using ModConfig;
using ModConfig.Misc;

namespace MuteInBackGround
{
    public static class Main
    {
        public static Harmony harmony;
        public static ConfigDataMute Configs;
        [RuntimeInitializeOnLoadMethod]
        static void StaticConstructorOnStartup() 
        {
            Configs = (ConfigDataMute)ConfigData.LoadConfig("Eragon.MuteInBackground");
            LoadHarmony();
            Application.focusChanged += OnFocusChanged;
        }

        static void LoadHarmony() 
        {
            harmony = new Harmony("Eragon.MuteInBackground");
            harmony.PatchAll();
        }

        static void OnFocusChanged(bool hasFocus) 
        {
            if (Configs.Muted)
            {
                if (hasFocus)
                {
                    AudioListener.volume = 1.0f;
                }
                else
                {
                    AudioListener.volume = 0.0f;
                }
            }
        }
    }
}
