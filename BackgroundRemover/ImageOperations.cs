namespace BackgroundRemover
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    public class ImageOperations
    {
        public static Bitmap BlackBitmap { get; set; }
        
        public static Bitmap WhiteBitmap { get; set; }

        public static Bitmap Result { get; set; }

        public static Bitmap RemoveBackground(Bitmap imageblack, Bitmap imagewhite)
        {
            BlackBitmap = imageblack;
            WhiteBitmap = imagewhite;

            RemoveBackgroundAsync(null, null);

            return Result;
        }

        public static void RemoveBackgroundAsync(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            Bitmap imagetransparent = new Bitmap(BlackBitmap.Width, WhiteBitmap.Height);

            BackgroundWorker worker = sender as BackgroundWorker;

            byte r0, g0, b0, r1, aS, rS, gS, bS;

            for (int y = 0; y < BlackBitmap.Height; y++)
            {
                for (int x = 0; x < BlackBitmap.Width; x++)
                {
                    r0 = BlackBitmap.GetPixel(x, y).R;
                    g0 = BlackBitmap.GetPixel(x, y).G;
                    b0 = BlackBitmap.GetPixel(x, y).B;
                    r1 = WhiteBitmap.GetPixel(x, y).R;
                    aS = (byte)(r0 - r1 + byte.MaxValue);
                    if (aS == 255)
                    {
                        rS = r0;
                        gS = g0;
                        bS = b0;
                    }
                    else if (aS == 0)
                    {
                        rS = 0;
                        gS = 0;
                        bS = 0;
                    }
                    else
                    {
                        rS = (byte)Math.Round(255 * (r0 / (double)aS));
                        gS = (byte)Math.Round(255 * (g0 / (double)aS));
                        bS = (byte)Math.Round(255 * (b0 / (double)aS));
                    }

                    imagetransparent.SetPixel(x, y, Color.FromArgb(aS, rS, gS, bS));
                }

                if (worker != null)
                    worker.ReportProgress((int)Math.Round(100 * (y / (double)BlackBitmap.Height)));
            }

            Result = imagetransparent;
        }

        public static bool IsValidImage(string path)
        {
            try
            {
                Bitmap bitmap = new Bitmap(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CheckDimensions(Bitmap bitmap1, Bitmap bitmap2)
        {
            return bitmap1.Width == bitmap2.Width
                && bitmap1.Height == bitmap2.Height;
        }
    }
}
