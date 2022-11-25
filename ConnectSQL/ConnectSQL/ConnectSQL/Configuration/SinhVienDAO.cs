using ConnectSQL.Confir;
using ConnectSQL.Module;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace ConnectSQL.Configuration
{
    internal class SinhVienDAO
    {
        public static List<SinhVien> GetSinhVien()
        {
            List<SinhVien> dataList = new List<SinhVien>();
            using SqlConnection conn = new SqlConnection(Config.sqlConnection);
            conn.Open();
            using var command =new  SqlCommand();
            command.Connection = conn;
            command.CommandText = "select * from SinhVien";

            //--> Cách 2:
            //var parameter = new SqlParameter("@MaSV", sv.MaSV);
            //command.Parameters.Add(parameter);
            //sv.MaSV = "20113021"; set maSv bằng giá trị mong muốn

            var dataReader = command.ExecuteReader();
            //Các lệnh kiểm tra:
            if (dataReader.HasRows)         // kiểm tra xem có dữ lieeuh trả về hay không (True / False)
            {
                Console.WriteLine("Truy van du lieu thanh cong");
                while (dataReader.Read())
                {
                    //Cách đọc 1: Lấy dữ liệu theo vị trí và kiểu dữ liệu cụ thể
                    //string masv = dataReader.GetString(0);
                    //Cách đọc 2:
                    string masv = dataReader["MaSV"].ToString();
                    string hoten = dataReader["Ho_TenSV"].ToString();
                    int namsinh = int.Parse(dataReader["Nam_Sinh"].ToString());
                    string datoc = dataReader["Dan_Toc"].ToString();
                    string malop = dataReader["Ma_Lop"].ToString();

                    SinhVien sv = new SinhVien(masv, hoten, namsinh, datoc, malop);
                    dataList.Add(sv);
                }
            }
            else
            {
                Console.WriteLine("Khong co du lieu");
            }
            
            conn.Close();
            return dataList;
        }

        public static void InsertInto_SV(SinhVien sv)
        {
            using SqlConnection conn = new SqlConnection(Config.sqlConnection);
            conn.Open();
            using SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Insert into SinhVien (MaSV, Ho_TenSV, Nam_Sinh, Dan_Toc, Ma_Lop)" +
                $"values (@MaSV, @Ho_TenSV, @Nam_Sinh, @Dan_Toc, @Ma_Lop)";

            //-->Cách 1: Tìm kiếm thằng nào trùng mã và thay vào
            command.Parameters.AddWithValue("@MaSV", sv.MaSV);
            command.Parameters.AddWithValue("@Ho_TenSV", sv.Ho_TenSV);
            command.Parameters.AddWithValue("Nam_Sinh", sv.Nam_Sinh);
            command.Parameters.AddWithValue("@Dan_Toc", sv.Dan_Toc);
            command.Parameters.AddWithValue("@Ma_Lop", sv.Ma_Lop);

            

            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_SV()
        {
            Console.Write("Nhap MaSV can xoa: ");
            string masv = Console.ReadLine();
            SinhVien sv = Find_SV(masv);
            if(sv!= null)
            {
                Delete(sv);
                Console.WriteLine("Xoa sinh vien thanh cong");
            }
            else
            {
                Console.WriteLine("Ma sinh vien khong ton tai");
            }
        }

        public static void Delete(SinhVien sv)
        {
            using SqlConnection conn = new SqlConnection(Config.sqlConnection);
            conn.Open();
            using SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "delete SinhVien where MaSV = @MaSV";
            command.Parameters.AddWithValue("@MaSV", sv.MaSV);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_SV()
        {
            Console.Write("Nhap MaSV can sua thong tin: ");
            string masv = Console.ReadLine();
            SinhVien sv = Find_SV(masv);
            if(sv!= null)
            {
                sv.Input();
                Update(sv);
                Console.WriteLine("Cap nhat thong tin thanh cong");
            }
            else
            {
                Console.WriteLine("Ma sinh vien khong ton tai!!!");
            }
        }

        public static void Update(SinhVien sv)
        {
            using SqlConnection conn = new SqlConnection(Config.sqlConnection);
            conn.Open();
            using SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "update SinhVien set MaSV = @MaSV, Ho_TenSV = @Ho_TenSV, Nam_Sinh = @Nam_Sinh, Dan_Toc = @Dan_Toc, Ma_Lop = @Ma_Lop where MaSV = @MaSV";
            command.Parameters.AddWithValue("@MaSV", sv.MaSV);
            command.Parameters.AddWithValue("@Ho_TenSV", sv.Ho_TenSV);
            command.Parameters.AddWithValue("@Nam_Sinh", sv.Nam_Sinh);
            command.Parameters.AddWithValue("@Dan_Toc", sv.Dan_Toc);
            command.Parameters.AddWithValue("@Ma_Lop", sv.Ma_Lop);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static SinhVien Find_SV(string masv)
        {
            SinhVien sv = null;
            using SqlConnection conn = new SqlConnection(Config.sqlConnection);
            conn.Open();
            using SqlCommand connect = new SqlCommand();
            connect.Connection = conn;
            connect.CommandText = $"select * from SinhVien Where MaSV= @masv";
            connect.Parameters.AddWithValue("@masv", masv);
            var dataReader = connect.ExecuteReader();
            while (dataReader.Read())
            {
                string masvv = dataReader["MaSV"].ToString();
                string hoten = dataReader["Ho_TenSV"].ToString();
                int namsinh = int.Parse(dataReader["Nam_Sinh"].ToString());
                string datoc = dataReader["Dan_Toc"].ToString();
                string malop = dataReader["Ma_Lop"].ToString();

                sv = new SinhVien(masvv, hoten, namsinh, datoc, malop);
            }
            conn.Close();
            return sv;
        }
    }
}
