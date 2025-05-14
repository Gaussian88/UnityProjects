using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_04_28_CShrap
{
    internal class MainApp6
    {
        static int MaxNum(int n1, int n2, int n3)
        {
            if (n1 > n2)
                return n1 > n3 ? n1 : n3;
            else
                return n2 > n3 ? n2 : n3;
        }
        static int MinNum(int n1, int n2, int n3)
        {
            if (n1 < n2)
                return n1 < n3 ? n1 : n3;
            else
                return n2 < n3 ? n2 : n3;
        }
        static double CelToFah(double c)
        {
            return 1.8d * c + 32;
        }
        static double FahToCel(double f)
        {
            return (f - 32) / 1.8d;
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            #region 가장  큰 정수와 가장 작은 정수 구하기
            //Console.WriteLine("세개의 정수를 입력");
            //Console.Write("첫번째 정수 : ");
            //int num1 = int.Parse(Console.ReadLine()!);
            //Console.Write("두번째 정수 : ");
            //int num2 = int.Parse(Console.ReadLine()!);
            //Console.Write("세번째 정수 : ");
            //int num3 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine($"입력한 정수는 {num1}, {num2}, {num3}입니다.");
            //Console.WriteLine($"가장 큰 정수는 {MaxNum(num1, num2, num3)}입니다.");
            //Console.WriteLine($"가장 작은 정수는 {MinNum(num1, num2, num3)}입니다.");
            #endregion

            #region 섭씨  화씨  온도 바꾸기 
            //int sel;
            //double num;
            //Console.WriteLine("1.섭씨로 화씨로 2.화씨를 섭씨로 ");
            //Console.Write("선택 : ");
            //sel = int.Parse(Console.ReadLine()!);
            //if (sel == 1)
            //{
            //    Console.Write("섭씨온도 : ");
            //    num = double.Parse(Console.ReadLine()!);
            //    Console.WriteLine($"화씨온도 : {num} => {CelToFah(num)}");
            //}
            //else if (sel == 2)
            //{
            //    Console.Write("화씨온도 : ");
            //    num = double.Parse(Console.ReadLine()!);
            //    Console.WriteLine($"섭씨온도 : {num} => {FahToCel(num)}");
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 선택입니다.");
            //}


            #endregion
            #region 피보나치 수열
         
            //Console.WriteLine("원하는 정수를 입력 하세요");
            //int num4 = int.Parse(Console.ReadLine()!);
            //for (int i = 0; i < num4; i++)
            //{
            //    Console.WriteLine($"피보나치 수열 출력: {Fibonacci(i)}");
            //}

            #endregion
        }
    }
}
