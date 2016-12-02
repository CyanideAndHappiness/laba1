using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba_1
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Bitmap pixel;
        Bitmap bmp;
        MemoryStream mem;

        //Random K = new Random(50);
        
        public Form1()
        {
            InitializeComponent();
            // инициализация графики в битмапе 
            pixel = new Bitmap(1, 1);
            pixel.SetPixel(0, 0, Color.Black);
            bmp = new Bitmap(pixel);
            mem = new MemoryStream();

            
        }
       
        
     
    // Простой алгоритм для прямой   \(^_^)/
    void myLinePlain(double xt, double yt, double k)
        {

            
            gr = pictureOne.CreateGraphics(); 


          
           // int x, y;  
            while (xt < 100)
            {
                yt = k * xt;
               // x = Convert.ToInt32(xt); y = Convert.ToInt32(yt);
                gr.DrawImage(pixel, (int)xt, (int)yt);
                xt += 0.01;
            }
        }


        
       

        // Алгоритм Брезенхема для прямой
        void myLineBrez (double x1, double y1)
        {
            
           
            gr = pictureTwo.CreateGraphics();

            double  k, error, x0, y0;
            x0 = 0; y0 = 0;
            error = 0;
           
            while (x0<x1)
            {
                gr.DrawImage(pixel, (int)x0, (int)y0);
                k = Math.Abs((y1 - y0) / (x1 - x0));
                error = error + k;

                if (error < 0.5)
                {
                    x0 = x0+1;
                    gr.DrawImage(pixel, (int)x0, (int)y0);
                }

                if (error > 0.5)
                {
                    x0 = x0+ 1; y0 = y0 + 1;
                    gr.DrawImage(pixel, (int)x0, (int)y0);
                    error = error - 1;
                }
                if (error == k)
                {
                    gr.DrawImage(pixel, (int)x0, (int)y0);
                }
            } 
        }


        // Простой алгоритм для окружности
        void myCircle(double r, double x, double y)
        {
            gr = pictureOne.CreateGraphics();
            double a, x1, y1, x2, y2;
            x2 = x + r; y2 = y;
            for (a = 1; a <= 360; a++)
            {
                x1 = x2; y1 = y2;
                x2 = (r * Math.Cos(a)) + x;
                y2 = (r * Math.Sin(a)) + x;              
                gr.DrawImage(pixel, (int)x2, (int)y2);
            }
        }
        // Функция, создающая точку........................................................... 
        private static void SetMyPixel(Graphics g, Color col, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, col)), x, y, 1, 1);
        }
     

        // Алгоритм Брезенхема для окружности
     
          public static void MyCircleBrez(Graphics g, Color clr, double xC, double yC, double radius)
        {
            double x = 0, y = radius, gap = 0, delta = (2 - 2 * radius);
            while (y >= 0)
            {
                SetMyPixel(g, clr, (int)(xC + x), (int)(yC + y), 255);
                SetMyPixel(g, clr, (int)(xC + x), (int)(yC - y), 255);
                SetMyPixel(g, clr,(int)( xC - x), (int)(yC - y), 255);
                SetMyPixel(g, clr, (int)(xC - x), (int)(yC + y), 255);
                gap = 2 * (delta + y) - 1;
                if (delta < 0 && gap <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                if (delta > 0 && gap > 0)
                {
                    y--;
                    delta -= 2 * y + 1;
                    continue;
                }
                x++;
                delta += 2 * (x - y);
                y--;
            }
        }


 
       
        // Обработка события кнопки для рисования простым алгоритмом..................................................
        private void Plain_Click(object sender, EventArgs e)
        {
            if (Line.Checked)
            {
                pictureOne.Refresh();
                double xt, yt, k;
                xt = 100; yt = 100;
                k = 2;
                myLinePlain(xt, yt, k); 
            }
            if (Circle.Checked)
            {
                pictureOne.Refresh();
                double r, x, y;
                string R;
                R = RadCircle.Text;
                r = Convert.ToDouble(R);
                x = pictureOne.Width/2; y = pictureOne.Height / 2;
                myCircle(r, x, y); 
            }
        }


        // Обработка события кнопки для рисования алгоритмом Брезенхема...............................................
        private void Brez_Click(object sender, EventArgs e)
        {
            if (Line.Checked)
            {
                pictureTwo.Refresh();
                string x, y;
                double x1, y1;
                x =  textBox5.Text; y = textBox4.Text;
                x1 = Convert.ToDouble(x); y1 = Convert.ToDouble(y);
                myLineBrez(x1, y1);
            }
            if (Circle.Checked)
            {
                pictureTwo.Refresh();
                string R;
                Graphics g;
                Color clr;
                double x, y, r;
                R = RadCircle.Text;
                g = pictureTwo.CreateGraphics();
                clr = Color.Black;
                r = Convert.ToDouble(R); x = pictureTwo.Width/2; y = pictureTwo.Height / 2;
                MyCircleBrez(g, clr, x, y, r);
                
            }


        }

        private void Circle_CheckedChanged(object sender, EventArgs e)
        {
           
            if (Circle.Checked)
            {
       
                textBox5.Visible = false;
                textBox4.Visible = false;
                label6.Visible = false;
                RadCircle.Visible = true;
                label4.Visible = true;
             
                Plain.Visible = true;
                Brez.Visible = true;
            }

        }

      
            private void Line_CheckedChanged(object sender, EventArgs e)
        {

            if (Line.Checked)
            {
              
                textBox5.Visible = true;
                textBox4.Visible = true;
                label6.Visible = true;
                RadCircle.Visible = false;
                label4.Visible = false;
             
                Plain.Visible = true;
                Brez.Visible = true;

            }

        }
    }
}
