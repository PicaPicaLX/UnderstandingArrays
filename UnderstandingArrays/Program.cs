using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program //如何找到值为16的变量？
    {
        static void Main(string[] args)
        {   /* 这是错误示范
            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1==16)
            {
            }
            else if (number2==16)
            {
            }
            else if (number3==16)
            {
            }
            */

            // 如何依次检查一个数组中的每个元素？
            // 方法1 
            
            int[] numbers = new int[5]; //创建整数数组，数组内有5个元素

            numbers[0] = 4; //从此处开始，依次访问每个元素并赋值
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 42;


            Console.WriteLine(numbers[6]); // 调用索引为1的元素
            Console.WriteLine(numbers.Length); // 显示数组长度（有几个元素）
            Console.ReadLine();
            

            // 方法2 
            /*
            // int[] numbers = new int[] { 4, 8, 15, 16, 23 ,42 }; // 数值类型的数组
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" }; // 字符串类型的数组

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            // 方法3
            /*
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            // 创建不同类型元素的集合
            // 将下面一句话倒叙
            /*
            string zig = "You can get what you want out of life " +
                "if you help enough other people get what they want. "; // 创建以这句话为值的字符串变量"zig"

            char[] charArray = zig.ToCharArray(); // char[]是指单个字符的集合，ToCharArray则将zig里的字符串拆分成单个字符并赋值给变量"charArray"
            Array.Reverse(charArray); // 将charArray集合倒序

            foreach (char zigChar in charArray) // 遍历集合"charArray"，将值交给新的单字符变量"zigChar"
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
            */
        }
    }
}
