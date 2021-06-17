using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien
{
    class Config
    {
        public static string connectionString(string name, string password)
        {
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" + "(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=" + name + ";Password=" + password + ";";
            return connectionString;
        }
    }
}
