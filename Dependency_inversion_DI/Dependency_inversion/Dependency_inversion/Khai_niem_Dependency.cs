using System;

namespace Dependency_inversion
{
    internal class Khai_niem_Dependency
    {
       public void Demo()
        {
            B b = new B();
            b.ActionB();
        }
    }
    public class A
    {
        public void ActionA() => Console.WriteLine("Action in class A");
    }
    public class B
    {
        public void ActionB()
        {
            Console.WriteLine("Action in class B");
            var a = new A();//như vậy ta goi class B dựa vào class A để hoàn thành nhiệm vụ hoặc là class A là Dependency của class B
            a.ActionA();
        }
    }
}
