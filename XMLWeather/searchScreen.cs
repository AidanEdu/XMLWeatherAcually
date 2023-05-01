using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class searchScreen : UserControl
    {
        public searchScreen()
        {
            InitializeComponent();
            inputBox.Location = new Point(300 / 2 - inputBox.Width / 2, inputBox.Location.Y);
            searchButton.Location = new Point(inputBox.Width + inputBox.Location.X - searchButton.Width, searchButton.Location.Y);
            invertColors(Form1.def, Form1.opposite);
        }
            

        private void searchButton_Click(object sender, EventArgs e)
        {

            string location = inputBox.Text;
            inputBox.Text = ""; 
            //removes all idexs from days for a requirment used in extract forcast
            for (int i = 0; i < Form1.days.Count; i++)
            {
                Form1.days.RemoveAt(i); 
            }
            //try catch incase user enters the wrong formate
            try
            {
                Form1.ExtractCurrent(location);
                Form1.ExtractForecast(location);
            }
            catch {
                imputlabel.Text = $"Please try again (City, County)"; 
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void invertColors(Color def, Color opposite)
        {
            this.BackColor = opposite; 
            imputlabel.ForeColor = def;
            label1.ForeColor = def;
        }

    }
}
