using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCores
{
    public partial class Form1 : Form
    {
        Color cor = Color.Black;

        //============================================

        public Form1()
        {
            InitializeComponent();
        }

        //============================================
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //============================================
        private void ApresentarCor()
        {
            //*trackbar1 red, trackbar2 green, trackbar3 blue.
            cor = Color.FromArgb(trackBar1.Value,
                                 trackBar2.Value,
                                 trackBar3.Value);
            pictureBox1.BackColor = cor;

            label4.Text = "RGB(" + trackBar1.Value + ";" +
                                   trackBar2.Value + ";" +
                                   trackBar3.Value + ")";
                                  
        }
        //============================================
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            ApresentarCor();
        }
        //============================================
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            ApresentarCor();
        }
        //============================================
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar3.Value.ToString();
            ApresentarCor();
        }
    }
}
