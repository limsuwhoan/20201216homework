using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slip4
{
    class Program
    {
        static void Main(string[] args)
        {
            //복습
            //java ; System .out.println 은 출력후 한줄뜀
            // c#은 Console.WriteLine();
            //cw 쓰고 텝텝 
            Console.WriteLine("Hello");

            //java  print 는 출력후 한줄 안띄움
            Console.Write("Line 을 뺌");

            //java  System .out.println(); // 아무것도 안하고 그냥한줄띄움
            //c# 은 Console.WriteLine();
            Console.WriteLine();

            //변수
            //java와 동일 
            int a = 100;
            // 단 String 변수는 String이랑 string 둘다 동일함
            //C#에서는 S를 소문자로 적음
            String A1 = "HE";
            string A2 = "HE";
            string 이런것도됨 = "신기하죠";// 변수가 한글도됨 그러나 웬만해선 사용X
            Console.WriteLine(이런것도됨);

            //문자열 숫자 혼합
            string EX3 = a + "더하기"+a+"은"+(a+a)+"이다";
            string EX4 =$"{a}더하기 { a}은{ a + a}이다.";
            string EX5 = string.Format("[0]더하기{1}은 {2}이다.", a, a, a + a);

            Console.WriteLine(EX3);
            Console.WriteLine(EX4);
            Console.WriteLine(EX5);
            // 조건문
            //java와 동일 함 
            if (a > 50)
            {
                Console.WriteLine("a는 50이상");
                    }

            if(a>30)
            {
                Console.WriteLine("30이상");
            }
            else
            {
                Console.WriteLine("30미만");

            }

            if(a==10)
            {
                Console.WriteLine("10");
            }
            else if (a ==20)
            {
                Console.WriteLine("20");
            }//끝 에 꼭 esle 안붙여도됨
            if (a == 10)
            {
                Console.WriteLine("10");
            }
            else if (a == 20)
            {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine("10 20 은 아님");

            }
            //스위치 문도 자바와 동일
            switch(a)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("10 20 은 아닙니다");
                    break;
                       
            }
            // 반복문도자바와동일
            // 단 foreach라는 특수 문법이 있음
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("같은 말 열번 반복하기");
            }
            int temp = 10;
            while (temp>0)
            {
                temp--;
            }
            do
            {
                temp++;
            } while (temp < 10);

            // 값을 입력 받는 경우 
            //java 
            /*
                Scanner s = new Scanner(system.in);
            string test = s,nextLine();
            int test2 = s.nextInt();

             */
            //c#
            // string test = Console.ReadLine();
            // int test2 = test. parse(Console,ReadLine());
            //Console.ReadLine 은 단축기가 없음 

            string test = Console.ReadLine();
            int test2 = int.Parse(Console.ReadLine());
        }
    }
}
