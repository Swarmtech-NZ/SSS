using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ColorDetector
{
    public partial class ColorDetectForm : Form
    {
        Color actualColor;
        
 
        public ColorDetectForm()
        {
            InitializeComponent();
            actualColor = panelSelectedColor.BackColor;
        }

        private void ChooseImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Clearing previously selected image from picture box
                ImagePathLbl.Text = "";
                pictureBox1.Image = null;

                //Showing the File Chooser Dialog Box for Image File selection
                DialogResult IsFileChosen = openFileDialog1.ShowDialog();

                if (IsFileChosen == System.Windows.Forms.DialogResult.OK)
                {
                    //Get the File name
                    ImagePathLbl.Text = openFileDialog1.FileName;

                    //Load the image into a picture box
                    if (openFileDialog1.ValidateNames == true)
                    {
                        pictureBox1.Image = Image.FromFile(ImagePathLbl.Text);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PickColorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Clean previously selected color
                SelectedColorNameLbl.Text = "";
                panelSelectedColor.BackColor = actualColor;

                //Showing color choice
                DialogResult IsColorChosen = colorDialog1.ShowDialog();

                if (IsColorChosen == System.Windows.Forms.DialogResult.OK)
                {
                    panelSelectedColor.BackColor = colorDialog1.Color;

                    //If it is know color, display the color name  
                    if (colorDialog1.Color.IsKnownColor == true)
                    {
                        SelectedColorNameLbl.Text = colorDialog1.Color.ToKnownColor().ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DetectColorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean IsColorFound = false;

                if (pictureBox1.Image != null)
                {
                    //Converting loaded image into bitmap
                    Bitmap bmp = new Bitmap(pictureBox1.Image);

                    //Iterate whole bitmap to findout the picked color
                    for (int i = 0; i < pictureBox1.Image.Height; i++)
                    {
                        for (int j = 0; j < pictureBox1.Image.Width; j++)
                        {
                            //Get the color at each pixel
                            Color now_color = bmp.GetPixel(j, i);

                            //Compare Pixel's Color ARGB property with the picked color's ARGB property 
                            if (now_color.ToArgb() == colorDialog1.Color.ToArgb())
                            {
                                IsColorFound = true;
                                MessageBox.Show("Color Found!");
                                break;
                            }
                        }
                        if (IsColorFound == true)
                        {
                            break;
                        }
                    }

                    if (IsColorFound == false)
                    {
                        MessageBox.Show("Selected Color Not Found.");
                    }
                }
                else
                {
                    MessageBox.Show("Image is not loaded");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public bool calculateEcl(Color colourOfInterest, Color colourOfPixel, int allowance)
        {
            bool isSimilar = false;
            // Variables for calculating the euclidean distance between two colours. eg. Colour of interest vs Colour of current pixel.
            double inputRed = Convert.ToDouble(colourOfInterest.R);
            double inputGreen = Convert.ToDouble(colourOfInterest.G);
            double inputBlue = Convert.ToDouble(colourOfInterest.B);

            foreach (object o in WebColors)
            {
                // compute the Euclidean distance between the two colors
                // note, that the alpha-component is not used in this example
                double testRed = Math.Pow(Convert.ToDouble((colourOfPixel).R) - inputRed, 2.0);
                double testGreen = Math.Pow(Convert.ToDouble
                    ((colourOfPixel).G) - inputGreen, 2.0);
                double testBlue = Math.Pow(Convert.ToDouble
                    ((colourOfPixel).B) - inputBlue, 2.0);
                // it is not necessary to compute the square root
                // it should be sufficient to use:
                // temp = dbl_test_blue + dbl_test_green + dbl_test_red;
                // if you plan to do so, the distance should be initialized by 250000.0
                temp = Math.Sqrt(testBlue + testGreen + testRed);
                
                if(temp <= allowance)
                {
                    isSimilar = true;
                }
            }
            return isSimilar;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                e.Link.LinkData = "http://hemant-srivastava.blogspot.com/";
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
