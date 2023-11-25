using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhasanovRV.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            int cnt = 0;
            foreach (char c in str)
            {
                if (c == '?')
                    cnt++;
            }
            return cnt;
        }
    }
}
