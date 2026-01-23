using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo6
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        int count;
        public Form1()
        {
            InitializeComponent();
            sw.Start();
            count = 0;
        }

        //demo6 and Demo6B
        private void UI_Timer_Tick(object sender, EventArgs e)  
        {
            this.Text = $"Count is: {count} and number of milliseconds Elapsed: {sw.ElapsedMilliseconds}";  
            count++;                           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }
    }
}
