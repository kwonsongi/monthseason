using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            String wether = Console.ReadLine();
            if(wether.Contains("3") ||
                wether.Contains("03")|| 
                wether.Contains("3월")||
                wether.Contains("4") ||
                wether.Contains("04")|| 
                wether.Contains("4월")||
                wether.Contains("5") ||
                wether.Contains("05")||
                wether.Contains("5월"))
            {
                Console.WriteLine("봄");
            }
            else if(wether.Contains("6") ||
                wether.Contains("06") ||
                wether.Contains("6월") ||
                wether.Contains("7") ||
                wether.Contains("07") ||
                wether.Contains("7월") ||
                wether.Contains("8") ||
                wether.Contains("08") ||
                wether.Contains("8월"))
            {
                Console.WriteLine("여름");
            }
            else if (wether.Contains("9") ||
                wether.Contains("09") ||
                wether.Contains("9월") ||
                wether.Contains("10") ||
                wether.Contains("10월") ||
                wether.Contains("11") ||
                wether.Contains("11월"))
            {
                Console.WriteLine("가을");
            }
            else if (wether.Contains("12") ||
                        wether.Contains("12월") ||
                        wether.Contains("1") ||
                        wether.Contains("01") ||
                        wether.Contains("1월") ||
                        wether.Contains("2") ||
                        wether.Contains("02") ||
                        wether.Contains("2월"))
            {
                Console.WriteLine("겨울");
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다.");
            }
        }
    }
}
