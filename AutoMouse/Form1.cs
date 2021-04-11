using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            MoveCursor();
            //InitTimer();

        }
        private void MoveCursor()
        {
            

            Cursor MyCursor = new Cursor(Cursor.Current.Handle);

            //very basic way of moving mouse up every up left
            int random_numberX;
            int random_numberY;

            Random randmX = new Random();
            random_numberX = randmX.Next(-10, 10);

            Random randmY = new Random();
            random_numberY = randmY.Next(-10, 10);

            Cursor.Position = new Point (Cursor.Position.X + random_numberX, Cursor.Position.Y + random_numberY);
           

            //==========================Circular movement=================================
            //double radius = 100.0d; //radius of the circle in pixels

            //int startX = Cursor.Position.X - (int)radius;
            //int startY = Cursor.Position.Y;
            

            
            ////360° iteration
            //for (double i = 0.0d; i < Math.PI * 2.0d; i += 0.1d)
            //{
            //    int x = startX + (int)(radius * Math.Cos(i));
            //    int y = startY + (int)(radius * Math.Sin(i));

            //    //set new mouse Position
            //    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y);
            //    //BFS.Input.SetMousePosition(x, y); this is original code coming from displayfusion.com; BFS package/library

            //    //sleep for a bit
            //    //BFS.General.Sleep(10);
            //}


            //this makes the mouse move only in rectangle defined by form borders
            //Cursor.Clip = new Rectangle(this.Location, this.Size); 
        }


        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000; //30 seconds 30000 in millseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveCursor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTimer();
        }
    }
}
