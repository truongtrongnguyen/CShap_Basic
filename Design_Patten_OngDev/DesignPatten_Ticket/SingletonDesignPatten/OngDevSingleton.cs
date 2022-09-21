using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPatten
{
    internal class OngDevSingleton
    {
        private static readonly object loockObject = new object();
        private int index;
        private static volatile OngDevSingleton uniqueSingleton;
        // Sử dụng từ khóa volatile giúp cập nhật những cái uniqueSingleton mới nhất và gần đây nhất nếu như ta khởi tạo một lượng lớn uniqueSingleton
        private OngDevSingleton(int index)
        {
            this.index = index;
        }

        public static OngDevSingleton GetInstance()
        {
            if(uniqueSingleton==null)   //Khi nào nó là null thì lúc đó nó sẽ chạy đa luồng và ta sẽ khóa đúng lúc giúp chương trình chạy nhanh hơn
            {
                lock (loockObject)  //hoặc là dùng Console.Out để khóa lại
                {
                    if (uniqueSingleton == null)
                    {
                        var random = new Random();
                        uniqueSingleton = new OngDevSingleton(random.Next(1, 4));
                    }
                }
            }
            return uniqueSingleton;
        }
        public void SaysHi()
        {
            Console.WriteLine("Hello everyone, I am ongDev numbers: "+index);
            Console.WriteLine(uniqueSingleton.GetHashCode());
        }
    }
}
