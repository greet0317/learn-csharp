//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("你好，C#");
//        Console.Write("请输入你的名字：");
//        var name = Console.ReadLine();
//        Console.WriteLine($"你好，{name}，今天是你学 C# 的第 1 天");
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("你好，C#");
//        Console.Write("请输入你的名字:");
//        var name =Console.ReadLine();

//        SayHello(name);
//    }

//    static void SayHello(string who)
//    {
//        Console.WriteLine($"你好，{who},今天是你学C#的第3天");
//    }
//}

//int age = 25;
//double pi = 3.14159;
//decimal money = 19.99m;
//bool isReady = true;
//char grade = 'A';
//string name = "小明";

//Console.WriteLine(5 / 2);
//Console.WriteLine(5 / 2.0);
//Console.WriteLine(5 % 2);
//Console.WriteLine(7 % 3);

//string s = "42";
//int n = int.Parse(s);
//Console.WriteLine(n + 1);

//string s2 = "abc";
//int m  = int.Parse(s2);

//Console.Write("第一个数：");
//var s1 = Console.ReadLine();
//Console.Write("第二个数：");
//var s2 = Console.ReadLine();

//int a = int.Parse(s1);
//int b = int.Parse(s2);

//Console.WriteLine($"{a} + {b} = {a + b}");
//Console.WriteLine($"{a} - {b} = {a - b}");
//Console.WriteLine($"{a} * {b} = {a * b}");
//Console.WriteLine($"{a} / {b} = {a / b}");
//Console.WriteLine($"{a} / {b} = {(double)a / b}");

//Console.Write("请输入你的出生年份：");
//var s = Console.ReadLine();
//int year = int.Parse(s);
//int age = DateTime.Now.Year  - year;
//Console.WriteLine($"你今年{age}岁");

//Console.Write("身高（米，例如 1.75）：");
//double height = double.Parse(Console.ReadLine());

//Console.Write("体重（公斤，例如 68）：");
//double weight = double.Parse(Console.ReadLine());

//Console.WriteLine($"身高{height}，体重{weight}");

//double bmi = weight / (height * height);
//Console.WriteLine($"你的BWI是{bmi:F2}");

//if (bmi < 18.5)
//{
//    Console.WriteLine("偏瘦");
//}
//else if (bmi < 24)
//{
//    Console.WriteLine("正常");
//}
//else if (bmi < 28)
//{
//    Console.WriteLine("超重");
//}
//else
//{
//    Console.WriteLine("肥胖");
//}


while (true)
{
    Console.WriteLine();
    Console.WriteLine("====== 小工具箱 ======");
    Console.WriteLine("  1. BMI 计算");
    Console.WriteLine("  2. 温度换算");
    Console.WriteLine("  0. 退出");
    Console.Write("请选择：");

    var cmd = Console.ReadLine();

    switch (cmd)
    {
        case "1":
            Console.Write("身高（米，例如 1.75）：");
            double height = double.Parse(Console.ReadLine() ?? "");

            Console.Write("体重（公斤，例如 68）：");
            double weight = double.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"身高{height}，体重{weight}");

            double bmi = weight / (height * height);
            Console.WriteLine($"你的BWI是{bmi:F2}");

            if (bmi < 18.5)
            {
                Console.WriteLine("偏瘦");
            }
            else if (bmi < 24)
            {
                Console.WriteLine("正常");
            }
            else if (bmi < 28)
            {
                Console.WriteLine("超重");
            }
            else
            {
                Console.WriteLine("肥胖");
            }
            break;

            case "2":
             Console.Write("方向（1=摄氏→华氏，2=华氏→摄氏）：");
             var dir = Console.ReadLine();

             if (dir == "1")
             {
             Console.Write("摄氏度：");
             double c = double.Parse(Console.ReadLine() ?? "");
             Console.WriteLine($"{c:F1}°C = {c * 9 / 5 + 32:F1}°F");
             }
             else
             {
             Console.Write("华氏度：");
             double f = double.Parse(Console.ReadLine() ?? "");
             Console.WriteLine($"{f:F1}°F = {(f - 32) * 5 / 9:F1}°C");
             }
             break;

        case "0":
            return;

        default:
            Console.WriteLine("不存在，重新选择。");
            break;
    }
}