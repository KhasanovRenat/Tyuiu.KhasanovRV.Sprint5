using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhasanovRV.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace(".", ",");
            
            double x = Convert.ToDouble(strX);

            double y = x/(2*x) + Math.Sin(Math.Pow(x, 2));

            return Math.Round(y, 3, MidpointRounding.AwayFromZero);
        }
    }
}
