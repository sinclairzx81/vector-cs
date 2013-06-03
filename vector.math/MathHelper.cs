/* ===============================================================================  
 * Copyright (c) 2013 Vector by sinclair
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * 
 * =============================================================================== */

namespace Vector.Math
{
    public static class MathHelper
    {
        // Fields
        public const float E = 2.718282f;
        public const float Log10E = 0.4342945f;
        public const float Log2E = 1.442695f;
        public const float Pi = 3.141593f;
        public const float PiOver2 = 1.570796f;
        public const float PiOver4 = 0.7853982f;
        public const float TwoPi = 6.283185f;

        // Methods
        public static float Barycentric(float value1, float value2, float value3, float amount1, float amount2)
        {
            return ((value1 + (amount1 * (value2 - value1))) + (amount2 * (value3 - value1)));
        }

        public static float CatmullRom(float value1, float value2, float value3, float value4, float amount)
        {
            float num = amount * amount;
            float num2 = amount * num;
            return (0.5f * ((((2f * value2) + ((-value1 + value3) * amount)) + (((((2f * value1) - (5f * value2)) + (4f * value3)) - value4) * num)) + ((((-value1 + (3f * value2)) - (3f * value3)) + value4) * num2)));
        }

        public static float Clamp(float value, float min, float max)
        {
            value = (value > max) ? max : value;
            value = (value < min) ? min : value;
            return value;
        }

        public static float Distance(float value1, float value2)
        {
            return System.Math.Abs((float)(value1 - value2));
        }

        public static float Hermite(float value1, float tangent1, float value2, float tangent2, float amount)
        {
            float num3 = amount;
            float num = num3 * num3;
            float num2 = num3 * num;
            float num7 = ((2f * num2) - (3f * num)) + 1f;
            float num6 = (-2f * num2) + (3f * num);
            float num5 = (num2 - (2f * num)) + num3;
            float num4 = num2 - num;
            return ((((value1 * num7) + (value2 * num6)) + (tangent1 * num5)) + (tangent2 * num4));
        }

        public static float Lerp(float value1, float value2, float amount)
        {
            return (value1 + ((value2 - value1) * amount));
        }

        public static float Max(float value1, float value2)
        {
            return System.Math.Max(value1, value2);
        }

        public static float Min(float value1, float value2)
        {
            return System.Math.Min(value1, value2);
        }

        public static float SmoothStep(float value1, float value2, float amount)
        {
            float num = Clamp(amount, 0f, 1f);
            return Lerp(value1, value2, (num * num) * (3f - (2f * num)));
        }

        public static float ToDegrees(float radians)
        {
            return (radians * 57.29578f);
        }

        public static float ToRadians(float degrees)
        {
            return (degrees * 0.01745329f);
        }

        #region Physics Specific

        public const float Epsilon = 1.0e-6f;

        public static float Wrap(float val, float min, float max)
        {
            float delta = max - min;
            if (val > delta)
            {
                val = val / delta;
                val = val - (float)System.Math.Floor(val);
                val = val * delta;
            }
            return val;
        }

        public static void NormalizeSafe(ref Vector3 vec)
        {
            float num0 = vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z;

            if (num0 != 0.0f)
            {
                float num1 = 1.0f / (float)System.Math.Sqrt(num0);
                vec.X *= num1; vec.Y *= num1; vec.Z *= num1;
            }
        }

        public static Vector3 NormalizeSafe(Vector3 vec)
        {
            float num0 = vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z;

            if (num0 != 0.0f)
            {
                float num1 = 1.0f / (float)System.Math.Sqrt(num0);
                vec.X *= num1; vec.Y *= num1; vec.Z *= num1;
            }

            return vec;
        }


        public static void Orthonormalise(ref Matrix matrix)
        {
            float u11 = matrix.M11; float u12 = matrix.M12; float u13 = matrix.M13;
            float u21 = matrix.M21; float u22 = matrix.M22; float u23 = matrix.M23;
            float u31 = matrix.M31; float u32 = matrix.M32; float u33 = matrix.M33;

            float dot0, dot1;

            // u1
            float lengthSq0 = u11 * u11 + u12 * u12 + u13 * u13;
            float length0 = (float)System.Math.Sqrt(lengthSq0);
            u11 = u11 / length0;
            u12 = u12 / length0;
            u13 = u13 / length0;

            // u2
            dot0 = u11 * u21 + u12 * u22 + u13 * u23;
            u21 = u21 - dot0 * u11 / lengthSq0;
            u22 = u22 - dot0 * u12 / lengthSq0;
            u23 = u23 - dot0 * u13 / lengthSq0;

            float lengthSq1 = u21 * u21 + u22 * u22 + u23 * u23;
            float length1 = (float)System.Math.Sqrt(lengthSq1);
            u21 = u21 / length1;
            u22 = u22 / length1;
            u23 = u23 / length1;

            // u3
            dot0 = u11 * u31 + u12 * u32 + u13 * u33;
            dot1 = u21 * u31 + u22 * u32 + u23 * u33;
            u31 = u31 - dot0 * u11 / lengthSq0 - dot1 * u21 / lengthSq1;
            u32 = u32 - dot0 * u12 / lengthSq0 - dot1 * u22 / lengthSq1;
            u33 = u33 - dot0 * u13 / lengthSq0 - dot1 * u23 / lengthSq1;

            lengthSq0 = u31 * u31 + u32 * u32 + u33 * u33;
            length0 = (float)System.Math.Sqrt(lengthSq0);
            u31 = u31 / length0;
            u32 = u32 / length0;
            u33 = u33 / length0;

            matrix.M11 = u11; matrix.M12 = u12; matrix.M13 = u13;
            matrix.M21 = u21; matrix.M22 = u22; matrix.M23 = u23;
            matrix.M31 = u31; matrix.M32 = u32; matrix.M33 = u33;
        }

        /// Assumes dir is normalised. angle is in deg
        public static Matrix RotationMatrix(float ang, Vector3 dir)
        {
            return Matrix.CreateFromAxisAngle(dir, MathHelper.ToRadians(ang));
        }

        public static float Max(float a, float b, float c)
        {
            float abMax = a > b ? a : b;

            return abMax > c ? abMax : c;
        }

        public static float Min(float a, float b, float c)
        {
            float abMin = a < b ? a : b;

            return abMin < c ? abMin : c;
        }

        #endregion
    }


}
