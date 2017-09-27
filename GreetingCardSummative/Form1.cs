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
/// <summary>
/// Jon Segeren, sept 20-26, this program demonstrates timing, 
/// sounds and graphics
/// </summary>
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
            SoundPlayer aaaaaaa = new SoundPlayer(Properties.Resources.LOZ_Secret);
            Graphics orionGraphics = this.CreateGraphics();
            SolidBrush starBrush = new SolidBrush(Color.White);
            Pen starPen = new Pen(Color.White, 1);
            Font titleFont = new Font("Arial", 36, FontStyle.Bold);
            SolidBrush wordBrush = new SolidBrush(Color.White);
            Font infoFont = new Font("Times New Roman", 12, FontStyle.Bold);
            SolidBrush infoBrush = new SolidBrush(Color.LimeGreen);
            Font starFont = new Font("Comic Sans", 8);
            SolidBrush starLabelBrush = new SolidBrush(Color.PaleGoldenrod);
            //title page (sept21)
            StartButton.Visible = false;
            Thread.Sleep(133);
            this.Refresh();

            //Star Stuff starting now (sept21), constellation

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush,216, 237, 8, 8);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            orionGraphics.FillEllipse(starBrush, 313, 142, 5, 5);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            orionGraphics.FillEllipse(starBrush, 313, 142, 5, 5);
            orionGraphics.FillEllipse(starBrush, 284, 114, 3, 3);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            orionGraphics.FillEllipse(starBrush, 313, 142, 5, 5);
            orionGraphics.FillEllipse(starBrush, 284, 114, 3, 3);
            orionGraphics.FillEllipse(starBrush, 307, 320, 4, 4);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            orionGraphics.FillEllipse(starBrush, 313, 142, 5, 5);
            orionGraphics.FillEllipse(starBrush, 284, 114, 3, 3);
            orionGraphics.FillEllipse(starBrush, 307, 320, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 455, 6, 6);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            orionGraphics.FillEllipse(starBrush, 313, 142, 5, 5);
            orionGraphics.FillEllipse(starBrush, 284, 114, 3, 3);
            orionGraphics.FillEllipse(starBrush, 307, 320, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 455, 6, 6);
            orionGraphics.FillEllipse(starBrush, 218, 320, 5, 5);
            Thread.Sleep(750);
            orionGraphics.Clear(Color.Black);

            DING.Play();
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            orionGraphics.FillEllipse(starBrush, 313, 142, 5, 5);
            orionGraphics.FillEllipse(starBrush, 284, 114, 3, 3);
            orionGraphics.FillEllipse(starBrush, 307, 320, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 455, 6, 6);
            orionGraphics.FillEllipse(starBrush, 218, 320, 5, 5);
            orionGraphics.FillEllipse(starBrush, 255, 434, 4, 4);
            Thread.Sleep(500);
            orionGraphics.Clear(Color.Black);

            aaaaaaa.Play();
            //star naming
            orionGraphics.DrawString("Betelgeuse", starFont, starLabelBrush, 60, 244);
            orionGraphics.DrawString("Bellatrix",starFont, starLabelBrush, 220, 250);
            orionGraphics.DrawString("Meissa", starFont, starLabelBrush, 182, 170);

            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            orionGraphics.FillEllipse(starBrush, 313, 142, 5, 5);
            orionGraphics.FillEllipse(starBrush, 284, 114, 3, 3);
            orionGraphics.FillEllipse(starBrush, 307, 300, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 455, 6, 6);
            orionGraphics.FillEllipse(starBrush, 218, 320, 5, 5);
            orionGraphics.FillEllipse(starBrush, 255, 434, 4, 4);
            
            //Constellation line things
            orionGraphics.DrawLine(starPen, 93, 94, 124, 94);
            orionGraphics.DrawLine(starPen, 91, 94, 80, 122);
            orionGraphics.DrawLine(starPen, 124, 94, 80, 122);
            orionGraphics.DrawLine(starPen, 80, 122, 117, 244);
            orionGraphics.DrawLine(starPen, 117, 244, 182, 188);
            orionGraphics.DrawLine(starPen, 182, 188, 216, 237);
            orionGraphics.DrawLine(starPen, 117, 244, 163, 349);
            orionGraphics.DrawLine(starPen, 163, 349, 140, 418);
            orionGraphics.DrawLine(starPen, 163, 349, 193, 329);
            orionGraphics.DrawLine(starPen, 193, 329, 218, 320);
            orionGraphics.DrawLine(starPen, 218, 320, 255,434);
            orionGraphics.DrawLine(starPen, 218, 320, 216, 237);
            orionGraphics.DrawLine(starPen, 216, 239, 322, 239);
            orionGraphics.DrawLine(starPen, 322, 239, 335, 288);
            orionGraphics.DrawLine(starPen, 322, 239, 313, 142);
            orionGraphics.DrawLine(starPen, 335, 288, 307, 305);
            orionGraphics.DrawLine(starPen, 313, 142, 284, 114);
            Thread.Sleep(500);
            orionGraphics.Clear(Color.Black);
            
            //Redraw for text
            orionGraphics.DrawString("Betelgeuse", starFont, starLabelBrush, 60, 244);
            orionGraphics.DrawString("Bellatrix", starFont, starLabelBrush, 220, 250);
            orionGraphics.DrawString("Meissa", starFont, starLabelBrush, 182, 170);
            orionGraphics.FillEllipse(starBrush, 91, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 121, 94, 5, 5);
            orionGraphics.FillEllipse(starBrush, 80, 122, 3, 3);
            orionGraphics.FillEllipse(starBrush, 117, 244, 7, 7);
            orionGraphics.FillEllipse(starBrush, 182, 188, 5, 5);
            orionGraphics.FillEllipse(starBrush, 216, 237, 8, 8);
            orionGraphics.FillEllipse(starBrush, 163, 349, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 418, 8, 8);
            orionGraphics.FillEllipse(starBrush, 193, 329, 4, 4);
            orionGraphics.FillEllipse(starBrush, 335, 288, 6, 6);
            orionGraphics.FillEllipse(starBrush, 322, 237, 4, 6);
            orionGraphics.FillEllipse(starBrush, 313, 142, 5, 5);
            orionGraphics.FillEllipse(starBrush, 284, 114, 3, 3);
            orionGraphics.FillEllipse(starBrush, 307, 300, 4, 4);
            orionGraphics.FillEllipse(starBrush, 140, 455, 6, 6);
            orionGraphics.FillEllipse(starBrush, 218, 320, 5, 5);
            orionGraphics.FillEllipse(starBrush, 255, 434, 4, 4);

            orionGraphics.DrawLine(starPen, 93, 95, 126, 95);
            orionGraphics.DrawLine(starPen, 91, 95, 80, 123);
            orionGraphics.DrawLine(starPen, 124, 94, 80, 122);
            orionGraphics.DrawLine(starPen, 80, 122, 117, 244);
            orionGraphics.DrawLine(starPen, 117, 244, 182, 188);
            orionGraphics.DrawLine(starPen, 182, 188, 216, 237);
            orionGraphics.DrawLine(starPen, 117, 244, 163, 349);
            orionGraphics.DrawLine(starPen, 163, 349, 140, 418);
            orionGraphics.DrawLine(starPen, 163, 349, 193, 329);
            orionGraphics.DrawLine(starPen, 193, 329, 218, 320);
            orionGraphics.DrawLine(starPen, 218, 320, 255, 434);
            orionGraphics.DrawLine(starPen, 218, 320, 216, 237);
            orionGraphics.DrawLine(starPen, 216, 239, 322, 239);
            orionGraphics.DrawLine(starPen, 322, 239, 335, 288);
            orionGraphics.DrawLine(starPen, 322, 239, 313, 142);
            orionGraphics.DrawLine(starPen, 335, 288, 307, 305);
            orionGraphics.DrawLine(starPen, 313, 142, 284, 114);
           
            //text
            orionGraphics.DrawString("Orion is a prominent constellation located on the ", infoFont, infoBrush, 30, 30);
            orionGraphics.DrawString("celestial equator and visible throughout the world. ", infoFont, infoBrush, 30, 44);
            orionGraphics.DrawString("It was named after Orion, a hunter in Greek mythology. ", infoFont, infoBrush, 30, 58);
            Thread.Sleep(8000);
            this.Refresh();
            this.Close();
        }
    }
}