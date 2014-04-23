using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Colour_Detection
{
    public partial class Form1 : Form
    {
        //Allowance for colour detection
        static int Allowance = 50;
        
        //List to hold Pic class
        List<Pic> images;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            //Clears list box
            contentsLb.Items.Clear();

            //Displays dialog for selecting folder
            folderBrowser.ShowDialog();

            //Displays path selected
            dirLbl.Text = folderBrowser.SelectedPath;

            //Loads file information
            DirectoryInfo di = new DirectoryInfo(folderBrowser.SelectedPath);
            FileInfo[] fi = di.GetFiles();

            //Calculates size of step for progress bar
            int num = fi.Length;
            pBar1.Maximum = num * 10 - 10;

            foreach (FileInfo f in fi)
            {
                if (f.Extension == ".jpg")
                {
                    //Creates new instance of class
                    Pic p = new Pic(f.FullName);

                    //Checks for colour
                    ColourDetect.findColour(p, colourPic.Color, Allowance);

                    //Adds to list
                    images.Add(p);

                    //Takes step on progress bar
                    pBar1.PerformStep();
                }
            }

            //sorts list
            images.Sort();

            //Loads into listbox
            foreach (Pic p in images)
            {
                contentsLb.Items.Add(p.Filename);
            }

            //Loads first image
            currentImage.Image = images[0].Picture;
            pixLbl.Text = Convert.ToString(images[0].NumPix);
            latLbl.Text = images[0].Latitude;
            longLbl.Text = images[0].Longitude;
        }

        private void contentsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Loads selected image
            currentImage.Image = images[contentsLb.SelectedIndex].Picture;
            pixLbl.Text = Convert.ToString(images[contentsLb.SelectedIndex].NumPix);
            latLbl.Text = images[contentsLb.SelectedIndex].Latitude;
            longLbl.Text = images[contentsLb.SelectedIndex].Longitude;
        }

        private void colourBtn_Click(object sender, EventArgs e)
        {
            colourPic.FullOpen = true;
            colourPic.ShowDialog();

            loadBtn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialises variable
            images = new List<Pic>();
        }
    }
}
