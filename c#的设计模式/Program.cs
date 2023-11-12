using System;

namespace HelloWorld
{
    public class  singleTon
    {
        private bool isRunning = false;
        private static singleTon instance;

        /// <summary>
        /// 私有构造函数 外界不可使用new创建实例
        /// </summary>
        private singleTon()
        {
            Console.WriteLine("Hello World!");
        }
        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; }
        }
        public static singleTon getInstance()
        {
            if (instance == null)
            {
                instance = new singleTon();
            }
            return instance;
        }
    }
}
