using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace image_bluring
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.pictureBox1.Image = new Bitmap(ofile.FileName);
            }
        }

        private void btnblur_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pictureBox1.Image);
            Bitmap result = Blurs.Blur(copy, 2);
            this.pictureBox2.Image = (Image)result;
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.InitialDirectory = "C:\\Users";
            ofile.IsFolderPicker = 
            this.pictureBox2.Image.Save("C:\\Users\\aitko\\Pictures\\555.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

    }
}
