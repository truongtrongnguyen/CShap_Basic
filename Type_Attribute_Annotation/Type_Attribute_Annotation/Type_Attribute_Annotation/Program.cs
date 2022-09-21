using System;
using ClassLib;
namespace Type_Attribute_Annotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Co_Ban cb = new Co_Ban();
            //cb.Demo();

            //Su_Dung_Obsolete obsolete = new Su_Dung_Obsolete();
            //obsolete.Prints(); //Đưa ra dòng lệnh cảnh báo 

            //Su_Dung_Required required = new Su_Dung_Required();
            //required.Demo();

            Console.WriteLine(ConvertMoneyToText.NumberToText(223432, true));

            Tao_Attribute_Rieng t = new Tao_Attribute_Rieng();
            t.Demo();
            Console.ReadKey();
        }
    }
}
