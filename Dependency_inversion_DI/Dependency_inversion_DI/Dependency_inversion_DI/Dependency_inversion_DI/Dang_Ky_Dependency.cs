using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_inversion_DI
{

    internal class Dang_Ky_Dependency
    {
        public void Demo()
        {
            var services = new ServiceCollection();//tạo một đối tượng cho phép đăng ký dịch vụ

            services.AddSingleton<IClassC, ClassC>();   //Tiến hành đăng ký dịch vụ
            //services.AddTransient<IClassC, ClassC>();//tạo ra 5 đối tượng dịch vụ khác nhau

            //Đăng ký thông qua tên IClassC và đối tượng được triển khai là ClassC và do sử dụng Singleton nên nó sẽ chỉ được tạo chỉ một lần

            var provider = services.BuildServiceProvider();

            //var classc = provider.GetService<IClassC>();//Lớp lấy ra dịch vụ thông qua tên IClassC

            for (int i = 0; i < 5; i++)
            {
                IClassC c = provider.GetService<IClassC>();
                Console.WriteLine(c.GetHashCode());//xuất ra 5 đối tượng giống nhau
            }

            //Sử dụng Scope
            Console.WriteLine("Su dung Scope");
            using(var scope=provider.CreateScope())
            {
                var provider1 = scope.ServiceProvider;
                for(int i=0;i<5;i++)
                {
                    IClassC cc = provider1.GetService<IClassC>();
                    Console.WriteLine(cc.GetHashCode());
                }    
            }    
        }
    }
}
