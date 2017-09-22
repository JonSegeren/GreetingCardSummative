using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GreetingCardSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //All the 'fun' beginning stuff (sept 20)
            SoundPlayer DING = new SoundPlayer(Properties.Resources.Elevator_Ding_SoundBible_com_685385892);
            Graphics orionGraphics = this.CreateGraphics();
            SolidBrush starBrush = new SolidBrush(Color.White);
            Pen starPen = new Pen(Color.PaleGoldenrod, 3);
            Font titleFont = new Font("Arial", 36, FontStyle.Bold);
            SolidBrush wordBrush = new SolidBrush(Color.White);

            //title page (sept21)
            StartButton.Visible = false;
            Thread.Sleep(133);
            this.Refresh();

            //Star Stuff starting now (sept21), constellation

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            Thread.Sleep(1333);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            Thread.Sleep(1333);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            Thread.Sleep(600);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            Thread.Sleep(300);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            Thread.Sleep(300);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush,216, 237, 8, 8);
            Thread.Sleep(300);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            Thread.Sleep(300);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 185, 388, 8, 8);
            Thread.Sleep(300);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 185, 388, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            Thread.Sleep(300);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 185, 388, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            Thread.Sleep(300);
            orionGraphics.Clear(Color.Black);







        }


    }
}
