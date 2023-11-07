﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PomazDS.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int mult = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1) mult *= array[i];
            }
            return mult;
        }
    }
}
