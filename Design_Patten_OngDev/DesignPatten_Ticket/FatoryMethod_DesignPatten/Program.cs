using FatoryMethod_DesignPatten.AbstractFactory;
using FatoryMethod_DesignPatten.Animals;
using FatoryMethod_DesignPatten.Factory;
using System;

namespace FatoryMethod_DesignPatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Link Diagram: https://app.diagrams.net/#G1oXYEN9QqaBrKdfcUYBFcC9dvQ1s1vh86
            // Linl Web FactoryMethod: https://gpcoder.com/4352-huong-dan-java-design-pattern-factory-method/
            //Link Web AbstractFactory :  https://viblo.asia/p/abstract-factory-design-pattern-tro-thu-dac-luc-cua-developers-maGK7B4M5j2
            // Khi chúng ta không biết phải tạo một đối tượng như thế nào thì chúng ta sẽ tạo ngẫu nhiên dựa trên FactoryDesignPatten

            //Bản chất của abstract FatoryMethod nó cũng tương tự như FatoryMethod dùng để tạo ra một đối tượng nào đó
            /*
             * FatoryMethod tạo những class có chung nguồn gốc
             *     + VD như BaseAnimalFactory và RandomAnimalFactory -> Nó đều tạo ra Animal   
             * AbstractFactoryMethod tạo ra những class theo từng cụm có đặc điểm chung
             *      + VD: tạo ra những loài animal cụ thể hơn như có 2 chân hoặc 4 chân 
             *  
             *  Nhiệm vụ của Factory Pattern là quản lý và trả về các đối tượng theo yêu cầu, giúp cho việc khởi tạo đổi tượng một cách linh hoạt hơn. 
             *  Factory Pattern đúng nghĩa là một nhà máy, và nhà máy này sẽ “sản xuất” các đối tượng theo yêu cầu của chúng ta.
             */

            ////Code FactoryMethod
            IAnimalFactory factory;
            IAnimalFactory baseanimalfactory = new BaseAnimalFactory();
            Console.WriteLine(baseanimalfactory.CreateAnimal().Getname());
            Console.WriteLine(baseanimalfactory.CreateAnimal().Getname());
            Console.WriteLine(baseanimalfactory.CreateAnimal().Getname());
            Console.WriteLine(baseanimalfactory.CreateAnimal().Getname());
            Console.WriteLine();

            //Code AbstractFactoryMethod
            Random random = new Random();
            int type = random.Next(0, 2);
            if(type==0)
            {
                factory = new FourLegsAnimalFactory();
            }
            else
            {
                factory = new TwoLegsAnimalFactory();
            }
            
            Console.WriteLine(factory.CreateAnimal().Getname());
            Console.WriteLine(factory.CreateAnimal().Getname());
            Console.WriteLine(factory.CreateAnimal().Getname());
            Console.WriteLine(factory.CreateAnimal().Getname());
            Console.WriteLine(factory.CreateAnimal().Getname());

            Console.ReadKey();

        }
    }
}
