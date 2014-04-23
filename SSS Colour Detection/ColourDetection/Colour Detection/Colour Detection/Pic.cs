//Class for pictures to be checked
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Colour_Detection
{
    public class Pic : IComparable
    {
        //Private variables
        Bitmap picture;
        string filename;
        string longitude;
        string latitude;
        int numPix;
        double euclideanDistance;
        int width;
        int height;
        string type;
        
        //Propeties for class
        public Bitmap Picture
        {
            get { return picture;  }
        }

        public string Type
        {
            get { return type; }
        }

        public string Filename
        {
            get { return filename; }
        }

        public string Longitude
        {
            get { return longitude; }
        }

        public string Latitude
        {
            get { return latitude; }
        }

        public int NumPix
        {
            set { numPix = value; }
            get { return numPix; }
        }

        public double EuclideanDistance
        {
            set { euclideanDistance = value; }
            get { return euclideanDistance; }
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public Pic(string startFilename)
        {
            //Loads image
            picture = new Bitmap(startFilename);

            //initialises variables
            filename = startFilename;
            numPix = 0;
            euclideanDistance = 0.0;
            height = picture.Height;
            width = picture.Width;
            getGPSLong();
            getGPSLat();
        }

        private void getType()
        {
            //type = decodeEXIF(0x01);

            int[] pils = picture.PropertyIdList;
            int index = Array.IndexOf(pils, 0x01);
            PropertyItem pi = picture.PropertyItems[index];
            type = Convert.ToString(pi.Type);
        }

        private string decodeEXIF(int id)
        {
            try
            {
                int[] pils = picture.PropertyIdList;
                int index = Array.IndexOf(pils, id);

                if (index == -1)
                    return "-1";

                PropertyItem pi = picture.PropertyItems[index];

                if (pi.Type == 1)
                {
                    int iso = BitConverter.ToChar(pi.Value, 0);
                    return iso.ToString();
                }

                if (pi.Type == 2)
                    return Encoding.ASCII.GetString(pi.Value, 0, pi.Len - 1);


                if (pi.Type == 3)
                {
                    int iso = BitConverter.ToUInt16(pi.Value, 0);
                    return iso.ToString();
                }

                if (pi.Type == 4)
                {
                    uint iso = BitConverter.ToUInt32(pi.Value, 0);
                    return iso.ToString();
                }

                if (pi.Type == 7)
                {
                    return Encoding.ASCII.GetString(pi.Value, 0, pi.Len - 1);
                }

                return "-1";
            }
            catch
            {
                return "-1";
            }
        }

        private void getGPSLong()
        {
            int index;
            PropertyItem pi;
            int[] pils = picture.PropertyIdList;

            index = Array.IndexOf(pils, 0x04);

            pi = picture.PropertyItems[index];

            double deg = BitConverter.ToUInt32(pi.Value, 0);
            uint deg_div = BitConverter.ToUInt32(pi.Value, 4);

            double min = BitConverter.ToUInt32(pi.Value, 8);
            uint min_div = BitConverter.ToUInt32(pi.Value, 12);

            double mmm = BitConverter.ToUInt32(pi.Value, 16);
            uint mmm_div = BitConverter.ToUInt32(pi.Value, 20);

            double m = 0;
            if (deg_div != 0 || deg != 0)   
            {
                m = (deg / deg_div);
            }

            if (min_div != 0 || min != 0)
            {
                m = m + (min / min_div) / 60;
            }

            if (mmm_div != 0 || mmm != 0) 
            {
                m = m + (mmm / mmm_div / 3600);
            }

            if (decodeEXIF(0x03) == "W")
                m *= -1;

            longitude = m.ToString();
        }

        private void getGPSLat()
        {
            int index;
            PropertyItem pi;
            int[] pils = picture.PropertyIdList;

            //selects exif data related to latitude
            index = Array.IndexOf(pils, 0x02);

            pi = picture.PropertyItems[index];

            double deg = BitConverter.ToUInt32(pi.Value, 0);
            uint deg_div = BitConverter.ToUInt32(pi.Value, 4);

            double min = BitConverter.ToUInt32(pi.Value, 8);
            uint min_div = BitConverter.ToUInt32(pi.Value, 12);

            double mmm = BitConverter.ToUInt32(pi.Value, 16);
            uint mmm_div = BitConverter.ToUInt32(pi.Value, 20);

            double m = 0;

            if (deg_div != 0 || deg != 0)    
            {
                m = (deg / deg_div);
            }

            if (min_div != 0 || min != 0)
            {
                m = m + (min / min_div) / 60;
            }

            if (mmm_div != 0 || mmm != 0)
            {
                m = m + (mmm / mmm_div / 3600);
            }

            if (decodeEXIF(0x01) == "S")
                m *= -1;

            latitude = m.ToString();
        }

        public Color getPixelColour(int x, int y)
        {
            //Returns colour of selected pixel
            return picture.GetPixel(x, y);
        }

        public int CompareTo(object obj) //Sorts from highest number of pixels to least
        {
            Pic other = (Pic)obj;

            if (numPix < other.numPix)
            {
                return 1;
            }
            if (numPix > other.numPix)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
