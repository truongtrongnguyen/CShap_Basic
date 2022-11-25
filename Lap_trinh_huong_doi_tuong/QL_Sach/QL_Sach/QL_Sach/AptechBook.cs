using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sach
{
    internal class AptechBook:Book
    {
        private string language;
        private string semete;
        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        public string Semete
        {
            get { return semete; }
            set { semete = value; }
        }
        public AptechBook()
        {
        }

        public AptechBook(string name, string author, string producer,string yearPublish,float price,
            string language, string semete):base(name, author, producer, yearPublish,price)
        {
            this.language = language;
            this.Semete = semete;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ngon ngu: ");
            Language = Console.ReadLine();
            Console.WriteLine("Nhap ki hoc: ");
            Semete = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Ngon ngu: " + Language);
            Console.WriteLine("Ki hoc: " + Semete);
        }
        /*
         *  public override tostirng()
         *  {
         *      retunrn base.Tostring()+"Ngon ngu: {0}"+ "...";
         */

    }
}
