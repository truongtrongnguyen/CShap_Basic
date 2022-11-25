using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectSQL.Confir
{
    internal class Config
    {
         static string Host = @"DESKTOP-OJA04UG\SQLEXPRESS";
         static string Database = "QuanLySinhVien";
         static string Username = "sa";
         static string TrustedConnection = "True";

        public static string sqlConnection = String.Format($"Server = {Config.Host}; database = {Config.Database}; " +
            $"UID = {Config.Username}; Trusted_Connection= {Config.TrustedConnection}");
    }
}
