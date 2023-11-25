using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;

namespace Tyuiu.KhasanovRV.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            
            string putj = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(putj);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(putj);
            }
            string str = File.ReadAllText(path);
            string result = Regex.Replace(str, @"\b[ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ][а-я]+", "");
            File.AppendAllText(putj, result + Environment.NewLine);
            return putj;
        }
    }
}
