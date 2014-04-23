using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Colour_Detection
{
    public static class ColourDetect
    {
        public static int findColour(Pic im, Color toFind, int Allowance)
        {
            //Return value
            int numFound = 0;

            for (int w = 0; w < im.Width; w++)
            {
                for (int h = 0; h < im.Height; h++)
                {
                    //Gets pixel
                    Color p = im.getPixelColour(w, h);

                    if (detect(p, toFind, Allowance))
                    {
                        //Increments number of pixels containing colour
                        im.NumPix++;
                    }
                }
            }

            //Value returned
            return numFound;
        }

        private static bool detect(Color c, Color toFind, int Allowance)
        {
            //Return value
            bool found = false;

            //Variables for calculating the the distance between two colours
            double inputRed = Convert.ToDouble(c.R);
            double inputGreen = Convert.ToDouble(c.G);
            double inputBlue = Convert.ToDouble(c.B);

            //Computes euclidean distance
            double testRed = Math.Pow(Convert.ToDouble(toFind.R) - inputRed, 2.0);
            double testGreen = Math.Pow(Convert.ToDouble(toFind.G) - inputGreen, 2.0);
            double testBlue = Math.Pow(Convert.ToDouble(toFind.B) - inputBlue, 2.0);
            double temp = Math.Sqrt(testBlue + testGreen + testRed);

            //Checks if close to colour
            if (temp <= Allowance)
            {
                found = true;
            }

            //Value returned
            return found;
        }
    }
}
