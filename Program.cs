using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMe
{
    public static class ImageFactor
    {
        public static double HeightImageFactor;
        public static double WidthImageFactor;
        public static double MainImageFactor;

        public static int PictureBoxWidth;
        public static int PictureBoxHeigth;

        public static void UpdateSizeFormat(double hFactor, double wFactor, double mFactor)
        {
            ImageFactor.HeightImageFactor = hFactor;
            ImageFactor.WidthImageFactor = wFactor;
            ImageFactor.MainImageFactor = mFactor;
        }
    }

    public static class History
    {
        public static Graphics HistoryGraph;
        public static Bitmap PreImage;
        public static Bitmap FirstImage;

        public static void LoadHistory(Bitmap image)
        {
            PreImage = new Bitmap(image);
            FirstImage = new Bitmap(image);
            HistoryGraph = Graphics.FromImage(PreImage);
        }
    }

    public static class StandartFormats
    {
        public static int FormWidth;
        public static int FormHeigth;

        public static int PBoxWidth;
        public static int PBoxHeigth;
    }

    public static class PaintInf
    {
        public static bool IsNewLine;
        public static Point LastPoint;
        public static bool drow;
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
