using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static string location = "Stratford, CA";
        public static Color def;
        public static Color opposite; 

        public static WebClient client = new WebClient();

        //create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast(location);
            ExtractCurrent(location);
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);

            //inverts the color of the screen if night the current time is past sunset
            if (DateTime.Now.Hour <= 12)
            {
                if (DateTime.Now.Hour < Convert.ToDouble(Form1.days[0].sunRise.Substring(11, 2)) + Convert.ToDouble(Form1.days[0].timeZone) / 3600)
                {
                    def = Color.White;
                    opposite = Color.Black;
                }
                else
                {
                    def = Color.Black;
                    opposite = Color.White;
                }
            }
            else if (DateTime.Now.Hour > 12)
            {
                
                if (DateTime.Now.Hour - 12 < 12 - Convert.ToDouble(days[0].sunSet.Substring(11, 2)) + Convert.ToDouble(days[0].timeZone) / 3600)
                {
                    def = Color.Black;
                    opposite = Color.White; 
                }
                else
                {
                    def = Color.White;
                    opposite = Color.Black;
                }
            }
        }

        public static void ExtractForecast(string location)
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={location}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            
            while (reader.Read() && days.Count < 7)
            {
                //create a day object
                Day d = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");

                d.tempHigh = reader.GetAttribute("max");


                

                days.Add(d);
                //TODO: if day object not null add to the days list
            }
            reader.Close();
        }

        public static void ExtractCurrent(string location)
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={location}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("timezone");
            days[0].timeZone = reader.ReadString();


            reader.ReadToFollowing("sun");
            days[0].sunRise = reader.GetAttribute("rise");
            days[0].sunSet = reader.GetAttribute("set");
            
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].currentConditions = reader.GetAttribute("value");
            days[0].currentIcon = reader.GetAttribute("icon");

            reader.ReadToFollowing("lastupdate");
            days[0].lastUpdate = reader.GetAttribute("value");

            reader.Close(); 
        }

        

    }
}
