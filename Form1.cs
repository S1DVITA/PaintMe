using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMe
{
    public partial class Form1 : Form
    {
        public Pen pen;
        public int penScroll;
        public SolidBrush brush;
        public Bitmap bitmap;
        public Graphics graph;
        public bool NumericChange;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            brush = new SolidBrush(colorPanel.BackColor);
            pen = new Pen(colorPanel.BackColor);
            StandartFormats.FormWidth = this.Width;
            StandartFormats.FormHeigth = this.Height;
            StandartFormats.PBoxWidth = pictureBox1.Width;
            StandartFormats.PBoxHeigth = pictureBox1.Height;
            NewImage(new Size(800, 600), Color.White, "Новый рисунок");
            PaintInf.LastPoint = new Point();
            PaintInf.IsNewLine = true;
            pictureBox1.AllowDrop = true;
        }

        public void NewImage(Size size,Color color, string name)
        {
            bitmap = new Bitmap(size.Width, size.Height);
            graph = Graphics.FromImage(bitmap);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graph.Clear(color);
            History.LoadHistory(bitmap);
            UpdateImage();
            RebootInterface();
            ResizePictureBox();
            UpdateSizeFormat();
            ReCountPenWidth();
            ResizeForm();
            this.Text = "PaintMe - " + name;
            resolutionToolStripStatusLabel.Text = $"Разрешение: {size.Width}*{size.Height}";
        }
        public void NewImage(Bitmap image, string name)
        {
            bitmap = image;
            graph = Graphics.FromImage(bitmap);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            History.LoadHistory(bitmap);
            UpdateImage();
            RebootInterface();
            ResizePictureBox();
            UpdateSizeFormat();
            ReCountPenWidth();
            ResizeForm();
            this.Text = "PaintMe - " + name;
            resolutionToolStripStatusLabel.Text = $"Разрешение: {image.Width}*{image.Height}";
        }

        public void RebootInterface()
        {
            this.WindowState = FormWindowState.Normal;
            //this.CenterToScreen();
            this.Width = StandartFormats.FormWidth;
            this.Height = StandartFormats.FormHeigth;
            pictureBox1.Width = StandartFormats.PBoxWidth;
            pictureBox1.Height = StandartFormats.PBoxHeigth;
            ResizePictureBox();
            UpdatePenWidthElem(new object(), new EventArgs());
        }

        public void ResizeForm()
        {
            if (ImageFactor.MainImageFactor < 4)
            {
                OnResizeBegin(new EventArgs());
                this.Width = (int)(this.Width - (StandartFormats.PBoxWidth - (pictureBox1.Height * ImageFactor.MainImageFactor)));
                this.Height = (int)(this.Height - (StandartFormats.PBoxHeigth - (pictureBox1.Width / ImageFactor.MainImageFactor)));
                OnResizeEnd(new EventArgs());
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                NewImage((Bitmap)Bitmap.FromFile(openFileDialog1.FileName), openFileDialog1.FileName);
            }
            else
                return;
        }

        public void UpdateSizeFormat()
        {
            try
            {
                ImageFactor.UpdateSizeFormat(
                    (double)bitmap.Height / pictureBox1.Height,
                    (double)bitmap.Width / pictureBox1.Width,
                    (double)bitmap.Width / (double)bitmap.Height);
            }
            catch { };
        }

        public void ResizePictureBox()
        {
            UpdateSizeFormat();
            ImageFactor.PictureBoxWidth = pictureBox1.Width;
            ImageFactor.PictureBoxHeigth = pictureBox1.Height;
            int PictureBoxWidth = (int)(pictureBox1.Height * ImageFactor.MainImageFactor);
            int PictureBoxHeigth = (int)(pictureBox1.Width / ImageFactor.MainImageFactor);
            double MainPictureBoxFactor = (double)pictureBox1.Width / (double)pictureBox1.Height;
            if (MainPictureBoxFactor > ImageFactor.MainImageFactor)
                pictureBox1.Width = PictureBoxWidth;
            else if (MainPictureBoxFactor < ImageFactor.MainImageFactor)
                pictureBox1.Height = PictureBoxHeigth;
            UpdateSizeFormat();
        }

        public void UpdatePenWidthElem(object sender, EventArgs e)
        {
            double resolution = (bitmap.Width * 1.0) / (pictureBox1.Width * 1.0);
            int penWidth = (int)((int)penSizeNumericUpDown.Value * 1.0 / resolution);
            if (sender == penSizeNumericUpDown)
            {
                pen.Width = (int)penSizeNumericUpDown.Value;
                penScroll = (int)pen.Width / 2;
                penSizeTrackBar.Maximum = (int)(94 * resolution);
                if (pen.Width <= penSizeTrackBar.Maximum)
                    penSizeTrackBar.Value = (int)pen.Width;
                else penSizeTrackBar.Value = penSizeTrackBar.Maximum;
            }
            UpdatePenWidthPanels(penWidth);
        }

        public void UpdatePenWidthPanels(int penWidth)
        {
            try
            {
                if (penWidth < penWidthPanel.Size.Width)
                {
                    Image image = null;
                    if (penWidthPanel.BackgroundImage != null) image = penWidthPanel.BackgroundImage;
                    penWidthPanel.BorderStyle = BorderStyle.None;
                    Bitmap bitM = new Bitmap(penWidth, penWidth);
                    var g = Graphics.FromImage(bitM);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(brush, 0, 0, penWidth, penWidth);
                    penWidthPanel.BackgroundImage = bitM;
                    if(image != null) image.Dispose();
                    g.Dispose();
                }
                else
                {
                    penWidthPanel.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch (DivideByZeroException) { }
            catch { }
        }

        public void UpdateImage()
        {
            pictureBox1.Image = bitmap;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                bitmap.Save(saveFileDialog1.FileName);
                this.Text = $"PaintMe - {saveFileDialog1.FileName}";
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (PaintInf.drow == true && bitmap != null)
            {
                Point point = new Point(
                    (int)Math.Round(e.X * ImageFactor.WidthImageFactor),
                    (int)Math.Round(e.Y * ImageFactor.HeightImageFactor));
                graph.FillEllipse(brush, point.X - penScroll, point.Y - penScroll, pen.Width, pen.Width);
                PaintInf.LastPoint = point;
                UpdateImage();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (PaintInf.drow == true && bitmap != null)
            {
                Point point = new Point(
                    (int)Math.Round(e.X * ImageFactor.WidthImageFactor),
                    (int)Math.Round(e.Y * ImageFactor.HeightImageFactor));
                if (PaintInf.IsNewLine)
                {
                    graph.FillEllipse(brush, point.X - penScroll, point.Y - penScroll, pen.Width, pen.Width);
                    PaintInf.LastPoint = point;
                    PaintInf.IsNewLine = false;
                }
                else
                {
                    graph.FillEllipse(brush, point.X - penScroll, point.Y - penScroll, pen.Width, pen.Width);
                    graph.DrawLine(pen, PaintInf.LastPoint, point);
                    PaintInf.LastPoint = point;
                }
                UpdateImage();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            History.HistoryGraph.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            PaintInf.drow = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PaintInf.drow = false;
            PaintInf.IsNewLine = true;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                ResizePictureBox();
                UpdateSizeFormat();
                UpdatePenWidthElem(sender, e);
            }
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            pictureBox1.Width = ImageFactor.PictureBoxWidth;
            pictureBox1.Height = ImageFactor.PictureBoxHeigth;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorPanel.BackColor = colorDialog1.Color;
        }

        private void colorPanel_BackColorChanged(object sender, EventArgs e)
        {
            pen.Color = colorPanel.BackColor;
            brush.Color = colorPanel.BackColor;
            UpdatePenWidthElem(sender, e);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int previewBitmap = bitmap.GetHashCode();
            CreateForm form = new CreateForm(this);
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Bitmap el = (Bitmap)bitmap.Clone();
            graph.DrawImage(History.PreImage,0,0,bitmap.Width, bitmap.Height);
            History.HistoryGraph.DrawImage(el, 0, 0, bitmap.Width, bitmap.Height);
            el.Dispose();
            UpdateImage();
        }

        public void ReCountPenWidth()
        {
            try
            {
                penSizeNumericUpDown.Value = (bitmap.Width * bitmap.Height) / 48000;
            }
            catch { penSizeNumericUpDown.Value = penSizeNumericUpDown.Minimum; }
        }

        private void rebootButton_Click(object sender, EventArgs e)
        {
            History.HistoryGraph.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            graph.DrawImage(History.FirstImage, 0, 0, bitmap.Width, bitmap.Height);
            UpdateImage();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void rebootUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RebootInterface();
            ResizeForm();
        }

        //Фильтры
        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.HistoryGraph.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            mainToolStripProgressBar.Value = 0;
            mainToolStripProgressBar.Visible = true;
            int kol = (bitmap.Width * bitmap.Height) / mainToolStripProgressBar.Maximum + 1;
            int f = 0;
            for (int j = 0; j < bitmap.Height; j++)
                for (int i = 0; i < bitmap.Width; i++)
                {
                    int r = bitmap.GetPixel(i, j).R;
                    int g = bitmap.GetPixel(i, j).G;
                    int b = bitmap.GetPixel(i, j).B;
                    int a = (r + g + b) / 3;
                    bitmap.SetPixel(i, j, Color.FromArgb(a, a, a));
                    f++;
                    if (f >= kol)
                    {
                        mainToolStripProgressBar.Value += 2;
                        mainToolStripProgressBar.Value -= 1;
                        f = 0;
                    }
                }
            UpdateImage();
            mainToolStripProgressBar.Visible = false;
        }
        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.HistoryGraph.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            mainToolStripProgressBar.Value = 0;
            mainToolStripProgressBar.Visible = true;
            int kol = (bitmap.Width * bitmap.Height) / mainToolStripProgressBar.Maximum + 1;
            int f = 0;
            for (int j = 0; j < bitmap.Height; j++)
                for (int i = 0; i < bitmap.Width; i++)
                {
                    int r = bitmap.GetPixel(i, j).R;
                    int g = bitmap.GetPixel(i, j).G;
                    int b = bitmap.GetPixel(i, j).B;
                    bitmap.SetPixel(i, j, Color.FromArgb(255-r, 255-g, 255-b));
                    f++;
                    if (f >= kol)
                    {
                        mainToolStripProgressBar.Value += 2;
                        mainToolStripProgressBar.Value -= 1;
                        f = 0;
                    }
                }
            UpdateImage();
            mainToolStripProgressBar.Visible = false;
        }
        private void monoBinaryPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.HistoryGraph.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            mainToolStripProgressBar.Value = 0;
            mainToolStripProgressBar.Visible = true;
            int kol = (bitmap.Width * bitmap.Height) / mainToolStripProgressBar.Maximum + 1;
            int f = 0;
            for (int j = 0; j < bitmap.Height; j++)
                for (int i = 0; i < bitmap.Width; i++)
                {
                    int r = bitmap.GetPixel(i, j).R;
                    int g = bitmap.GetPixel(i, j).G;
                    int b = bitmap.GetPixel(i, j).B;
                    if (r + g + b < 153) bitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else if (r + g + b >= 153 && r + g + b <= 306) bitmap.SetPixel(i, j, Color.FromArgb(64, 64, 64));
                    else if (r + g + b > 306 && r + g + b <= 459) bitmap.SetPixel(i, j, Color.FromArgb(128, 128, 128));
                    else if (r + g + b > 459 && r + g + b <= 612) bitmap.SetPixel(i, j, Color.FromArgb(192, 192, 192));
                    else if (r + g + b > 612) bitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    f++;
                    if (f >= kol)
                    {
                        mainToolStripProgressBar.Value += 2;
                        mainToolStripProgressBar.Value -= 1;
                        f = 0;
                    }
                }
            UpdateImage();
            mainToolStripProgressBar.Visible = false;
        }
        private void colorBinaryPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.HistoryGraph.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            mainToolStripProgressBar.Value = 0;
            mainToolStripProgressBar.Visible = true;
            int kol = (bitmap.Width * bitmap.Height) / mainToolStripProgressBar.Maximum + 1;
            int f = 0;
            for (int j = 0; j < bitmap.Height; j++)
                for (int i = 0; i < bitmap.Width; i++)
                {
                    int r = bitmap.GetPixel(i, j).R;
                    int g = bitmap.GetPixel(i, j).G;
                    int b = bitmap.GetPixel(i, j).B;
                    if (r < 32) r = 0;
                    else if (r < 64) r = 64;
                    else if (r < 128) r = 128;
                    else if (r < 192) r = 192;
                    else r = 255;
                    if (g < 32) g = 0;
                    else if (g < 64) g = 64;
                    else if (g < 128) g = 128;
                    else if (g < 192) g = 192;
                    else g = 255;
                    if (b < 32) b = 0;
                    else if (b < 64) b = 64;
                    else if (b < 128) b = 128;
                    else if (b < 192) b = 192;
                    else b = 255;
                    bitmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                    f++;
                    if (f >= kol)
                    {
                        mainToolStripProgressBar.Value += 2;
                        mainToolStripProgressBar.Value -= 1;
                        f = 0;
                    }
                }
            UpdateImage();
            mainToolStripProgressBar.Visible = false;
        }
        private void colorScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.HistoryGraph.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            mainToolStripProgressBar.Value = 0;
            mainToolStripProgressBar.Visible = true;
            int kol = (bitmap.Width * bitmap.Height) / mainToolStripProgressBar.Maximum + 1;
            int f = 0;
            for (int j = 0; j < bitmap.Height; j++)
                for (int i = 0; i < bitmap.Width; i++)
                {
                    int r = bitmap.GetPixel(i, j).R;
                    int g = bitmap.GetPixel(i, j).G;
                    int b = bitmap.GetPixel(i, j).B;
                    bitmap.SetPixel(i, j, Color.FromArgb(g, b, r));
                    f++;
                    if (f >= kol)
                    {
                        mainToolStripProgressBar.Value += 2;
                        mainToolStripProgressBar.Value -= 1;
                        f = 0;
                    }
                }
            UpdateImage();
            mainToolStripProgressBar.Visible = false;
        }
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить изображение?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    bitmap.Save(saveFileDialog1.FileName);
                    this.Text = $"PaintMe - {saveFileDialog1.FileName}";
                }
                else e.Cancel = true;
            }
            if (result == DialogResult.Cancel) e.Cancel = true;
        }

        private void penSizeNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyData == Keys.Enter)
                {
                    e.Handled = e.SuppressKeyPress = true;
                }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Width = borderPanel.Width;
            pictureBox1.Height = borderPanel.Height;
            ResizePictureBox();
            UpdateSizeFormat();
            UpdatePenWidthElem(sender, e);
        }

        private void loadBufferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Image image = Clipboard.GetImage();
                NewImage((Bitmap)image, "Изображение из буфера");
            }
            else MessageBox.Show("В буфере нет изображения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }
        private void copyToBufferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(bitmap);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            penSizeNumericUpDown.Value = penSizeTrackBar.Value;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
                NewImage((Bitmap)Bitmap.FromFile(files[0]), "Новое изображение");
            else MessageBox.Show("Нельзя перетаскивать несколько файлов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
