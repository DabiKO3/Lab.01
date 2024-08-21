﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._01
{
    internal class Processor
    {
            public string Name;
            public string Manufacturer;
            public int Cores;
            public double Frequency; 
            public double TDP; 
            public long Transistors; 
            public bool Multithreading;
            public double PerformancePerCore; 

            public double CalculateTotalPerformance()
            {
                return Cores * PerformancePerCore; 
            }
    }
}