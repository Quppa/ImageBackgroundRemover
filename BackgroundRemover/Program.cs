// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Quppa.net">
//   Copyright (c) David Warner
// </copyright>
// <summary>
//   Generates transparent screenshots.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BackgroundRemover
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;

    /// <summary>
    /// Generates transparent screenshots.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main routine.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: BackgroundRemover imageout imageblack imagewhite");
                Environment.Exit(0);
            }

            if (!File.Exists(args[1]))
            {
                Console.WriteLine("File {0} does not exist.", args[1]);
                Environment.Exit(0);
            }

            if (!File.Exists(args[2]))
            {
                Console.WriteLine("File {0} does not exist.", args[2]);
                Environment.Exit(0);
            }

            if (!ImageOperations.IsValidImage(args[1]))
            {
                Console.WriteLine("File {0} couldn't be loaded as a bitmap.", args[1]);
                Environment.Exit(0);
            }

            if (!ImageOperations.IsValidImage(args[2]))
            {
                Console.WriteLine("File {0} couldn't be loaded as a bitmap.", args[2]);
                Environment.Exit(0);
            }

            Bitmap imageblack = new Bitmap(args[1]);
            Bitmap imagewhite = new Bitmap(args[2]);

            if (!ImageOperations.CheckDimensions(imageblack, imagewhite))
            {
                Console.WriteLine("Images have different dimensions.");
                Environment.Exit(0);
            }

            Bitmap imagetransparent = ImageOperations.RemoveBackground(imageblack, imagewhite);

            imagetransparent.Save(args[0], ImageFormat.Png);
        }
    }
}
