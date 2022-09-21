namespace Prog_CSharp
{
    using System;
    // Giao diện IPointy dùng tìm số điểm trên một hình vẽ
    public interface IPointy
    {
        byte GetNumberOfPoints(); // đi lấy số điểm 
                                  // giao diện có thể có thuộc tính 
                                  // byte Points{get; set;} 
    }
    // Giao diện IDraw3D vẽ 3 chiều public interface IDraw3D 
    public interface IDraw3D
    {
        void Draw(); // vẽ
    }
    // Lớp cơ sở trừu tượng Shape vẽ hình dạng 
    public abstract class Shape
    {
        protected string petName; // biến tên thân thương 

        public Shape() { petName = "NoName"; } // hàm constructor 1, 
                                               // không thông số 
        public Shape(string s) // hàm constructor 2, 
                               // một thông số chuỗi chữ 
        {
            this.petName = s;
        }

        // tất cả các đối tượng con phải tự mình định nghĩa cần muốn vẽ gì 
        public abstract void Draw();
        public string PetName // thuộc tính PetName (tên thân thương) 
        {
            get { return this.petName; }
            set { this.petName = value; }
        }
    }
    // Lớp dẫn xuất từ lớp cơ sở Shape và giao diện IDraw3D 
    public class Circle : Shape, IDraw3D
    {
        public Circle() { } // hàm constructor, không thông số 
        public Circle(string name) : base(name) // triệu gọi hàm 
                                                // constructor lớp cơ sở 
        { }
        public override void Draw() // hàm vẽ bị phủ quyết 
        {
            Console.WriteLine("Vẽ " + PetName + " Hình Tròn");
        }
        void IDraw3D.Draw() // hàm tường minh giao diện vẽ 3 chiều
        {
            Console.WriteLine("Vẽ Hình Tròn 3D!");
        }
    } // end Circle 
      // Lớp dẫn xuất từ lớp cơ sở Shape, giao diện IPointy và IDraw3D 
    public class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { } // hàm constructor 
        public Hexagon(string name) : base(name) // triệu gọi hàm 
                                                 // constructor lớp cơ sở 
        { }

        public override void Draw() // hàm vẽ bị phủ quyết 
        {
            Console.WriteLine("Vẽ " + PetName + " Hình Lục Giác");
        }
        public byte GetNumberOfPoints() // hàm lấy số điểm 
        {
            return 6;
        }

        void IDraw3D.Draw() // hàm tường minh giao diện vẽ 3 chiều 
        {
            Console.WriteLine("Vẽ Hình Lục Giác 3D!");
        }
    } // end Hexagone 
      // Lớp dẫn xuất từ lớp cơ sở Shape, và giao diện IPointy 
    public class Triangle : Shape, IPointy
    {
        public Triangle(string name) : base(name) { }
        public Triangle() { }
        public override void Draw() // hàm vẽ bị phủ quyết 
        {
            Console.WriteLine("Vẽ " + PetName + " Hình Tam Giác");
        }
        public byte GetNumberOfPoints() // hàm lấy số điểm 
        {
            return 3;
        }
    } // end Triangle 
      // Lớp dẫn xuất từ lớp cơ sở Circle (lớp này lại là 
      // một lớp dẫn xuất ) 
    public class Oval : Circle
    {
        public Oval() { base.PetName = "Joe"; } // hàm constructor 
        new public void Draw() // hàm riêng mới của lớp Oval 
        {
            Console.WriteLine("Vẽ một Hình Bầu Dục dùng một giải thuật quái quy");
        }
    } // end Oval 
      // Lớp dẫn xuất từ lớp cơ sở Shape và giao diện IDraw3D 
    public class Line : Shape, IDraw3D
    {
        void IDraw3D.Draw() // hàm tường minh giao diện vẽ 3 chiều 
        {
            Console.WriteLine("Vẽ một đường thẳng 3D ...");
        }
        public override void Draw() // hàm vẽ bị phủ quyết 
        {
            Console.WriteLine("Vẽ một đường thẳng ...");
        }
    } // end Line 
    public class Tester
    {
        // Tôi sẽ vẽ bất cứ hình nào cũng được 
        public static void DrawThisShapeIn3D(IDraw3D i3d) // thông số là 
                                                          // giao diện 
        {
            i3d.Draw();
        }

        public static int Main(string[] args)
        {
            Line l = new Line();
            l.Draw(); // vẽ đường thẳng bình thường 
            IDraw3D iDraw3d = (IDraw3D)l;
            iDraw3d.Draw(); // vẽ đường thẳng 3 chiều 
                            // Cách thứ nhất để có một giao diện 
            Circle c = new Circle("Mitch");
            IPointy iPt;
            try
            {
                iPt = (IPointy)c;
                Console.WriteLine("Đi lấy giao diện dùng ép kiểu...");
            }
            catch (InvalidCastException e)
            { Console.WriteLine("OOPS! Không có điểm..."); }
            // Cách thứ hai để lấy một giao diện 
            Hexagon hex = new Hexagon("Fran");
            IPointy iPt2;
            iPt2 = hex as IPointy;
            if (iPt2 != null)
                Console.WriteLine("Đi lấy giao diện dùng từ chốt as ");
            else
                Console.WriteLine("OOPS! Không có điểm...");
            // Cách thứ ba để chụp lấy giao diện 
            Triangle t = new Triangle();
            if (t is IPointy)
                Console.WriteLine("Đi lấy giao diện dùng từ chốt is");
            else
                Console.WriteLine("OOPS! Không có điểm...");
            Console.WriteLine(); // nhảy một hàng 
                                 // Mẹo C# base class pointer. 
                                 // Tạo một collection Shape là một bản dãy 
            Shape[] sh = {new Hexagon(), new Circle(),
 new Triangle("Joe"), new Circle("JoJo")};
            // Rảo qua collection 
            for (int i = 0; i < sh.Length; i++)
            {
                sh[i].Draw();
                // Anh nào có điểm? 
                if (sh[i] is IPointy)
                    Console.WriteLine("Số điểm: {0}\n",
                    ((IPointy)sh[i]).GetNumberOfPoints());
                else
                    Console.WriteLine(sh[i].PetName + "không có điểm!\n");

                // Ta vẽ anh theo 3D được không ? 
                if (sh[i] is IDraw3D)
                    DrawThisShapeIn3D((IDraw3D)sh[i]);
                Console.WriteLine();
            }
            return 0;
        } // end Main 
    } // end Tester 
} // namespace Prog_CSharp