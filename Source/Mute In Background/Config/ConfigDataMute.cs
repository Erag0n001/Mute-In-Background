using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
using ModConfig;

namespace MuteInBackground.Config
{
    public class ConfigDataMute : ModConfig.ConfigData
    {
        [Key(0)]public bool Muted = false;
    }
}
