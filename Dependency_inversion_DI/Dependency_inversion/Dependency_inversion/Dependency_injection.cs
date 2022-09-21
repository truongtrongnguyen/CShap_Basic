using System;

namespace Dependency_inversion
{
    public interface IClassB
    {
        void ActionB();
    }
    public interface IClassC
    {
        void ActionC();
    }
    public class ClassC1:IClassC
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
            c_dependency.ActionC();
        }
    }
    internal class Dependency_injection
    {
        public void Demo()
        {
            IClassC objectC = new ClassC1();
            IClassB objectB = new ClassB1(objectC);
            ClassA objectA = new ClassA(objectB);
            
            //class A tham chiếu đến class và thi hành nhiệm vụ trong class B, class B lại tham chiếu đến class C và thi hành nhiệm vụ trong class C
            objectA.ActionA();
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
    public class ClassB:IClassB
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
    public class ClassC:IClassC
    {
        public void ActionC() => Console.WriteLine("Action in Class C");
    }
}
