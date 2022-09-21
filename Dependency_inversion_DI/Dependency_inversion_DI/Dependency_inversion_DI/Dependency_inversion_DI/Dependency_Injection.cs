using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Microsoft.Extensions.DependencyInjection;
namespace Dependency_inversion_DI
{
    internal class Dependency_Injection
    {
        //Class B là dependency của class A bởi vì cần có class B thì class A mới hoàn thành tách vụ được
        //Inversion of Control (IoC) - Dependency Inversion (Đảo ngược điều khiển): Các thành phẩn nó dựa vào để làm việc bị đảo ngược quyền điều khiển 
        //khi so sánh với lập trình hướng thủ tục truyền thống
        public void Demo()
        {
            #region Cách 1: 
            IClassC objectC = new ClassC1();
            IClassB objectB = new ClassB1(objectC);
            ClassA objectA = new ClassA(objectB);

            //class A tham chiếu đến class B và thi hành nhiệm vụ trong class B, class B lại tham chiếu đến class C và thi hành nhiệm vụ trong class C
            objectA.ActionA();
            /*
             * Ta có thể tạo một class khác kế thừa từ interface và từ đó chỉ cần tham chiếu đến class đó thông qua interface như vậy gọi là đảo ngược
             * Dependency inject là triển khai từ nguyên tắc đảo ngược sự phụ thuộc (Dependency inversion), Tức là ta thiết kế 1 class A mà khi class A 
             * cần dependency thì khi thực thi cơ chế đó nó sẽ tự động bơm dependency đó vào cho class A, và dependency đó có thể là interface ở trong class A
             */
            #endregion

            #region Cách 2:
            Console.WriteLine("SU dung cach 2: ");

            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<ClassA, ClassA>();
            services.AddSingleton<IClassB, ClassB>();
            services.AddSingleton<IClassC, ClassC>();

            var provider = services.BuildServiceProvider();

            ClassA a = provider.GetService<ClassA>();
            a.ActionA();

            #endregion
        }
    }




    public interface IClassB
    {
        void ActionB();
    }
    public interface IClassC
    {
        void ActionC();
    }


    public class ClassC1 : IClassC
    {
        public ClassC1() => Console.WriteLine("ClassC1 is Created");
        public void ActionC()
        {
            Console.WriteLine("Action in C1");
        }
    }
    public class ClassB1 : IClassB
    {
        IClassC c_dependency;
        public ClassB1(IClassC _c_dependency)
        {
            Console.WriteLine("ClassB1 is Created");
            c_dependency = _c_dependency;
        }
        public void ActionB()
        {
            Console.WriteLine("Action in B1");
        }
    }
  

    public class ClassA
    {
        IClassB b_dependency;//phụ thuộc của class A là class B
        public ClassA(IClassB _b_dependency)
        {
            b_dependency = _b_dependency;
        }
        public void ActionA()
        {
            Console.WriteLine("Action in Class A");
            b_dependency.ActionB();
        }
    }

    public class ClassB : IClassB
    {
        IClassC c_dependency;//phụ thuộc của class B là class C
        public ClassB(IClassC _c_dependency)
        {
            c_dependency = _c_dependency;
        }
        public void ActionB()
        {
            Console.WriteLine("Action in Class B");
            c_dependency.ActionC();
        }
    }

    public class ClassC : IClassC
    {
        public void ActionC() => Console.WriteLine("Action in Class C");
    }
}
