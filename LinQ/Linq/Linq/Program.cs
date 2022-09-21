using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo ra các nhãn hiệu
            List<Bran> brans = new List<Bran>
            {
                new Bran(){Id=1, Name="Cong ty AAA"},
                new Bran(){Id=2, Name="Cong ty BBB"},
                new Bran(){Id=4, Name="Cong ty CCC"}
            };

            List<Product> products = new List<Product>()
            {
                new Product(1, "Ban tra", 400, new string[] {"Xam", "Xanh"}, 2 ),
                new Product(2, "Tranh treo", 400, new string[] {"Vang", "Xan"}, 1 ),
                new Product(3, "Den trum", 500, new string[]{"Trang"}, 3),
                new Product(4, "Ban hoc", 200, new string []{"Trang", "Xanh"}, 1),
                new Product(4, "Tui da", 300, new string []{"Do", "Den", "Vang"}, 2),
                new Product(5, "Giuong ngu", 500, new string []{"Trang"},2 ),
                new Product (6, "Tu ao", 600, new string []{"Trang"}, 3)
            };


            /*
             * 1. Xác định nguồn dữ liệu: from tenphantu in IEnumerables( có thể là array, List, stack,...)
             *         ...ở giữa này có thể là lọc dữ liệu(Where), Xắp xếp (OrderBy),....
             * 2. Lấy dữ liệu: select, groupby...
             */


            //Sử dụng phương thức Select 
            //Phuong_Thuc_Select(products);

            //Sử dụng phương thức SelectMany 
            //Phuong_Thuc_SelectMany(products);

            //Sử dụng phương thức Where
            //Phuong_Thuc_Where(products);

            //Sử dụng phương thức Min, Max, Average
            //Phuong_Thuc_Min_MAx_Sum_Average(products);

            //Sử dụng phuoeng thức Join: Kết hợp các nguồn dữ liệu lại với nahu để lấy ra dữ liệu phù hợp
            //cụ thể là lấy ra dữ liệu chung giữa 2 danh sách
            //Phuong_Thuc_Join(products, brans);

            //Sử dụng phương thức GroupJoin - có 1 danh sách nhãn hiệu và liệt kê các tên thương hiệu ra
            //Phuong_Thuc_GroupJoin(products, brans);

            //Sử dung phương thức take - Lấy ra những sản phẩm đầu tiên
            //Phuong_Thuc_Take(products);

            //Sử dung phương thức skip - Xóa những sản phẩm đầu tiên và lấy ra những sản phẩm còn lại
            //Phuong_Thuc_Skip(products);

            //Sử dụng phương thức Sắp xếp - OrderBy (tăng dần) / OrderByDescending (giảm dần)
            //Phuong_Thuc_Sap_Xep(products);

            //Sử dụng phương thức nhóm các phần tử giống lại với nhau
            //Phuong_Thuc_GroupBy(products);

            //Sử dụng phương thức Distinct - Loại bỏ những phần tử có cùng giá trị
            //Phuong_Thuc_Distinct(products);

            //Sử dụng phương thức Single - SinggleorDefault
            //Phuong_Thuc_Single_SingleorDefault(products);

            //Sử dụng phương thức Any - Trả về true nếu thỏa mãn đk nào đó
            //Phuong_Thuc_Any_All_Count(products);

            //BT1(products, brans);
            BT2(products, brans);
            Console.ReadKey();
        }
        /// <summary>
        /// take elements by a value (lấy các phần tử theo một giá trị)
        /// </summary>
        /// <param name="products"></param>
        static void Phuong_Thuc_Select(List<Product> products)
        {

            //Lấy ra những sản phẩm có giá 400
            var ketqua1 = from product in products
                          where product.Price == 400
                          select product;
            Console.WriteLine("Danh sach nhung san pham co gia 400: ");
            foreach (var i in ketqua1)
            {
                Console.WriteLine(i);
            }

            //Lấy ra những tên sản phẩm thông qua phương thức delegate và lambda và biến ketqua2 thuộc kiểu IEnumerable
            Console.WriteLine("\nDanh sach cac ten san pham: ");
            var ketqua2 = products.Select(p =>
            {
                return p.Name + " | " + p.Price;  //Hoặc ta có thể lấy ra những thông số khác trong lớp product như giá , id hoặc là kiểu vô danh
            });
            foreach (var i in ketqua2)
            {
                Console.WriteLine(i);
            }
        }

        static void Phuong_Thuc_SelectMany(List<Product> product)
        {
            var kq = product.SelectMany(p =>//Nếu chọn Select thì nó sẽ xuất ra tên kiểu dữ liệu chứ không phải một mảng 
            {
                return p.Color;
            });
            foreach (var i in kq)
            {
                Console.WriteLine(i);
            }
        }

        static void Phuong_Thuc_Where(List<Product> products)//lọc ra những sản phẩm có giá trị theo đk 
        {
            //Nhận tham số là 1 delegate và kiểu trả về là true/false
            //Nếu trả về true thì phần tử đó được lấy ra
            var kq1 = products.Where(p =>
            {
                //return p.Name.Contains("tr");
                return p.Price >= 200 && p.Price <= 400;
            });
            foreach (var i in kq1)
            {
                Console.WriteLine(i);
            }

        }

        static void Phuong_Thuc_Min_MAx_Sum_Average(List<Product> products)
        {
            int[] number = { 1, 2, 3, 4, 6, 8, 9 };
            Console.WriteLine(number.Average());

            Console.WriteLine("So chan lon nhat: " + number.Where(x => { return x % 2 != 0; }).Sum());

            Console.WriteLine("Xuat gia nho nhat trong product: " + products.Min(x => x.Price));

            Console.WriteLine("Gia trung binh trong product: " + products.Average(x => x.Price));
        }

        static void Phuong_Thuc_Join(List<Product> products, List<Bran> brans)//kết hợp 2 danh sách lại với nhau
        {
            //  Join (<Nguồn dữ liệu kết hợp y>, <Dữ kiệu x dùng để kết hợp với nguồn y>, <Dữ liệu kết hợp của nguồn y>, <Kết quả lưu vào delegate>)
            //Nếu x và y trùng nhau thì sẽ lấy ra nguyên phần dư liệu của x và y
            var kq = products.Join(brans, x => x.Id, y => y.Id, (x, y) =>
            {
                return new {
                    Ten = x.Name,
                    Thuong_Hieu=y.Name
                };
            });

            foreach(var i in kq)
            {
                Console.WriteLine(i);
            }    
        }

        static void Phuong_Thuc_GroupJoin(List<Product> products, List<Bran> brans) //Gom những phần tử có giá trị giống nhau thành 1 group giữa 2 danh sách
        {
        
            //  VD có 1 danh sách nhãn hiệu và liệt kê các tên thương hiệu ra
            //GroupJoin(<nguồn những phần tử nhóm Y>, <lấy ra dữ liệu cần so sánh X>, <lấy ra dữ liệu cần so sánh Y>, delegate(nhãn hiệu, sản phẩm nhãn hiệu đó)
            //những phần tử y trong nhóm products mà có bran giống với X.Id thì sẽ lấy ra đưa vào một nhóm nhãn hiệu và sản phẩm
            var kq = brans.GroupJoin(products, x => x.Id, y => y.Bran, (bran, product) =>
            {
                return new
                {
                    ThuongHieu = bran.Name,
                    Cacsanpham = product,
                };
            });

            foreach (var i in kq)
            {
                Console.WriteLine(i.ThuongHieu);
                foreach (Product j in i.Cacsanpham)
                {
                    Console.WriteLine(j);
                }
            }
        }

        static void Phuong_Thuc_Take(List<Product> products)//lấy ra những sản phẩm đầu tiên
        {
            //Lấy ra 4 sản phẩm đầu tiên
            var kq=products.Take(4);
            foreach (var i in kq)
            {
                Console.WriteLine(i);
            }
            //Hoặc cách 2: 
            products.Take(4).ToList().ForEach(p=>Console.WriteLine(p));
        }

        static void Phuong_Thuc_Skip(List<Product> products)//xóa những phần tử đầu tiên và lấy ra những phần tử còn lại
        {
            //phương thức skip xóa những phần tử đầu tiên và lấy ra những phần tử còn lại
            products.Skip(4).ToList().ForEach(p => Console.WriteLine(p));
        }

        static void Phuong_Thuc_Sap_Xep(List<Product> products)
        {
            //sắp xếp tăng dần 
            products.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));
            //Sắp xếp giảm dần
            products.OrderByDescending(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));
        }

        static void Phuong_Thuc_GroupBy(List<Product> products)//nhóm những sản phẩm trùng giá trị lại với nhau
        {
            //trả về một tập hợp, mỗi phần tử trong tập hợp được nhóm theo một giá trị nào đó
            var kq = products.GroupBy(p => p.Bran);//nhóm những sản phẩm trùng giá lại với nhau
            foreach(var group in kq)
            {
                Console.WriteLine("Group: "+group.Key);//Do chúng ta nhóm lại nên nó sẽ tạo một key cho mỗi nhóm đó, mà trong nhóm lại chứa các phần tử con
                foreach(var item in group)
                {
                    Console.WriteLine(item);
                }    
            }    
        }

        static void Phuong_Thuc_Distinct(List<Product> products)//Loại bỏ những phần tử có cùng giá trị
        {
            //Loại bỏ những phần tử có cùng giá trị
            products.SelectMany(p => p.Color).Distinct().ToList().ForEach(mau => Console.WriteLine(mau));//lấy ra danh sách các màu khác nhau
        }

        static void Phuong_Thuc_Single_SingleorDefault(List<Product> products)
        {
            //Single - trả về một phần tử theo 1 giá trị nào đó, nếu trả về nhiều phần tử hoặc không có phần tử nào thỏa đk thì sẽ lỗi
            Console.WriteLine("Su dung Single: ");
            var kq = products.Single(p => p.Price == 4003);
            Console.WriteLine(kq);

            //Single - trả về một phần tử theo 1 giá trị nòa đó hoặc không tìm thấy sẽ trả về null, còn có trả về nhiều phần tử thì sẽ báo lỗi
            Console.WriteLine("Su dung SingleOrDefault: ");
            var kq1 = products.SingleOrDefault(p => p.Price == 4003);
            if(kq1!=null)
            {
                Console.WriteLine(kq1);
            }    
        }

        static void Phuong_Thuc_Any_All_Count(List<Product> products)
        {
            //Phương thức Any - trả về true nếu thỏa đk
            var kq = products.Any(p => p.Price == 600);
            Console.WriteLine(kq);

            //Phương thức All - tất cả các phần tử phải thỏa đk mới trả về true
            var kq1 = products.All(p => p.Price >= 200);
            Console.WriteLine(kq1);

            //Phương thức Count - có thể kèm theo DK
            var kq2 = products.Count(p => p.Price == 400);
            Console.WriteLine("So san pham co gia 400 la: " + kq2);
        }

        static void BT1(List<Product> products, List<Bran> brans)
        {
            //in ra tên sp, tên thương hiệu, có giá (300 - 400) và sắp xếp giảm dần

            //Gốc: 
            //products.Where(p => p.Price >= 300 && p.Price <= 400)
            //    .OrderByDescending(p=>p.Price)
            //    .Join(brans, product=>product.Bran, bran=>bran.Id,(s_pham,t_hieu)=>
            //    {
            //        return new
            //        {
            //            TenSP = s_pham.Name,
            //            TenTH = t_hieu.Name,
            //            Gia = s_pham.Price
            //        };
            //    }).ToList().ForEach(info=>
            //    Console.WriteLine($"{info.TenSP, 15} {info.TenTH, 15} {info.Gia, 5}"));

            //  cách 1: 
            products.Where(p => p.Price >= 300 && p.Price <= 400)
                .OrderByDescending(p => p.Price)
                .Join(brans, product => product.Bran, bran => bran.Id, (sp, th) =>
                {
                    return sp;
                }).ToList().ForEach(info=>Console.WriteLine(info));
            //  cách 2: tự viết
            Console.WriteLine();
            var ketqua1 = from product in products
                          where product.Price >= 300&&product.Price<=400
                          select product;
            ketqua1.OrderBy(p => p.Price).Join(brans, p => p.Bran, b => b.Id, (sp, th) =>
            {
                return sp;
            }).ToList().ForEach(info => Console.WriteLine(info));
        }

        static void BT2(List<Product> products, List<Bran>brans)
        {
            /*
             * 1. Xác định nguồn dữ liệu: from tenphantu in IEnumerables( có thể là array, List, stack,...)
             *         ...ở giữa này có thể là lọc dữ liệu(Where), Xắp xếp (OrderBy),....
             * 2. Lấy dữ liệu: select, groupby..., into (Biến tạm), let = Biểu thức tính toán   
             */
            //Lấy ra tên sản phẩm
            #region - Sử dụng Select
            //Console.WriteLine("Su dung select: ");
            //var kq1 = from p in products
            //          select $"{p.Name} :  {p.Price}";//Hoặc có thể trả về kiểu vô danh

            //kq1.ToList().ForEach(name => Console.WriteLine(name));

            ////hoặc cách 2
            //var kq2 = from product in products
            //          from color in product.Color
            //          where product.Price <= 400 && color == "Xanh"
            //          orderby product.Price descending
            //          select new
            //          {
            //              Ten = product.Name,
            //              Gia = product.Price,
            //              Mau=product.Color
            //          };
            //kq2.ToList().ForEach(abc =>
            //{
            //    Console.WriteLine($"Name: {abc.Ten} : Gia: {abc.Gia} : Mau: {string.Join(", ", abc.Mau)}");//Phương thức Join giúp ghép các từ trong chuỗi lại với nhau
            //});
            #endregion

            #region Sử dụng Group by gồm có Key và nội dung chứa trong key đó
            //var kq4 = from product in products
            //          group product by product.Price into gr   //KẾT QUẢ ĐƯỢC LƯU VÀO BIẾN TẠM THÔNG QUA BIẾN into để có thể dễ xử lí những tác vụ khác
            //          orderby gr.Key
            //          select gr;    //Sắp xếp xong thì lấy ra những select 

            //kq4.ToList().ForEach(group =>
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var i in group)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            #endregion

            #region Gom các sản phẩm theo giá và trả về theo group giá, các sản phẩm theo group giá và số lượng
            //var kq5 = from product in products
            //          group product by product.Price into gr
            //          orderby gr.Key
            //          let sl = "So luong san pham: " + gr.Count()
            //          select new
            //          {
            //              Gia = gr.Key,
            //              Cacsanpham = gr.ToList(),
            //              SoLuong = sl
            //          };

            //foreach(var group in kq5)
            //{
            //    Console.WriteLine(group.Gia);
            //    Console.WriteLine(group.SoLuong);
            //    foreach (var i in group.Cacsanpham)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}    
            #endregion

            #region Gom các sản phẩm và xuất ra tên sp, thương hiệu và giá
            // cách 1: 
            var kq6 = products.Join(brans, sp => sp.Bran, th => th.Id, (sp, th) =>
            {
                return new
                {
                    TenSP = sp.Name,
                    TH = th.Name,
                    Gia = sp.Price
                };
            });
            foreach(var i in kq6)
            {
                Console.WriteLine($"Thuong hieu {i.TH} : Tensp: {i.TenSP} : Gia: {i.Gia}");
            }
            // cách 2:
            var kq7 = from product in products
                      join bran in brans on product.Bran equals bran.Id into t//lưu vào biến tạm, với mỗi phần tử bran trong brans và đk là sau từ on
                      from brann in t.DefaultIfEmpty()//tìm nhãn hiệu trong danh sách sản phẩm và nhãn hiệu t, nếu tìm thấy thì trả về nhãn hiệu còn không thì trả về null                                
                      select new
                      {
                          SP = product.Name,
                          TH = (brann != null) ? brann.Name : "No Bran",
                          Gia = product.Price
                      };
            foreach (var i in kq7)
            {
                Console.WriteLine($"{i.SP,15} {i.TH,15} {i.Gia,5}");
            }
            #endregion
        }
    }
}
