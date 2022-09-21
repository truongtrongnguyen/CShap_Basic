using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
namespace Type_Attribute_Annotation
{
    internal class Tao_Attribute_Rieng
    {
        public void Demo()
        {
            Userr user = new Userr()
            {
                Name = "Nguyen",
                Age = 10,
                PhoneNumber = "0962958823",
                Email = "sdfsdfdsfs"
            };

            //Lấy tấc cả cá thông tin có trong lớp Userr
            var properties = user.GetType().GetProperties();
            foreach(PropertyInfo propertie in properties)
            {
                foreach (var y in propertie.GetCustomAttributes(false))//lấy ra các Attribute trong thuộc tính propertie
                {
                    MotaAttribute mota = y as MotaAttribute;
                    if(mota!=null)
                    {
                        string name = propertie.Name;
                        var value = propertie.GetValue(user);
                        Console.WriteLine($"({name}) {mota.ThongTinChiTiet} {value}");
                    }    
                }    
            }    
        }
    }


    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Property)]
    class MotaAttribute:Attribute
    {
        public string ThongTinChiTiet { get; set; }
        public MotaAttribute(string _thongtinchitiet)
        {
            ThongTinChiTiet = _thongtinchitiet;
        }
    }
    [Mota("Lop chua thong tin User tren he thong")]
    public class Userr
    {
        [Mota("Ten nguoi dung")]
        public string Name { get; set; }
        [Mota("Du lieu tuoi")]
        public int Age { get; set; }
        [Mota("So dien thoai nguoi dung")]
        public string PhoneNumber { get; set; }
        [Mota("Dia chi Email")]
        public string Email { get; set; }
    }
   

}
