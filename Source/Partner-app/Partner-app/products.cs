using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Partner_app
{
    public partial class products : Form
    {
        private string userID;
        private string strSearch = "";
        SqlConnection connnect;
        SqlCommand command;
        string strconn = "data source=DESKTOP-S7P1JHC;initial catalog=QLGH;trusted_connection=true";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableProducts = new DataTable();
        //Tải lên danh sách sản phẩm
        void loadListProduct()
        {
            command = connnect.CreateCommand();
            if(strSearch == "")
                command.CommandText = "select MaSp as N'Mã', TenSp as N'Tên sản phẩm', DonGia as N'Đơn giá', SL_ConLai as N'Số lượng' from SanPham where MaDT = '"+userID+"'";
            else
                command.CommandText = "select MaSp as N'Mã', TenSp as N'Tên sản phẩm', DonGia as N'Đơn giá', SL_ConLai as N'Số lượng' from SanPham where MaDT = '" + userID + "' and TenSP like N'%"+strSearch+"%'";
            adapter.SelectCommand = command;
            tableProducts.Clear();
            adapter.Fill(tableProducts);
            pdgv.DataSource = tableProducts;
            pdgv.Columns[1].Width = 400;
            pdgv.Columns[2].Width = 120;
            pdgv.Columns[3].Width = 80;
        }
       //Khởi tạo giao diện danh sách sản phẩm theo ID đối tác
        public products(string ID)
        {
            InitializeComponent();
            userID = ID;
        }
        private void pdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = pdgv.CurrentRow.Index;
            MaSP.Text = pdgv.Rows[i].Cells[0].Value.ToString();
            TenSP.Text = pdgv.Rows[i].Cells[1].Value.ToString();
            DonGia.Text = pdgv.Rows[i].Cells[2].Value.ToString();
            SL_ConLai.Text = pdgv.Rows[i].Cells[3].Value.ToString();
            noticeContent.Text = "";
        }
        //Thêm sản phẩm
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                command = connnect.CreateCommand();
                if (MaSP.Text == "" || TenSP.Text == "" || DonGia.Text == "" || SL_ConLai.Text == "")
                {
                    noticeContent.Text = "Bạn cần nhập đầy đủ thông tin!";
                    return;
                }
                command.CommandText = "select * from SanPham where MaSP ='" + MaSP.Text + "'";
                object CSanPham = command.ExecuteScalar();
                if (CSanPham != null)
                {
                    noticeContent.Text = "Mã sản phẩm đã tồn tại!";
                    return;
                }
                if (!int.TryParse(DonGia.Text, out _))
                {
                    noticeContent.Text = "Đơn giá phải là 1 số!";
                    return;
                }
                if (!int.TryParse(SL_ConLai.Text, out _))
                {
                    noticeContent.Text = "Số lượng phải là 1 số!";
                    return;
                }
                command.CommandText = "sp_createProduct";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@MASP", MaSP.Text));
                command.Parameters.Add(new SqlParameter("@MADT", userID));
                command.Parameters.Add(new SqlParameter("@TenSP", TenSP.Text));
                command.Parameters.Add(new SqlParameter("@DonGia", int.Parse((DonGia.Text))));
                command.Parameters.Add(new SqlParameter("@SL_ConLai", int.Parse((SL_ConLai.Text))));
                command.ExecuteNonQuery();
                command.CommandType = CommandType.Text;
                loadListProduct();
                noticeContent.Text = "Thêm sản phẩm thành công!";
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }

        }
       
        //Chỉnh sửa sản phẩm
        private void edit_Click(object sender, EventArgs e)
        {
           try
            {
                command = connnect.CreateCommand();
                if (MaSP.Text == "" || TenSP.Text == "" || DonGia.Text == "" || SL_ConLai.Text == "")
                {
                    noticeContent.Text = "Bạn cần nhập đầy đủ thông tin!";
                    return;
                }
                command.CommandText = "select * from SanPham where MaSP ='" + MaSP.Text + "'";
                object CSanPham = command.ExecuteScalar();
                if (CSanPham == null)
                {
                    noticeContent.Text = "Mã sản phẩm không tồn tại!";
                    return;
                }
                if (!int.TryParse(DonGia.Text, out _))
                {
                    noticeContent.Text = "Đơn giá phải là 1 số!";
                    return;
                }
                if (!int.TryParse(SL_ConLai.Text, out _))
                {
                    noticeContent.Text = "Số lượng phải là 1 số!";
                    return;
                }
                command.CommandText = "update SanPham set MaDT = '"+userID+"', TenSP = N'"+TenSP.Text+"',SL_ConLai = '"+SL_ConLai.Text+"' where MaSP = '"+MaSP.Text+"'";
                command.ExecuteNonQuery();

                command.CommandText = "sp_updateProduct_Uread";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@MASP", MaSP.Text));
                command.Parameters.Add(new SqlParameter("@DonGia", int.Parse((DonGia.Text))));
                command.ExecuteNonQuery();
                command.CommandType = CommandType.Text;
                loadListProduct();
                noticeContent.Text = "Chỉnh sửa sản phẩm thành công!";
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
        
        //Xóa sản phẩm
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                command = connnect.CreateCommand();
                if (MaSP.Text == "")
                {
                    noticeContent.Text = "Bạn cần nhập mã sản phẩm muốn xóa!";
                    return;
                }
                command.CommandText = "select * from SanPham where MaSP ='" + MaSP.Text + "'";
                object CSanPham = command.ExecuteScalar();
                if (CSanPham == null)
                {
                    noticeContent.Text = "Mã sản phẩm không tồn tại!";
                    return;
                }
                command.CommandText = "delete SanPham where MaSP = '" + MaSP.Text + "'";
                command.ExecuteNonQuery();
                loadListProduct();
                MaSP.Text = "";
                TenSP.Text = "";
                DonGia.Text = "";
                SL_ConLai.Text = "";
                noticeContent.Text = "Xóa sản phẩm thành công!";
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
        //Khôi phục giao diện mặc định
        private void reset_Click(object sender, EventArgs e)
        {
            try
            {
                MaSP.Text = "";
                TenSP.Text = "";
                DonGia.Text = "";
                SL_ConLai.Text = "";
                noticeContent.Text = "";
                search.Text = "";
                strSearch = "";
                loadListProduct();
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
        //Tìm kiếm sản phẩm theo tên
        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                strSearch = search.Text.ToString();
                loadListProduct();
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
        //Chuyển qua giao diện danh sách đơn hàng
        private void order_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                detailorder ViewOrder = new detailorder(userID);
                ViewOrder.ShowDialog();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
        //Start giao diện
        private void products_Load(object sender, EventArgs e)
        {
            try 
            {
                connnect = new SqlConnection(strconn);
                connnect.Open();
                command = connnect.CreateCommand();
                command.CommandText = "select TenDT from DoiTac where MaDT = '" + userID + "'";
                adapter.SelectCommand = command;
                DataTable tablePartner = new DataTable();
                tablePartner.Clear();
                adapter.Fill(tablePartner);
                if (tablePartner.Rows.Count > 0)
                {
                    string partnerName = tablePartner.Rows[0].Field<string>(0);
                    partner.Text = partnerName;
                }
                loadListProduct();
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }

        private void detailProduct_Enter(object sender, EventArgs e)
        {

        }

     
    }
}
