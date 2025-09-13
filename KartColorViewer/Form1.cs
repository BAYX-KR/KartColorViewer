using System.Drawing;

namespace KartColorViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"#{this.panel1.BackColor.A:X2}{this.panel1.BackColor.R:X2}{this.panel1.BackColor.G:X2}{this.panel1.BackColor.B:X2}\nR: {this.panel1.BackColor.R} G: {this.panel1.BackColor.G} B: {this.panel1.BackColor.B}";
            textBox1.Text = $"{this.panel1.BackColor.A} {this.panel1.BackColor.R} {this.panel1.BackColor.G} {this.panel1.BackColor.B}"; ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ARGB = textBox1.Text.Split(' ');
            int A = int.Parse(ARGB[0]);
            int R = int.Parse(ARGB[1]);
            int G = int.Parse(ARGB[2]);
            int B = int.Parse(ARGB[3]);
            Color c = Color.FromArgb(A, R, G, B);
            this.panel1.BackColor = c;
            label1.Text = $"#{this.panel1.BackColor.A:X2}{this.panel1.BackColor.R:X2}{this.panel1.BackColor.G:X2}{this.panel1.BackColor.B:X2}\nR: {this.panel1.BackColor.R} G: {this.panel1.BackColor.G} B: {this.panel1.BackColor.B}";
        }
    }
}
