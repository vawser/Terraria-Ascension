using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascension.Utilities;

public static class LightHelper
{
    public static float maxVector3(Vector3 vector3)
    {
        return Math.Max(vector3.X, Math.Max(vector3.Y, vector3.Z));
    }
    public static Vector3 normalizeBrightness(Vector3 rgb)
    {
        float max = Math.Max(rgb.X, Math.Max(rgb.Y, rgb.Z));
        if (max == 0f)
        {
            return new Vector3(0f, 0f, 0f);
        }
        // element wise divide
        return rgb / max;
    }
}

