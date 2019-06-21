using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程
{
    class Program
    {
        static void Main(string[] args)
        {
            //线程分两路 一种是前台线程 一种后台线程 前台线程当应用程序退出时 前台线程也就关闭了 反之 后台线程当应用 程序关闭后其线程仍然在运行
            //Thread.CurrentThread.IsBackground 可设置前后台程序
            Console.WriteLine(Thread.CurrentThread.IsBackground);
            Thread.CurrentThread.IsBackground = false;
            //开启一个线程 并弹出它是否是前后台线程 默认是前台线程
            Thread th=new Thread(delegate(){
                Console.WriteLine("线程开启！");
            }
                );
            Console.WriteLine(th.IsBackground);
            th.Start();//开启线程
            Task taks = new Task(() => Console.WriteLine("线程开启"));
            Console.Read();


            Task t = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("线程开启");
            });
        }
    }
}
