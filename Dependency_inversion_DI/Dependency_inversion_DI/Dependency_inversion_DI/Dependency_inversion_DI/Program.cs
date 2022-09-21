using System;

namespace Dependency_inversion_DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dependency_Injection e = new Dependency_Injection();
            //e.Demo();

            //Demo1 d = new Demo1();
            //d.Demo();

            //Dang_Ky_Dependency dk = new Dang_Ky_Dependency();
            //dk.Demo();

            //Su_Dung_Delegate_Factory sd = new Su_Dung_Delegate_Factory();
            //sd.Demo();

            //Su_Dung_Options op = new Su_Dung_Options();
            //op.Demo();

            Su_dung_File_cho_DI fl = new Su_dung_File_cho_DI();
            fl.Demo();
            Console.ReadKey();
        }
    }
}
