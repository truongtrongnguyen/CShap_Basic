using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Dependency_inversion_DI
{
    internal class Su_Dung_Options
    {
        public void Demo()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<Myservice>(); //đăng ký dependency

            //Phương thức đăng ký Option, MyserviceOption là phương thức đăng ký được nằm trong dấu ngoặc <>
            //Tham số của Configure là một delegate
            services.Configure<MyserviceOptions>((MyserviceOptions options)=>   //đăng ký Option
            {
                options.data1 = "Xin chao cac ban";
                options.data2 = "2020";
            });

            //Lúc này trong ServiceCollection có 2 hệ thống: dependency và Option

            var provider = services.BuildServiceProvider();
            var myservice = provider.GetService<Myservice>();
            myservice.Prints();
        }
        
    }
    public class Myservice
    {
        public string data1 { get; set; }
        public string data2 { get; set; }
        public Myservice(IOptions<MyserviceOptions> options)//cần phảo download IOption về máy
        {
            //Khai báo interface Option chứa thông số khởi tạo là MyserviceOPtion 
            // Khai báo như vậy thì nó sẽ giúp quản lí các dependency ở 1 khu vực riêng và quản lí các option ở một khu vực riêng
            var option2 = options.Value;
            data1 = option2.data1;
            data2 = option2.data2;
        }
        public void Prints()
        {
            Console.WriteLine(data1 + " / " + data2);
        }

    }
    public class MyserviceOptions//Không phải là dependency của Myservice
    {
        public string data1 { get; set; }
        public string data2 { get; set; }
    }

}
