# [参考链接](https://blog.csdn.net/e295166319/article/details/58067531)
### 
# [C#程序的主体结构是什么](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/)
### 一些个人的下理解是：c#的程序是以一下的东西（一个项目只能有一个main入口）作为接入口
    class Program
    {
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Speak();
    }
    }
