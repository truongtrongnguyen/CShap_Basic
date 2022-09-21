using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Su_dung_Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex re = new Regex(@"\d");
            Match result = re.Match("-howkteam.com 10092016-");

            #region MatchCollection - cách 1
            //Bản chất của thằng Match là nó chỉ lấy ra 1 thằng duy nhất trùng nên nó chỉ xuất ra 1, nếu muốn lấy nhiều số thì đưa vào vòng lặp
            Console.WriteLine(result);
            #endregion

            #region - cách 2
            //do
            //{
            //    Console.WriteLine(result.ToString());
            //    result = result.NextMatch();//Lấy ra từng thằng trùng khớp tiếp theo rồi xuất ra màn hình
            //} while (result != Match.Empty);
            #endregion

            #region - cách 3//Lấy ra tất cả các item trùng khớp trong danh sách này
            //MatchCollection matchcollection = re.Matches("-howkteam.com 10092016-");
            //foreach (Match item in matchcollection)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            #endregion


            #region Group && GroupCollection
            Regex reg = new Regex(@"(?<date>((?<day>\d+)/(?<mont>\d+)/(?<year>\d+)))\s(?<time>((?<hours>\d+):(?<minutes>\d+):(?<second>\d+)))\s(?<ID>((?<id1>\d+).(?<id2>\d+).(?<id3>\d+).(?<id4>\d+)))");
            foreach(Match i in reg.Matches("30/04/2017 10:15:20 192.168.1.2"))
            {
                Console.WriteLine("Ngay thang nam: " + i.Groups["date"]);
                Console.WriteLine("Day: " + i.Groups["day"]);
                Console.WriteLine("Mont: " + i.Groups["mont"]);
                Console.WriteLine("Year: " + i.Groups["year"]);
                Console.WriteLine();
                Console.WriteLine("Match: " + i.Groups["time"]);
                Console.WriteLine("Hours: " + i.Groups["hours"]);
                Console.WriteLine("Minutes: " + i.Groups["minutes"]);
                Console.WriteLine("Second: " + i.Groups["second"]);
                Console.WriteLine();

                Console.WriteLine("Match: " + i.Groups["ID"]);
                Console.WriteLine("ID1: " + i.Groups["id1"]);
                Console.WriteLine("ID2: " + i.Groups["id2"]);
                Console.WriteLine("ID3: " + i.Groups["id3"]);
                Console.WriteLine("ID4: " + i.Groups["id4"]);
            }
            Console.WriteLine();
            //Regex t = new Regex(@"(?<id1>\d+).(?<id2>\d+).(?<id3>\d+).(?<id4>\d+)");
            //foreach (Match m in t.Matches("30/04/2017 10:15:20 192.168.1.2"))
            //{
            //    Console.WriteLine("Match: " + m.ToString());
            //    Console.WriteLine("ID1: " + m.Groups["id1"]);
            //    Console.WriteLine("ID2: " + m.Groups["id2"]);
            //    Console.WriteLine("ID3: " + m.Groups["id3"]);
            //    Console.WriteLine("ID4: " + m.Groups["id4"]);
            //}
            #endregion
            #region cách 1: 
            string s = "10:30:15 IBM 192.168.1.2 INTEL";
            Regex RE = new Regex(@"(?<time>(\d|:)+)\s"+@"(?<company>\S+)\s"+@"(?<id>(\d|\.)+\s)"+@"(?<company>\S+)");
            MatchCollection Mat = RE.Matches(s);//Tạp 1 biến MatchCollection để cho gọn hơn
            foreach(Match item in Mat) 
            {
                Console.WriteLine("Time: " + item.Groups["time"]);
                Console.WriteLine("Company: " + item.Groups["company"]);
                Console.WriteLine("ID: " + item.Groups["id"]);
                Console.WriteLine("Company: " + item.Groups["company"]);
            }
            #endregion


            Console.WriteLine("Cach 2 su dung capture\n");
            Regex R = new Regex(@"(?<time>(\d|:)+)\s(?<company>\S+)\s(?<id>(\d|\.)+)\s(?<company>\S+)");
            foreach (Match item in R.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            {
                Console.WriteLine("Time: " + item.Groups["time"]);
                Console.WriteLine($"ID: {item.Groups["id"]}");
                Console.Write($"Company: ");
                //Lấy ra tất cả các capture bắt được trong Groups company và duyệt lần lượt chúng
                //Sau đó có thể sử dụng hàm ToString() hoặc thuộc tính Value để lấy giá trị  của Captrue
                foreach(Capture i in item.Groups["company"].Captures)
                {
                    Console.Write(i.ToString() + " ");
                }
            }
                
            #region cách 2 sử dụng capture

            #endregion
            Console.ReadKey();
        }
    }
}
