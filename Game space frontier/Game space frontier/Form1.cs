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


         int x_pt1=258;
         int y_pt1=281;
        int x_pt2= 245;
        int y_pt2= 346;
        int x_pt3=259;
        int y_pt3=208;
        int x_pt4=271;
        int y_pt4=177;
        int x_pt5=271;
        int y_pt5 = 141;
        int x_pt6=272;
        int y_pt6=97;
        //private Position _objPosition;

        public Form1()
        {
            InitializeComponent();
            //_X = 500;
            //_Y = 500;
            //_objPosition = Position.Down;





           
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

            
        }

        

        private void btnStart_Click(object sender, EventArgs e)
        {
            //if (btnStart.Text == "Pau&se")
            //{
            //    timer1.Stop();
            //    btnStart.Text = "Re&sume";
            //}
            //else // "&Start" or "Re&sume"
            //{
            //    timer1.Start();
            //    btnStart.Text = "Pau&se";
            //}
            timer1.Interval = 100;
            timer1.Start();
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            y_pt1 -= 10;
            pt1.Location = new Point(x_pt1, y_pt1);
            y_pt2 -= 10;
            pt2.Location = new Point(x_pt2, y_pt2);
            y_pt3 -= 10;
            pt3.Location = new Point(x_pt3, y_pt3);
            y_pt4 -= 10;
            pt4.Location = new Point(x_pt4, y_pt4);
            y_pt5 -= 10;
            pt5.Location = new Point(x_pt5, y_pt5);
            y_pt6 -= 10;
            pt6.Location = new Point(x_pt6, y_pt6);
            Form1 f = new Form1();
            
        }

        private void pt2_MouseDown(object sender, MouseEventArgs e)
        {
            pt2.Hide();
            pt3.Hide();
            pt4.Hide();
            pt5.Hide();
            pt6.Hide();
        }
    }
}
                
       
       

    
    


