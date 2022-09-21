using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Ian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.ClickEvent += Button_ClickEvent;
            button.Name = "HelloWoork";

            Console.Write("Nhap vao: ");
            var a = Console.ReadLine();
            if(a=="a")
            {
                KeyPress();
            }
            Console.ReadKey();
        }

        private static void Button_ClickEvent(object sender, MycustomArgument e)
        {
            Console.WriteLine($"Ban vua nhap: "+e.Name);
           
        }

        public static void KeyPress()
        {
            Button button = new Button();
            button.ClickEvent += (s, args) =>
            {
                Console.WriteLine("You click a button " + args.Name);
                //button.Oneclick(args.Name);
            };
            
        }
    }

    public class Button
    {
        public event EventHandler<MycustomArgument> ClickEvent;
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value;
                if(ClickEvent!=null)
                {
                    Oneclick(value);
                }
                else
                {
                    Console.WriteLine("Onclick la null");
                }
            }
        }
        public void Oneclick(string name)
        {
            
                ClickEvent(this, new MycustomArgument(name));
        }
    }
    public class MycustomArgument:EventArgs
    {
        public string Name
        {
            get;set;
        }
        public MycustomArgument(string name)
        {
            Name = name;
        }
    }
}
