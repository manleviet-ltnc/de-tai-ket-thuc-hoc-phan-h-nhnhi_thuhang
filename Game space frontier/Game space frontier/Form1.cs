using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_space_frontier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // thay đổi kích thươc form.
            this.Size = new Size(558, 501);
            pt2.Size = new Size(77, 97);
            pt1.Size = new Size(49, 77);
            pt3.Size = new Size(43, 76);
            pt4.Size = new Size(19, 39);
            pt5.Size = new Size(17, 39);
            pt6.Size = new Size(15, 50);

            timer1.Interval = 10000;
            timer1.Start();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Pau&se")
            {
                timer1.Stop();
                btnStart.Text = "Re&sume";
            }
            else // "&Start" or "Re&sume"
            {
                timer1.Start();
                btnStart.Text = "Pau&se";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pt2 <= 0)
            {
                // We are finished
                timer1.Stop();
                Text = "Finished";
                btnStart.Text = "&Start";
                pt2 = 0;
            }
           


        }
    }
    }

