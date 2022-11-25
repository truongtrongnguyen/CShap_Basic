using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Quan_Ly_Vat_Tu
{
    public class Vat_Tu
    {
        public ds_Vat_Tu ds_vattu;
        public string ma_vt { get; set; }
        public string ten_vt { get; set; }
        public string don_vi { get; set; }
        public int so_luong_ton { get; set; }
        public bool kt;


        private static readonly Regex sWhitespace = new Regex(@"\s+");
        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }

        public Vat_Tu()
        {
            ds_vattu = new ds_Vat_Tu();
        }
        public void Input()
        {
            ma_vt = Tao_maVT();
            Edit_Input();
            Console.Write("Nhap so luong ton: ");
            so_luong_ton = int.Parse(Console.ReadLine());
        }
        public void Edit_Input()
        {
            Console.Write("Nhap ten vat tu: ");
            ten_vt = Cat_Khoang_Trang(Console.ReadLine());

            Console.Write("Nhap don vi tinh: ");
            don_vi = Console.ReadLine().FirstCharToUpper();
        }
        public void Display()
        {
            Console.WriteLine($"Ma VT: {ma_vt} | Ten VT: {ten_vt} | Don vi: {don_vi} | So luong: {so_luong_ton} | KT: {kt}");
        }
        public string Cat_Khoang_Trang(string sent)
        {
            //sent = sent.Trim(); // Xóa đầu cuối
            //Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            //sent = trimmer.Replace(sent, " ");
            ////sent = trimmer.Replace(sent, " ");

            //string[] a = sent.Split(' ');
            //string b = "";
            //for(int i=0;i<a.Length;i++)
            //{
            //    b+=StringExtensions.FirstCharToUpper(a[i])+ " ";
            //}
            //return b;

            return Regex.Replace(sent, @"\s+", " ").Trim();
        }

        public string Tao_maVT()
        {
            Random random = new Random();

            string ma_vt = "VT";
            string a = "";
            do
            {
                for (int i = 2; i < 6; i++)
                {
                    a = Convert.ToString(random.Next(0, 9));
                    ma_vt += a;
                }
            } while (Check_ma_vt(ma_vt, ds_vattu) != -1);

            return ma_vt;
        }
        public int Check_ma_vt(string mavt, ds_Vat_Tu ds)
        {
            for (int i = 0; i < ds.soluong; i++)
            {
                if (mavt == ds.ds_vat_tu[i].ma_vt)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
            };
    }
    public class ds_Vat_Tu
    {
        public Vat_Tu[] ds_vat_tu = new Vat_Tu[100];
        public int soluong = 0;
    }

}
