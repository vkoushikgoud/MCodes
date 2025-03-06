using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Tues
{
    class Program : ApplicationException
    {
        static void Main(string[] args)
        {
            
            //StreamReader sr = new StreamReader("C:\\Users\\Administrator\\Desktop\\dotNet\\Tues\\Tues\\console1.txt");
            //while (true)
            //{
            //    string strLine = sr.ReadLine();
            //    if (strLine == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(strLine);
            //}
            //sr.Close();

            //StreamWriter sw = new StreamWriter("C:\\Users\\Administrator\\Desktop\\dotNet\\Tues\\Tues\\console1.txt");
            //sw.WriteLineAsync("Hello World");
            //sw.WriteLine("Vinay");
            //sw.Close();
            //StreamReader sr1 = new StreamReader("C:\\Users\\Administrator\\Desktop\\dotNet\\Tues\\Tues\\console1.txt");
            //while (true)
            //{
            //    string strLine = sr1.ReadLine();
            //    if (strLine == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(strLine);
            //}
            //sr1.Close();

            string strTest= Console.ReadLine();
           byte[] arrBytes = System.Text.Encoding.UTF8.GetBytes(strTest);
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\dotNet\\Tues\\Tues\\console1.txt", FileMode.Append, FileAccess.Write);
            fs.Write(arrBytes, 0, arrBytes.Length);
            fs.Close();

            


        }
    }
}
