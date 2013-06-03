using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.RayTracing
{
    public class Color
    {
        public static Color white        = new Color(1.0f, 1.0f, 1.0f);
        public static Color grey         = new Color(0.5f, 0.5f, 0.5f);
        public static Color black        = new Color(0.0f, 0.0f, 0.0f);
        public static Color background   = Color.black;
        public static Color defaultColor = Color.black;

        public float r;
        public float b;
        public float g;

        public Color() : this(0.0f, 0.0f, 0.0f) 
        { 

        }
        public Color(float r, float b, float g)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static Color scale(float k, Color v)
        {
            return new Color(k * v.r, k * v.g, k * v.b);
        }

        public static Color plus(Color v1, Color v2)
        {
            return new Color(v1.r + v2.r, v1.g + v2.g, v1.b + v2.b);
        }

        public static Color times(Color v1, Color v2)
        {
            return new Color(v1.r * v2.r, v1.g * v2.g, v1.b * v2.b);
        }
        
        public static System.Drawing.Color toDrawingColor(Color color)
        {
            // legalize.
            var r = color.r > 1.0f ? 1.0f : color.r;
            
            var b = color.b > 1.0f ? 1.0f : color.b;
            
            var g = color.g > 1.0f ? 1.0f : color.g;

            return System.Drawing.Color.FromArgb((int)System.Math.Floor(r * 255),
                                                 (int)System.Math.Floor(g * 255),
                                                 (int)System.Math.Floor(b * 255));  
        }

    }
}
