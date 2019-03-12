using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = "";
            do
            {
                cmd = Console.ReadLine();
                Console.WriteLine(cmd);
            } while (cmd != "exit");
            
            //　コンソールが自動で閉じないための処理
            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }
    }
}
