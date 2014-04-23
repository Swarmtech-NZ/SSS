namespace Colour_Detection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dirLbl = new System.Windows.Forms.Label();
            this.contentsLb = new System.Windows.Forms.ListBox();
            this.currentImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colourPic = new System.Windows.Forms.ColorDialog();
            this.colourBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pixLbl = new System.Windows.Forms.Label();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.latLbl = new System.Windows.Forms.Label();
            this.longLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Enabled = false;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(214, 12);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(109, 50);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load Images";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory:";
            // 
            // dirLbl
            // 
            this.dirLbl.AutoSize = true;
            this.dirLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirLbl.Location = new System.Drawing.Point(94, 75);
            this.dirLbl.Name = "dirLbl";
            this.dirLbl.Size = new System.Drawing.Size(0, 17);
            this.dirLbl.TabIndex = 2;
            // 
            // contentsLb
            // 
            this.contentsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentsLb.FormattingEnabled = true;
            this.contentsLb.ItemHeight = 16;
            this.contentsLb.Location = new System.Drawing.Point(12, 110);
            this.contentsLb.Name = "contentsLb";
            this.contentsLb.Size = new System.Drawing.Size(311, 372);
            this.contentsLb.TabIndex = 3;
            this.contentsLb.SelectedIndexChanged += new System.EventHandler(this.contentsLb_SelectedIndexChanged);
            // 
            // currentImage
            // 
            this.currentImage.Location = new System.Drawing.Point(363, 12);
            this.currentImage.Name = "currentImage";
            this.currentImage.Size = new System.Drawing.Size(521, 471);
            this.currentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentImage.TabIndex = 4;
            this.currentImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Long:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lat:";
            // 
            // colourBtn
            // 
            this.colourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourBtn.Location = new System.Drawing.Point(12, 12);
            this.colourBtn.Name = "colourBtn";
            this.colourBtn.Size = new System.Drawing.Size(109, 50);
            this.colourBtn.TabIndex = 7;
            this.colourBtn.Text = "Pick Colour";
            this.colourBtn.UseVisualStyleBackColor = true;
            this.colourBtn.Click += new System.EventHandler(this.colourBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number Pixels of Colour:";
            // 
            // pixLbl
            // 
            this.pixLbl.AutoSize = true;
            this.pixLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pixLbl.Location = new System.Drawing.Point(655, 547);
            this.pixLbl.Name = "pixLbl";
            this.pixLbl.Size = new System.Drawing.Size(0, 17);
            this.pixLbl.TabIndex = 9;
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(12, 488);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(311, 23);
            this.pBar1.TabIndex = 10;
            // 
            // latLbl
            // 
            this.latLbl.AutoSize = true;
            this.latLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latLbl.Location = new System.Drawing.Point(480, 505);
            this.latLbl.Name = "latLbl";
            this.latLbl.Size = new System.Drawing.Size(0, 17);
            this.latLbl.TabIndex = 11;
            // 
            // longLbl
            // 
            this.longLbl.AutoSize = true;
            this.longLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longLbl.Location = new System.Drawing.Point(717, 505);
            this.longLbl.Name = "longLbl";
            this.longLbl.Size = new System.Drawing.Size(0, 17);
            this.longLbl.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 573);
            this.Controls.Add(this.longLbl);
            this.Controls.Add(this.latLbl);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.pixLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colourBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentImage);
            this.Controls.Add(this.contentsLb);
            this.Controls.Add(this.dirLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBtn);
            this.Name = "Form1";
            this.Text = "Swarmtech Software Squad\'s Colour Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dirLbl;
        private System.Windows.Forms.ListBox contentsLb;
        private System.Windows.Forms.PictureBox currentImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colourPic;
        private System.Windows.Forms.Button colourBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pixLbl;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.Label latLbl;
        private System.Windows.Forms.Label longLbl;

    }
}

