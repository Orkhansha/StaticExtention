﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassworkStaticExtention.Models.Helpers
{
    public static class Extention
    {
        public static bool CheckString(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }
        public static int SumNumbers(this int num1,int num2)
        {
            return num1 + num2;
        }
        
    }

}
