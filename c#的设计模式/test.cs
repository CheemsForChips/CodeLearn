using HelloWorld;
using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //singleTon s1 = new singleTon();构造函数是private不可使用new 达到单例模式的效果
            Console.WriteLine("Mian Start");
            // singleTon s1 = singleTon.getInstance();//获取单例模式的实例
            // s1.IsRunning = true;
        }
    }

}
