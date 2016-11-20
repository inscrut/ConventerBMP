using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ConventerBMP
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Image img = new Bitmap(item);
                img.Save(Path.GetFileNameWithoutExtension(item) + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }
    }
}
