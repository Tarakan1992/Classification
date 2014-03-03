using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classification
{
    public class NoiseGenerator
    {
        public static Bitmap MakeNoisy(Bitmap original, int percentOfNoise)
        {
            //var loopsNumber = ((original.Width * original.Height*percentOfNoise)/100);
            var randomGenerator = new Random();
            
            for ( int x = 0; x < original.Width; x ++)
            {
                for (int y = 0; y < original.Height; y ++)
                {
                    if (randomGenerator.Next(100) > percentOfNoise)
                    {
                        continue;
                    }
                    var currentColor = original.GetPixel(x, y);
                    var newColor = Color.FromArgb(255 - currentColor.R, 255 - currentColor.G, 255 - currentColor.B);
                    original.SetPixel(x, y, newColor);
                }
                
            }

            //for (int i = 0; i < loopsNumber; i++)
            //{
            //    x = randomGenerator.Next(0, original.Width);
            //    y = randomGenerator.Next(0, original.Height);
            //    var currentColor = original.GetPixel(x, y);
            //    var newColor = Color.FromArgb(255 - currentColor.R, 255 - currentColor.G, 255 - currentColor.B);
            //    original.SetPixel(x, y, newColor);
            //}
            
            return original;
        }
    }
}
