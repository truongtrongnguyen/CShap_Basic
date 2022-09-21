using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Su_dung_Delegate;

namespace Su_dung_event_chuan
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Hocsinh hs = new Hocsinh();
            //hs.Namechanged += Hs_Namechanged;
            //hs.Name = "Thay doi lan 1";
            //hs.Name = "Thay doi lan 2";
            //hs.Name = "Thay doi lan 3";
             
            Event_nang_cao.Point3 points = new Event_nang_cao.Point3(0,0);
           // points.ValueCChanged += point_ValueChanged;
            points.ValueCChanged += Point_ThayDoi;
            points.X++;
            Console.WriteLine(points.X+" | "+points.Y);
            points.Y++;
            Console.WriteLine(points.X + " | " + points.Y);
            Console.ReadKey();
        }
        static void point_ValueChanged(object sender, Event_nang_cao.Point3.SizeEventArgs e)
        {
            Console.WriteLine(e.ToString());
        }
        static void Point_ThayDoi(object sender,  Event_nang_cao.Point3.ThayDoi e)
        {
            Console.WriteLine(e.ToString());
        }
        private static void Hs_Namechanged(object sender, NamechangedeventArgs e)
        {
            //Hocsinh hs = sender as Hocsinh;
           // Console.WriteLine(hs.Name);
            Console.WriteLine("Ten co thay doi la: " + e.Name);
        }
    }
    class Hocsinh
    {
        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OneNameChanged(value);
            }
        }
        //public EventHandlerList Event = new EventHandlerList();
        private event EventHandler<NamechangedeventArgs> _Namechanged;
        public event EventHandler<NamechangedeventArgs> Namechanged
        {
            add
            {
                _Namechanged += value;
            }
            remove
            {
                _Namechanged -= value;
            }
        }
        public void OneNameChanged(string name)
        {
            if(_Namechanged!=null)
            {
                _Namechanged(this ,new NamechangedeventArgs(name));
            }
        }

    }
    class NamechangedeventArgs
    {
        public string Name;
        public NamechangedeventArgs(string name)
        {
            Name = name;
        }
    }
}
