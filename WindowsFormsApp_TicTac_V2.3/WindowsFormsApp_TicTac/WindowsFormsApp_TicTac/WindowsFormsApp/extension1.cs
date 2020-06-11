using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
   public  class extension1
    {

        private void drawImage(ref Graphics g, ref Rectangle Rct, string ImagePath)
        {
            // Draw image to screen.
            //Image newImage = Image.FromFile(@"C:\Users\Mehdi\Desktop\School\POO Second Project\quagmaire.jpg");
            Image newImage = Image.FromFile(ImagePath);
            // Draw image to screen.
            g.DrawImage(newImage, Rct);
           
        }
        public static void req1(ref Graphics f, ref Rectangle rct, string imgPath)
        {
            extension1 e = new extension1();
            e.drawImage(ref f, ref rct, imgPath);
        }
    }
}
