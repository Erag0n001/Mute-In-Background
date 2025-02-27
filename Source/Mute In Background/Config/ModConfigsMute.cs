using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.UI;
using ModConfig.UI;
using MuteInBackGround;

namespace MuteInBackground.Config
{
    public class ModConfigsMute : ModConfigs
    {
        public override void DoWindowContent()
        {
             UIBuilder.CreateToggle("UIToggleWidget", transform, "Enabled", Main.Configs.Muted, x => Main.Configs.Muted = x);
        }
    }
}
