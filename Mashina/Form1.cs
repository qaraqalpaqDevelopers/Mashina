using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Mashina
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player=new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }
        private void jaylastiriw()
        {
            y2 = pictureBox2.Location.Y;
            y3 = pictureBox3.Location.Y;
            y4 = pictureBox4.Location.Y;
            y5 = pictureBox5.Location.Y;
            x6= pictureBox6.Location.X;
            x7= pictureBox7.Location.X;

            y6 = pictureBox6.Location.Y;
            y7 = pictureBox7.Location.Y;
           
            
            b1 = a1.Location.Y;
            b2= a2.Location.Y;
            b3= a3.Location.Y;
            b4= a4.Location.Y;
            b5= a5.Location.Y;
            b6 = a6.Location.Y;
            b7 = a7.Location.Y;
            b8 = a8.Location.Y;
            mx = car.Location.X;
            my = car.Location.Y;
           

        }
      
        

        

        
        int sekund = 0,y2=0, y3 = 0, y4 = 0, y5 = 0,x6=0,x7=0, y6 = 0,y7=0,mx=0,my=0,tik=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            tik++;
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left&&car.Location.X>190)
            {
                mx -= 25;
                car.Location = new Point(mx,my);
               
            }
            else if(e.KeyCode == Keys.Right&&car.Location.X < 400)
            {
                mx += 25;
                car.Location=new Point(mx,my);
            }

        }
       

        

        private void button1_Click(object sender, EventArgs e)
        {

            player.URL = @"ferrari.Mp3";
            jaylastiriw();
            timer1.Start();
            waqit.Start();
            button1.Visible = false;
            
        }

        int b1 =0,b2=0,b3=0, b4=0, b5=0, b6=0, b7=0, b8=0;

        private void waqit_Tick(object sender, EventArgs e)
        {
            if(car.Bounds.IntersectsWith(pictureBox6.Bounds))  
            {
                timer1.Stop();
                waqit.Stop();
            }
            if (car.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                timer1.Stop();
                waqit.Stop();
            }

            sekund++;
           
            y2 +=5;
            pictureBox2.Location=new Point(pictureBox2.Location.X,y2);
            y3+=5;
            pictureBox3.Location = new Point(pictureBox3.Location.X, y3);
            y4+=5;
            pictureBox4.Location = new Point(pictureBox4.Location.X, y4);
            y5+=5;
            pictureBox5.Location = new Point(pictureBox5.Location.X, y5);
            y6+=4;
            pictureBox6.Location = new Point(x6, y6);
            y7+=4;
            pictureBox7.Location = new Point(x7, y7);


            b1 += 8;
            a1.Location = new Point(a1.Location.X, b1);
            b2 += 8;
            a2.Location = new Point(a2.Location.X, b2);
            b3 += 8;
            a3.Location = new Point(a3.Location.X, b3);
            b4 += 8;
            a4.Location = new Point(a4.Location.X, b4);
            b5 += 8;
            a5.Location = new Point(a5.Location.X, b5);
            b6 += 8;
            a6.Location = new Point(a6.Location.X, b6);
            b7 += 8;
            a7.Location = new Point(a7.Location.X, b7);
            b8 += 8;
            a8.Location = new Point(a8.Location.X, b8);

            if (y7 > 500)
            {


                if (tik % 3 == 0)
                  x7 = 290;
                else if (tik % 3 == 1)
                    x7 = 400;
                else if (tik % 3 == 2)
                    x7 = 180;
                y7 = -100;
            }

            if (y2 > 500)
                y2 = 0;
            if (y3 > 500)
                y3 =0;
            if (y4 > 500)
                y4 = 0;
            if (y5 > 500)
                y5 = 0;
           
            if (y6 > 500)
            {
               

                if (tik % 3 == 0) 
                    x6 = 180;
                else if (tik % 3 == 1)
                    x6 = 290;
                else if (tik % 3 == 2)
                    x6 = 400;
                y6 = -100;
            }
           



            if (b1 > 500)
                b1 = 0;
            if (b2 > 500)
                b2 = 0;
            if (b3 > 500)
                b3 = 0;
            if (b4 > 500)
                b4 = 0;
            if (b5 > 500)
                b5 = 0;
            if (b6 > 500)
                b6 = 0;
            if (b7 > 500)
                b7 = 0;
            if (b8 > 500)
                b8 = 0;

        }
    }
}
