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

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vector.Gdi;
using Vector.Math;

namespace Vector.RayTracing
{
    public class Renderer
    {
        private int maxDepth = 5;

        private Intersection intersections(Ray ray, Scene scene)
        {
            float closest = float.MaxValue;



            Intersection closestInter = null;

            foreach (var thing in scene.things)
            {
                var inter = thing.intersect(ray);

                if (inter != null)
                {
                    if (inter.dist < closest)
                    {
                        closestInter = inter;

                        closest = inter.dist;
                    }
                }
            }

            return closestInter;
        }

        private float? testRay(Ray ray, Scene scene)
        {
            var isect = this.intersections(ray, scene);

            if (isect != null)
            {
                return isect.dist;
            }
            else
            {
                return null;
            }
        }

        private Color traceRay(Ray ray, Scene scene, int depth)
        {
            var isect = this.intersections(ray, scene);

            if (isect == null)
            {
                return Color.background;
            }
            else
            {
                return this.shade(isect, scene, depth);
            }
        }

        private Color shade(Intersection isect, Scene scene, int depth)
        {
            var d = isect.ray.Direction;
            
            var pos = (isect.dist * d) + isect.ray.Position;

            var normal = isect.thing.normal(pos);

            var reflectDir = d - ((normal * Vector3.Dot(normal, d)) * 2.0f);



            var naturalColor = Color.plus(Color.background,
                                          this.getNaturalColor(isect.thing, pos, normal, reflectDir, scene));
            var reflectedColor = (depth >= this.maxDepth) ? Color.grey : this.getReflectionColor(isect.thing, pos, normal, reflectDir, scene, depth);
            return Color.plus(naturalColor, reflectedColor);
        }

        private Color getReflectionColor(Object3D thing, Vector3 pos, Vector3 normal, Vector3 rd, Scene scene, int depth)
        {
            var n = thing.surface.reflect(pos);

            var c = this.traceRay(new Ray { Position = pos, Direction = rd }, scene, depth + 1);

            return Color.scale(thing.surface.reflect(pos), c);
        }

        private Color getNaturalColor(Object3D thing, Vector3 pos, Vector3 norm, Vector3 rd, Scene scene)
        {
            List<Color> colors = new List<Color>();

            foreach (var light in scene.lights)
            {
                var ldis  = light.pos - pos;

                var livec = Vector3.Normalize(ldis);

                var neatIsect = this.testRay(new Ray { Position = pos, Direction = livec }, scene);

                var isInShadow = (neatIsect == null) ? false : neatIsect.Value <= ldis.Length();

                if (isInShadow)
                {
                    colors.Add(Color.defaultColor);
                }
                else
                {
                    var illum = Vector3.Dot(livec, norm);

                    var lcolor = (illum > 0) ? Color.scale(illum, light.color) : Color.defaultColor;
                    
                    var specular = Vector3.Dot(livec, Vector3.Normalize(rd));
                    
                    var scolor = (specular > 0) ? Color.scale((float)System.Math.Pow(specular, thing.surface.roughness), light.color) : Color.defaultColor;
                    
                    var outc = Color.plus(Color.defaultColor, Color.plus(Color.times(thing.surface.diffuse(pos), lcolor), Color.times(thing.surface.specular(pos), scolor)));

                    colors.Add(outc);
                }
            }

            var cl = new Color(0, 0, 0);

            foreach (var c in colors)
            {
                cl.r += c.r;
                cl.g += c.g;
                cl.b += c.b;
            }

            return cl;

        }

        public Vector3 getPoint(int screenWidth, int screenHeight, int x, int y, Camera camera)
        {
            var recenterX = (x - (screenWidth / 2.0f)) / 2.0f / screenWidth;

            var recenterY = (y - (screenHeight / 2.0f)) / 2.0f / screenHeight;

            return Vector3.Normalize(camera.forward + (recenterX * camera.right) + (recenterY * camera.up));
        }

        public void render(Scene scene, Device device, int screenWidth, int screenHeight)
        {
            var output = new System.Drawing.Color[screenWidth, screenHeight];

            Parallel.ForEach(Enumerable.Range(0, screenHeight), (y) =>
            {
                Parallel.ForEach(Enumerable.Range(0, screenWidth), (x) =>
                {
                    var color = this.traceRay(new Ray { Position = scene.camera.pos, Direction = getPoint(screenWidth, screenHeight, x, y, scene.camera) }, scene, 0);

                    var c = Color.toDrawingColor(color);

                    output[x, y] = c;
                });

            });

            for (int x = 0; x < screenWidth; x++)
            {
                for (int y = 0; y < screenHeight; y++)
                {
                    device.DrawPixel(x, y, output[x, y]);
                }
            }
        }
    }
}
