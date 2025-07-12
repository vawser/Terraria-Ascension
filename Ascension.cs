using Ascension.Common.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace Ascension;

public partial class Ascension : Mod
{
    public static ServerConfig ConfigServer { get; set; }
    public static ClientConfig ConfigClient { get; set; }
}
