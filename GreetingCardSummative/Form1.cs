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

            //Star Stuff starting now (sept21)




        }

       
    }
}
