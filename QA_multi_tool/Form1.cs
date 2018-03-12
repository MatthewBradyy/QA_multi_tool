using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_multi_tool
{
    public partial class Form1 : Form
    {
        char[] alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
        bool timerOn = false, drag = false;
        int Min, sec, mil, LocX,LocY;
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            timer1.Enabled = true;
            timerOn = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            timer1.Enabled = false;
            timerOn = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timerOn = false;
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            Min = 0;
            sec = 0;
            mil = 0;
            Showtime();
        }

        private void btm_CreateString_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string letter = "";
            int count = Convert.ToInt32(tbx_count.Text);
            for (int i = 1; i <= count; i++)
            {                              
                int rnd = random.Next(0, 25); 
                letter = letter.Insert(i - 1, alphabet[rnd].ToString());
            }
            tbx_string.Text = letter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerOn == true)
            {
                increase_Mil();
                Showtime();
            }
        }

        private void btn_clearString_Click(object sender, EventArgs e)
        {
            tbx_string.Clear();
        }

        private void tbx_string_TextChanged(object sender, EventArgs e)
        {
            if(tbx_string.TextLength == 0)
                tbx_count.Text = "";
            else
                tbx_count.Text = tbx_string.TextLength.ToString();
        }
        private void increase_Mil()
        {
            if (mil == 59)
            {
                increase_Sec();
                mil = 0;
            }
            else
            {
                mil++;
            }
        }
        private void increase_Sec()
        {
            if (sec == 59)
            {
                increase_Min();
                sec = 0;
            }
            else
            {
                sec++;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            LocX = e.X;
            LocY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag == true)
            {             
                this.SetDesktopLocation(MousePosition.X - LocX,MousePosition.Y - LocY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void increase_Min()
        {
            if (Min == 59)
            {
                timer1.Enabled = false;
                timerOn = false;
            }
            else
            {
                Min++;
            }
        }
        private void Showtime()
        {
            lbl_mil.Text = mil.ToString("00");
            lbl_sec.Text = sec.ToString("00");
            lbl_Min.Text = Min.ToString("00");
        }
    }
}
