using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins_Activity
{
    static class Coins
    {
        public static void Binary(Bitmap reference, ref Bitmap result)
        {
            result = new Bitmap(reference.Width, reference.Height);
            Color pixel;
            int ave;
            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    pixel = reference.GetPixel(x, y);
                    ave = (pixel.R + pixel.G + pixel.B) / 3 ;
                    if (ave < 180)
                    {
                        result.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        result.SetPixel(x, y, Color.White);
                    }
                }
            }
        }

        public static void GetCoinPixels(
            Bitmap image, 
            ref int totalCount, 
            ref float totalValue, 
            ref int peso5Count, 
            ref int peso1Count, 
            ref int cent25Count, 
            ref int cent10Count, 
            ref int cent5Count
        )
        {
            bool[,] seen = new bool[image.Width, image.Height];
            Color pixel;

            for (int x = 0;x < image.Width; x++)
            {
                 for (int y = 0;y < image.Height; y++)
                {
                    if (seen[x, y])
                        continue;

                    seen[x, y] = true;

                    pixel = image.GetPixel(x, y);
                    int pixelCount;

                    // if pixel is black
                    if (pixel.R == 0)
                    {
                        pixelCount = GetPixelCount(image, x, y, ref seen);

                        //GetPixelCount sometimes scan objects with 1 to 100 pixels, so we skip those
                        if (pixelCount < 1000)
                            continue;

                        if (pixelCount > 7000)
                        {
                            peso5Count++;
                            totalValue += 5;
                        }
                        else if (pixelCount > 5000)
                        {
                            peso1Count++;
                            totalValue += 1;
                        }
                        else if (pixelCount > 4000)
                        {
                            cent25Count++;
                            totalValue += .25f;
                        }
                        else if (pixelCount > 3000)
                        {
                            cent10Count++;
                            totalValue += .10f;
                        }
                        else if ( pixelCount > 1000)
                        {
                            cent5Count++;
                            totalValue += .05f;
                        }

                        totalCount++;

                    }
                }
            }
        }

        private static int GetPixelCount(Bitmap image, int x, int y, ref bool[,] seen)
        {
            //Breadth First
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue([x, y]);
            int pixelCount = 0;
            int[] top;
            while (queue.Count > 0)
            {
                top = queue.Dequeue();
                pixelCount++;
                int currX = top[0], currY = top[1];
                
                //check top: if going upward doesn't go outside the image's bounds AND the pixel on top is BLACK AND that point is not yet seen
                if (currY - 1 >= 0 && image.GetPixel(currX, currY - 1).R == 0 && !seen[currX, currY - 1])
                {
                    queue.Enqueue([currX, currY - 1]);
                    seen[currX, currY - 1] = true;
                }
                //check bottom
                if (currY + 1 < image.Height && image.GetPixel(currX, currY + 1).R == 0 && !seen[currX, currY + 1])
                {
                    queue.Enqueue([currX, currY + 1]);
                    seen[currX, currY + 1] = true;
                }
                //check left
                if (currX - 1 >= 0 && image.GetPixel(currX - 1, currY).R == 0 && !seen[currX - 1, currY])
                {
                    queue.Enqueue([currX - 1, currY]);
                    seen[currX - 1, currY] = true;
                }
                //check right
                if (currX + 1 < image.Width && image.GetPixel(currX + 1, currY).R == 0 && !seen[currX + 1, currY])
                {
                    queue.Enqueue([currX + 1, currY]);
                    seen[currX + 1, currY] = true;
                }

            }

            return pixelCount;
        }

    }
}
