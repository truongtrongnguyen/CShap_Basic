using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Su_dung_Delegate
{
    public class Event_nang_cao
    {
        public class Point3
        {
            private int x;
            public int X
            {
                get { return x; }
                set
                {
                    x = value;
                    EventHandler<ThayDoi> handler = (EventHandler<ThayDoi>)Events["OnValueChanged"];
                    if (handler != null)
                    {
                        handler(this, new ThayDoi(this));
                    }
                }
            }
            private int y;
            public int Y
            {
                get { return y; }
                set
                {
                    y = value;
                    //Về sau cần sử dụng event nào thì vào danh sách gõ đúng tên event đó là được
                    EventHandler<ThayDoi> temp = (EventHandler<ThayDoi>)Events[EventName[(int)EventNamee.OnValueChanged]];
                    //Và ta tạo ra biến temp, nó chính là hàm được ủy thác có tên tương ứng                                                                             
                    if (temp != null)
                    {
                        temp(this, new ThayDoi(this));
                    }
                }
            }
            public Point3(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public EventHandlerList Events = new EventHandlerList();//Tạo một danh sách event, tương tự như cái mảng event để thuận tiện quản lí

            private event EventHandler<SizeEventArgs> _valuechanged;
            public event EventHandler<ThayDoi> ValueCChanged
            {
                add
                {
                    //Tương tự như event [] eventlist
                    //eventlist.Add(new event ())
                    Events.AddHandler(EventName[(int)EventNamee.OnValueChanged], value);//Do event mỗi loại sẽ khác nhau và mỗi phần tử nó ra vào liên tục nên ta không thể
                }                                            // truy cập qua indext được nên ta phải truy cập thông qua tên
                remove
                {
                    Events.RemoveHandler(EventName[(int)EventNamee.OnValueChanged], value);
                }
            }
            public class SizeEventArgs : EventArgs
            {
                public Point3 NewPoint
                {
                    get;
                    set;
                }
                public SizeEventArgs(Point3 point)
                {
                    NewPoint = new Point3(point.X, point.Y);
                }
                public override string ToString()
                {
                    return NewPoint.X + " | " + NewPoint.Y;
                }
            }
            public class ThayDoi : EventArgs
            {
                private Point3 point;
                public ThayDoi(Point3 poi)
                {
                    point = poi;
                }
                public override string ToString()
                {
                    return ($"Diem 1: {point.X} - Diem 2: {point.Y}");
                }
            }

            List<string> EventName = new List<string>() {//Tạo danh sách các tên hàm event để gọi cho linh hoạt
            "OnValueChanged",
            "OnValueChanging"
            };
            //Gọi thông qua danh sách list<string> rồi thông qua hàm liệt kê enum để lấy chỉ số indext
            public enum EventNamee
            {
                OnValueChanged,
                OnvalueChanging
            };
        }
    }
}
