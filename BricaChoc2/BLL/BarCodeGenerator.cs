using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Text;



namespace BLL
{
    class BarCodeGenerator
    {
        public string Texte { get; set; }
        private Bitmap bitmap { get; set; }

        //public BarCodeGenerator(string texte)
        //{
        //    this.Texte = texte;
        //    bitmap = new Bitmap(Texte.Length * 30, 150);
        //    using (Graphics graphics = Graphics.FromImage(bitmap))
        //    {
        //        Font oFont = new System.Drawing.Font("Code EAN13", 60);
        //        PointF point = new PointF(2f, 2f);
        //        SolidBrush black = new SolidBrush(Color.Black);
        //        SolidBrush white = new SolidBrush(Color.White);
        //        graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
        //        graphics.DrawString("*" + Texte + "*", oFont, black, point);

        //    }
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        bitmap.Save(ms, ImageFormat.Png);
        //        pictureBoxCodeBarre.Image = bitmap;
        //        pictureBoxCodeBarre.Height = bitmap.Height;
        //        pictureBoxCodeBarre.Width = bitmap.Width;
        //    }
        //}
    }
}
