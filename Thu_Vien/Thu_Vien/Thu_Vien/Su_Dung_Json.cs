using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Linq;
namespace Thu_Vien
{
    internal class Su_Dung_Json
    {
        public void Demo1()
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }
            Console.WriteLine(json);
        }
        public void Demo2()
        {
            string json = @"
            {
                ""Name"":""Dien Thoai Iphone"",
                ""Expiry"": ""2021 - 1 - 30T00: 00:00"",
                ""Sizes"":[""Large"", ""Small""]
            }";
            Product product = JsonConvert.DeserializeObject<Product>(json);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Expiry.ToLongDateString());
       
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public DateTime Expiry { get; set; }
        public string[] Sizes { get; set; }
    }

}
