using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Say("english");
            //ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
            //// 默认简单配置，输出至控制台
            ////BasicConfigurator.Configure(repository);
            //XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
            //ILog log = LogManager.GetLogger(repository.Name, "NETCorelog4net");

            //log.Info("NETCorelog4net log");
            //log.Info("test log");
            //log.Error("error");
            //log.Info("linezero");
            //ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
            //XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
            //ILog log = LogManager.GetLogger(repository.Name, "NETCorelog4net");

            //log.Info("NETCorelog4net log");
            //log.Info("test log");
            //log.Error("error");
            //log.Info("linezero");
            //string[] names = { "A", "B", "c" };
            //Console.WriteLine(string.Join(',', names));

            int i = 6;
            string s = "输出";
            Console.WriteLine("{0}还可以这样{1}哦。", i, s);
            Console.WriteLine("{1}：而且{0}参数的顺序和使用次数都不固定哦。{1}", i, s);
            string.Join(',', new[] { 1, 2, 3 });
            string @abc = "hhh";
            string aaa = @"C:\Users\Administrator\Desktop";
            int? a = null;
            Nullable<int> b = 10;
            b = a;
            string d = "d";
            string c = d??"c";
            Console.WriteLine(c) ;
            int[] bb = new int[3];
        }
        static void Say(string context)
        {
            Console.WriteLine(context);
            Console.WriteLine("jjiji");
        }
        static void Say2(string context) => Console.WriteLine(context);
    }
}
