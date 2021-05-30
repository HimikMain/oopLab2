using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Bitmap bmp; 
        Color color;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            color = Color.Black;
            ToolTip t = new ToolTip();
            t.SetToolTip(buttonLine, "x1, y1, x2, y2");
            t.SetToolTip(buttonRect, "x1, y1, Ширина, Высота");
            t.SetToolTip(buttonEllipse, "x1, y1, Ширина, Высота");
            t.SetToolTip(buttonArc, "x1, y1, Ширина, Высота, Начальный угол, Конечный угол");
            t.SetToolTip(buttonTriangle, "x1, y1, x2, y2, x3, y3");
            t.SetToolTip(buttonFifthangle, "x1, y1, x2, y2, x3, y3, x4, y4, x5, y5");
            MessageBox.Show("Значения в пропущенных полях будут равнятся нулю");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Line line = new Line(getNumFromTextBox(textBox1.Text), getNumFromTextBox(textBox2.Text), getNumFromTextBox(textBox3.Text), getNumFromTextBox(textBox4.Text), color);
            line.Draw(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonRect_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Rectangle rectangle = new Rectangle(getNumFromTextBox(textBox1.Text), getNumFromTextBox(textBox2.Text), getNumFromTextBox(textBoxWidth.Text), getNumFromTextBox(textBoxHeight.Text), color);
            rectangle.Draw(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Ellipse ellipse = new Ellipse(getNumFromTextBox(textBox1.Text), getNumFromTextBox(textBox2.Text), getNumFromTextBox(textBoxWidth.Text), getNumFromTextBox(textBoxHeight.Text), color);
            ellipse.Draw(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonArc_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Arc arc = new Arc(getNumFromTextBox(textBox1.Text), getNumFromTextBox(textBox2.Text), getNumFromTextBox(textBoxWidth.Text), getNumFromTextBox(textBoxHeight.Text), getNumFromTextBox(textBoxStartAngle.Text), getNumFromTextBox(textBoxSweepAngle.Text), color);
            arc.Draw(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Triangle triangle = new Triangle(getNumFromTextBox(textBox1.Text), getNumFromTextBox(textBox2.Text), getNumFromTextBox(textBox3.Text), getNumFromTextBox(textBox4.Text), getNumFromTextBox(textBox5.Text), getNumFromTextBox(textBox6.Text), color);
            triangle.Draw(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonFifthangle_Click(object sender, EventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pentagon pentagon = new Pentagon(getNumFromTextBox(textBox1.Text), getNumFromTextBox(textBox2.Text), getNumFromTextBox(textBox3.Text), getNumFromTextBox(textBox4.Text), getNumFromTextBox(textBox5.Text), getNumFromTextBox(textBox6.Text), getNumFromTextBox(textBox7.Text), getNumFromTextBox(textBox8.Text), getNumFromTextBox(textBox9.Text), getNumFromTextBox(textBox10.Text), color);
            pentagon.Draw(graph);
            pictureBox1.Image = bmp;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                color = colorDialog1.Color;
        }

        public int getNumFromTextBox(String textBox)
        {
            int num;
            num = (int.TryParse(textBox, out num)) ? num : 0;
            return num;
        }
    }
}
