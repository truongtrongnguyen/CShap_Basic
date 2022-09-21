using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Linq;

namespace Type_Attribute_Annotation
{
    internal class Co_Ban
    {
       public void Demo()
        {
            // Lớp type là lớp chứa thông tin về một kiểu dữ liệu nào đó Vd chứa thông tin về các lớp , enum, in ...
            // Lớp Type là thành phần cơ bản trong dotnet, được dùng cho kĩ thuật Reflection: Lấy thông tin , dữ liệu ở thời điểm thực thi
            int[] a = { 1, 2, 34, 4 };
            Type t1 = typeof(int);
            var t2 = a.GetType();//Lấ ra kiểu sữ liệu của biến a
            Console.WriteLine(t2.FullName);

            t2.GetProperties().ToList().ForEach((PropertyInfo property) =>
            {
                Console.WriteLine(property.Name);
            });
            Console.WriteLine("CAC PHUONG THUC:");
            t2.GetMethods().ToList().ForEach((MethodInfo method) =>
            {
                Console.WriteLine(method.Name);
            });
        }
        
    }
}
