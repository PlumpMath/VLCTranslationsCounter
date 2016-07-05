using System;
using System.Drawing;

namespace VLCTranslationsCounter
{
    class IconMaker
    {
        public Icon MakeIcon(String text)
        {

            Color color = Color.FromArgb(175, 255, 255);
            Font font = new Font("Times New Roman", 11.0f);
            Brush brush = new SolidBrush(color);

            // Create a bitmap and draw text on it
            Bitmap bitmap = new Bitmap(16, 16);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawString(text, font, brush, -1, 0);

            // Convert the bitmap with text to an Icon
            IntPtr hIcon = bitmap.GetHicon();
            Icon icon = Icon.FromHandle(hIcon);
            return icon;
        }
    }
}
