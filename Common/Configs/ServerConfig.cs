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


public class ServerConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    // hide from config menu
    [JsonIgnore]
    public Vector3 LightColor;

    // avoid checking if color is 0 every frame
    [JsonIgnore]
    public bool LightEnabled;

    [Header("Brightness")]
    [Label("Brightness")]
    [Tooltip("Clients can choose to set a lower brightness.\n0-1000, Recomended range is 100-300, 1000 is torch, 200 is dim light")]
    [Range(0, 1000)]
    [DefaultValue(200)]
    public int LightBrightness { get; set; }

    [Label("Normalize color brightness")]
    [Tooltip("Normalize brightness for the color. Ex: (0, 0.25, 0.5) -> (0, 0.5, 1)")]
    [DefaultValue(true)]
    public bool NormalizeLightBrightness { get; set; }

    [Header("Color")]
    [Label("Red")]
    [Range(0f, 1f)]
    [DefaultValue(0.59f)]
    public float LightR { get; set; }

    [Label("Green")]
    [Range(0f, 1f)]
    [DefaultValue(0.52f)]
    public float LightG { get; set; }

    [Label("Blue")]
    [Range(0f, 1f)]
    [DefaultValue(0.7f)]
    public float LightB { get; set; }

    public override void OnLoaded()
    {
        Ascension.ConfigServer = this;
        if (Ascension.ConfigClient is not null)
        {
            Ascension.ConfigClient.OnChanged();
        }
    }

    public override void OnChanged()
    {
        if (Ascension.ConfigServer is null)
        {
            return;
        }

        float brightness = (float)this.LightBrightness / 1000f;

        Vector3 color = new Vector3(this.LightR, this.LightG, this.LightB);
        if (this.NormalizeLightBrightness)
        {
            color = LightHelper.normalizeBrightness(color);
        }

        this.LightColor = color * brightness;
        this.LightEnabled = LightHelper.maxVector3(this.LightColor) > 0;

        Ascension.ConfigServer = this;
    }

    public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
    {
        return false;
    }
}

