using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Su_dung_try_catch
{
    public class NameEmptyException : Exception
    {
        //Gọi phương thức khởi tạo của lớp cơ sở và gán thông báo của mình đặt ra
        public NameEmptyException():base("Ten phai khac rong")
        {
            
        }
    }
    public class NameNullException:Exception
    {
        public NameNullException() : base("Ten phai khac null")
        {

        }
    }
    public class AgeException : Exception
    {
        private int age { set; get; }//cho 1 thuộc tính để lưu tuổi lại
        public AgeException(int _age) : base("Tuoi khong phu hop")
        {
            age = _age;
        }
        public void Detail()
        {
            Console.WriteLine($"Tuoi = {age} khong nam trong 18 - 100");
        }
    }
}
