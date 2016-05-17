using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Text;


namespace IHM_Catalogue
{
    public partial class GenerateBarcode : Form
    {
        //[DllImport("gdi32.dll")]
        //private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        public GenerateBarcode()
        {
            InitializeComponent();
        }

        private void buttonGenerer_Click(object sender, EventArgs e)
        {
            string barcode = textBoxTextaGenerer.Text;
            Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Font oFont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*" + barcode + "*", oFont, black, point);

            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                pictureBoxCodeBarre.Image = bitmap;
                pictureBoxCodeBarre.Height = bitmap.Height;
                pictureBoxCodeBarre.Width = bitmap.Width;
            }
              

        }

        private void textBoxTextaGenerer_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
