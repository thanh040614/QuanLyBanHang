using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHangHoa.model
{
    class NhanVienmod
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BOPPJ92;Initial Catalog=QUANLIDOPHUOT;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();//truy vấn
        
        public DataTable GetData()
        {
            DataTable dt = new DataTable();//tạo kho ảo để lưu trữ dữ liệu
            cmd.CommandText = "select * from NHANVIEN";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Co;
            return dt;
        }
        private void ConnectSQL()
        {
            //chúng ta mở kết nối
            con.Open();
            string sql = "";//lấy dữ liệu từ SQL
            
            
            SqlDataAdapter da = new SqlDataAdapter(com);//chuyển dữ liệu về
            
            da.Fill(dt);//đổ dữ liệu vào kho
            //đóng kết nối
            con.Close();
            //đổ dữ liệu vào kho
            dataGridView1.DataSource
        }
    }
}
