using Ascension.Utilities;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace Ascension.Common.Configs;

public class ClientConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [JsonIgnore]
    public Vector3 LightColor;

    [JsonIgnore]
    public bool LightEnabled;

    [Header("Brightness")]
    [Label("Brightness")]
    [Tooltip("Cannot be brighter than the server brightness.\n0-1000, Recomended range is 100-300, 1000 is torch, 200 is dim light")]
    [Range(0, 1000)]
    [DefaultValue(1000)]
    public int LightBrightness { get; set; }

    public override void OnLoaded()
    {
        Ascension.ConfigClient = this;

        if (Ascension.ConfigServer is not null)
        {
            Ascension.ConfigServer.OnChanged();
        }
    }
    public override void OnChanged()
    {
        if (Ascension.ConfigServer == null) { return; }
        float brightness = (float)this.LightBrightness / 1000f;

        Vector3 color = new Vector3(
            Ascension.ConfigServer.LightR, 
            Ascension.ConfigServer.LightG,
            Ascension.ConfigServer.LightB);

        if (Ascension.ConfigServer.NormalizeLightBrightness)
        {
            color = LightHelper.normalizeBrightness(color);
        }
        this.LightColor = color * brightness;
        this.LightEnabled = LightHelper.maxVector3(this.LightColor) > 0;

        Ascension.ConfigClient = this;
    }
}
