using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newslip1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제 풀이 시작");
            Console.WriteLine("1번 문제 ");
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    sum = sum + i;
                //sum +=i; 같음
            }
            Console.WriteLine("1부터 100까지의 수중 3의 배수의 합은" + $"{sum})이다.");
            Console.WriteLine("총 합은 :" + $"[{sum}]" + "이다.");

            Console.WriteLine("2번 문제");
            int inputSecond = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inputSecond / 60}분 {inputSecond % 60}초");

            Console.WriteLine("3번 문제 ");
            Console.WriteLine("몇층까지 쌓을 것인가 ?");
            int floor = int.Parse(Console.ReadLine());
            for (int i = 0; i < floor; i++)//바깥의 줄 for (int i = 0; i < floor; i++)
            {
                //공백 찍는 부분  for (int j = floor; i < j; j--)
                for (int j = floor; i < j; j--)
                {
                    Console.Write(" ");
                }
                //별을 찍는 부분 for (int a= 0; a < (2*i)+1; a++) 전체돌고 i값이 증가하면 (2+i)+1의 공식을 대입시킴
                for (int a = 0; a < (2 * i) + 1; a++)
                {
                    Console.Write("*");//별 값 

                }
                Console.WriteLine();        //줄을 띄어줌       
            }
            Console.WriteLine("4번 문제 ");
            for (int i = 2; i < 10; i++)//2단 부터 9단 까지
            {
                for (int a = 1; a < 10; a++)//*1 부터*9까지
                {
                    Console.WriteLine($"{i}x{a}={i * a}");
                }
            }
            
                Console.WriteLine("5번 문제 ");
                int month = int.Parse(Console.ReadLine());
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("겨울");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("봄");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("여름");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("가을");
                        break;
                    default:
                        Console.WriteLine("잘못된 값입니다.");
                        break;
                }
            Console.WriteLine("6번문제");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            if(input1>0 && input2>0)
                Console.WriteLine("1");
           else if (input1 > 0 && input2 < 0)
                Console.WriteLine("2");
            else if (input1 <0 && input2 < 0)
                Console.WriteLine("3");
            else if (input1 > 0 && input2 < 0)
                Console.WriteLine("4");
            else// 둘다 0인경우
                Console.WriteLine("0");

            Console.WriteLine("7번문제");
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0;//각 자리 숫자의 개수
                string end = ""; //문자열 누적 시키는 변수
                Console.WriteLine($"{i + 1}번쨰:{start}");//말하기
                char number = start[0];//내가 가리키는 숫자]

                for (int j = 0; j < start.Length; j++)//수열 읽어 들이기
                {
                    if (number != start[j])
                    {
                        end = end + number + count;//end =""+'1'+1
                        number = start[j];//가리키는 숫자들 다른걸로바꿈
                        count = 1;//count 는1로 초기화
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;
            }
            Console.WriteLine("8번문제");
            int input = int.Parse(Console.ReadLine());
            int max = 1; //각 벌집의 최대값
            int counter = 0; //임의의 카운트 변수 값
            while(true)
            {
                max = max + (6 * counter);
                if(max<input)
                {
                    counter++;
                    continue;
                }
                else
                    Console.WriteLine($"{input}은/는 {counter+1}번쨰 벌집에 속함");
                break;
            }
            //8번문제
            Console.WriteLine("선생님문제");
            int input_dj = int.Parse(Console.ReadLine());
            //패턴정리
            //1      -1번 벌집-1
            //2~7        2 "-6
            //8~19        3 "-12
            //20~37        4 "-18
            //36~61         5 "-24
            if(input_dj==1)
                Console.WriteLine("1번벌집");
            else if (input_dj<=7)
                Console.WriteLine("2번 벌집");
            else
            {
                int tempCount = 1;//임의의 카운트변수
                int sub = 6;
                while(input_dj>0)
                {
                    input_dj = input_dj - sub;
                    sub = sub + 6;
                    tempCount++;
                    if (input_dj<= 1)
                        break;
                }
                Console.WriteLine(tempCount);
            }
        }



    }
}
