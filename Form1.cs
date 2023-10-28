using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour, minute, second;
        string alarmHour, alarmMinute;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = comboBox2.Text;
            alarmMinute = comboBox1.Text;
            MessageBox.Show("Alarm Set Succcesfully");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;
            label2.Text = hour.ToString();
            label3.Text = minute.ToString();
            label4.Text = second.ToString();
            
            Ring_Alarm();


        }

        void Ring_Alarm()
        {
            if (alarmHour == hour.ToString() && alarmMinute == minute.ToString() && second.ToString() == "0")
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Rishith Kumar\\Downloads\\alarm.mp3";

            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
           

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for(int i = 0; i < 24; i++)
            {
                comboBox2.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                comboBox1.Items.Add(j);
            }

        }
    }
}
