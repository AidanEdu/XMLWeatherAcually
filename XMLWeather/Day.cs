﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow,
            windSpeed, windDirection, precipitation, visibility, sunRise, sunSet, humidity, timeZone, lastUpdate, currentIcon, futureIcon; 

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = sunRise = sunSet = humidity = timeZone = lastUpdate = currentIcon = "";
        }
    }
}