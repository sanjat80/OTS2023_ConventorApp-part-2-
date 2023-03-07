﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Cas1
{
    public class MassConverter : IConvert
    {
        public double Convert(double value)
        {
             return Math.Round(value / 2.205, 3);
        }
        //First commit comment
        public double ConvertArray(string array)
        {
            string[] values = array.Split(',');

            double number = 0;
            for (int i = 0; i < values.Length; i++)
            {
                number += Double.Parse(values[i]);
            }

            return Convert(number);
        }
    }
}
