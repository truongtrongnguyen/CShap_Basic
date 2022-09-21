using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
namespace Dependency_inversion_DI
{
    internal class Su_Dung_Delegate_Factory
    {
        public void Demo()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<ClassA, ClassA>();

            //cách 1: 
            //services.AddSingleton<IClassB, ClassB2>((IServiceProvider provider) =>
            //{
            //    var b2 = new ClassB2(provider.GetService<IClassC>(), "Thuc hien trong classB2");
            //    return b2;
            //});

            //cách 2: Sử dụng Factory
            services.AddSingleton<IClassB>(Created);

            services.AddSingleton<IClassC, ClassC>();

            var provider=services.BuildServiceProvider();

            ClassA a = provider.GetService<ClassA>();
            a.ActionA();
        }

        //Sử dụng Factory
        public IClassB Created(IServiceProvider provider)
        {
            var b2 = new ClassB2(provider.GetService<IClassC>(), "Thuc Hien trong CLassB2");
            return b2;
        }
    }
    
    public class ClassB2:IClassB
    {
        IClassC c_dependency;
        string message;
        public ClassB2(IClassC c, string mgf)
        {
            c_dependency = c;
            message = mgf;
            Console.WriteLine("Created is CLassB2");
        }
        public void ActionB()
        {
            Console.WriteLine(message);
            c_dependency.ActionC();
        }
    }
}
