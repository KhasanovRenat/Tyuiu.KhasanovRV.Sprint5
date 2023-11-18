using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhasanovRV.Sprint5.Task2.V7.Lib;

namespace Tyuiu.KhasanovRV.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = $@"C:\Users\Renat\source\repos\Tyuiu.KhasanovRV.Sprint5\Tyuiu.KhasanovRV.Sprint5.Task2.V7\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
