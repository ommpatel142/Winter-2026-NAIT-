using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UI_5_Rdb.CheckedChanged += UI_Recalculate_Event;
            UI_7_Rdb.CheckedChanged += UI_Recalculate_Event;
            UI_10_Rdb.CheckedChanged += UI_Recalculate_Event;

        }
        private void UI_Recalculate_Event(object sender,EventArgs e)
        {
            double amt;

            if(!double.TryParse(UI_ItemPrice_Tbx.Text,out amt))
            {
                UI_Output_Tbx.Text = "";
                return;
            }

            double tax = 0.0;

            if (UI_5_Rdb.Checked)
                tax = 0.05;
            if (UI_7_Rdb.Checked)
                tax = 0.07;
            if (UI_10_Rdb.Checked)
                tax = 0.10;

            double total = amt + (amt * tax);
            UI_Output_Tbx.Text = total.ToString("0.00");
        }
    }
}
