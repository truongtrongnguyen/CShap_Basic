using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Dependency_inversion_DI
{
    internal class Su_dung_File_cho_DI
    {
        public void Demo()
        {
            IConfigurationRoot configurationRoot;
            //ConfigurationRoot configurationRoot;

            ConfigurationBuilder confibuilder = new ConfigurationBuilder();

            confibuilder.SetBasePath(Directory.GetCurrentDirectory());//Lấy đường dẫn file thư mục đang chạy

            //Thêm file cauhinh.json vào thư mục hiện tại đang chạy
            confibuilder.AddJsonFile(@"D:\Code C#\Dependency_inversion_DI\Dependency_inversion_DI\Dependency_inversion_DI\Dependency_inversion_DI\cauhinh.json");

            configurationRoot = confibuilder.Build();
            //configurationRoot = (ConfigurationRoot) confibuilder.Build();

            //var key = configurationRoot.GetSection("MyserviceOptions").GetSection("data2").Value;
            //Console.WriteLine(key);

            //tên biến trong Myservice và tên biến trong MyserviceIOption và tên biến trong file json phải giống nhau data1, data2
            var sectionMyserviceOptions = configurationRoot.GetSection("section");
            var service = new ServiceCollection();
            service.AddSingleton<Myservice>();

            
            service.Configure<MyserviceOptions>(sectionMyserviceOptions);

            var provider = service.BuildServiceProvider();
            var myservice = provider.GetService<Myservice>();
            myservice.Prints();

        }
    }
}
