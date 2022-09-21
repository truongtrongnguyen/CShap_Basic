using System;
using System.Collections.Generic;
using System.Linq;  //Thư viện mở rộng nhiều chức năng cho mảng
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
public class Time
{ // hàm hành sự public 
    public void DisplayCurrentTime()
    {
        Console.WriteLine("{ 0}/{ 1}/{ 2} { 3}:{ 4}:{ 5}", Month, Date, Year, Hour, Minute, Second);
    }
    // hàm constructor thứ nhất 
    public Time(System.DateTime dt) 
    {
        Year = dt.Year;
        Month = dt.Month;
        Date = dt.Day;
        Hour = dt.Hour;
        Minute = dt.Minute;
        Second = dt.Second;
    }
    // hàm constructor thứ hai 
    public Time(int Year, int Month, int Date,
    int Hour, int Minute, int Second)
    {
        this.Year = Year;
        this.Month = Month;
        this.Date = Date;
        this.Hour = Hour;
        this.Minute = Minute;
        this.Second = Second;
    }
    // các biến thành viên private 
    private int Year;
    private int Month;
    private int Date;
    private int Hour;
    private int Minute;
    private int Second;
} 
 public class Tester
{
    static void Main()
    {
        System.DateTime currentTime = System.DateTime.Now;
        Time t1 = new Time(currentTime);
        t1.DisplayCurrentTime();
        Time t2 = new Time(2000, 11, 18, 11, 02, 30);
        t2.DisplayCurrentTime();
        Console.ReadKey();
    } // end Main 
} // end Tester