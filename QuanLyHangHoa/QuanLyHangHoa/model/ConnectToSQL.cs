using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyHangHoa.model
{
    class ConnectToSQL
    {
        String datasource;
        String database;

        public ConnectToSQL()
        {
            datasource = "DESKTOP-BOPPJ92";
            database = "QUANLIDOPHUOT";
        }

        public void open()
        {
            String connString = @"Data Source=" + datasource + "; Initial Catalog = "
                         + database + ";Persist Security Info=True";

            SqlConnection conn = new SqlConnection(connString);
        }
    }
}
