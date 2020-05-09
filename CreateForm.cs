using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMe
{
    public partial class CreateForm : Form
    {
        public static Form1 DelegateForm;

        public CreateForm()
        {
            InitializeComponent();
        }

        public CreateForm(object Delegate)
        {
            DelegateForm = (Form1)Delegate;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(widthTextBox.Text) > 0 && int.Parse(heigthtBox.Text) > 0)
                {
                    var size = new Size(int.Parse(widthTextBox.Text), int.Parse(heigthtBox.Text));
                    DelegateForm.NewImage(size, colorPanel.BackColor, "Новый рисунок");
                    Close();
                }
                else throw new ArgumentException();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Неверные параметры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { MessageBox.Show("Неизвестная ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            colorPanel.BackColor = colorDialog1.Color;
        }
    }
}
