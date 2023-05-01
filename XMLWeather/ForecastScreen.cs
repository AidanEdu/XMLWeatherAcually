using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        //lists for formating
        List<Label> dayLabels = new List<Label>();    
        List<Label> highLables = new List<Label>();
        List<Label> lowLables = new List<Label>(); 
        public ForecastScreen()
        {
            InitializeComponent();
            //adds the labels to respective lists and formats them
            formating(dayLabels, highLables, lowLables);
            //same function of other invertcolor methods
            invertColors(Form1.def, Form1.opposite);
            displayForecast();
        }

        public void displayForecast()
        {
            //kind of a mix of a for loop and for each loop used to dispaly the name of the day
            int index = 0; 
            foreach(Label l in dayLabels)
            {
                l.AutoSize = true;
                l.Text = $"{DateTime.Now.AddDays(index).ToString("dddd")}";
                index++; 
            }

            //displays the dayly highs
            index = 0;
            foreach (Label l in highLables)
            {
                l.AutoSize = true;
                l.Text += $" {Convert.ToDouble(Form1.days[index].tempHigh).ToString("#")}°";
                index++;
            }

            //displays the lows
            index = 0;
            foreach (Label l in lowLables)
            {
                l.AutoSize = true;
                l.Text += $" {Convert.ToDouble(Form1.days[index].tempLow).ToString("#")}°";
                index++;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //backs out to current screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        public void invertColors(Color def, Color opposite)
        {
            //same deal as before
            currentLabel.ForeColor = def;
            foreach (Label l in dayLabels)
            {
                l.ForeColor = def; 
            }

            this.BackColor = opposite;
        }

        public void formating(List<Label> labels, List<Label> highLabels, List<Label> lowLabels)
        {
            //addes lables to lists and evenly and appropiatly spaces them out
            labels.Add(day0Label);
            labels.Add(day1Label);
            labels.Add(day2Label);  
            labels.Add(day3Label);
            labels.Add(day4Label);
            labels.Add(day5Label);
            labels.Add(day6Label);
            
            int distance = 50;
            foreach (Label l in labels)
            {
                //just evens out distance
                if (l.Location.Y != day0Label.Location.Y)
                {
                    l.Location = new Point(day0Label.Location.X, day0Label.Location.Y + distance);
                    distance += 50;
                }

            }

            highLabels.Add(high0Label);
            highLabels.Add(high1Label);
            highLabels.Add(high2Label);
            highLabels.Add(high3Label);
            highLabels.Add(high4Label);
            highLabels.Add(high5Label); 
            highLabels.Add(high6Label); 

            distance = 50;
            foreach (Label l in highLables)
            {
                //just evens out distance
                if (l.Location.Y != high0Label.Location.Y)
                {
                    l.Location = new Point(high0Label.Location.X, high0Label.Location.Y + distance);
                    distance += 50;
                }

            }

            lowLabels.Add(low0Labels); 
            lowLabels.Add(low1Labels);
            lowLabels.Add(low2Labels);
            lowLabels.Add(low3Labels);
            lowLabels.Add(low4Labels);
            lowLabels.Add(low5Labels);
            lowLabels.Add(low6Labels);

            distance = 50; 
            foreach (Label l in lowLabels)
            {
                //just evens out distance
                if (l.Location.Y != low0Labels.Location.Y)
                {
                    l.Location = new Point(low0Labels.Location.X, low0Labels.Location.Y + distance);
                    distance += 50;
                }
            }

        }
    }
}
