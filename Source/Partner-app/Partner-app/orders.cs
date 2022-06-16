using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Threading;

namespace Partner_app
{
    public partial class detailorder : Form
    {
        private string userID;
        SqlConnection connnect;
        SqlCommand command;
        string strconn = "data source=DESKTOP-S7P1JHC;initial catalog=QLGH;trusted_connection=true";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableOrders = new DataTable();
        //Tải lên danh sách đơn hàng
        void loadListOrders()
        {
            try
            {
                command = connnect.CreateCommand();
                command.CommandText = "select DH.MaDH as N'Mã', DH.MaKH as N'Mã khách hàng', DH.DiaChi_GH as N'Địa chỉ giao', DH.PhiVanChuyen as N'Phí ship', DH.ThanhTien as N'Thành tiền', DH.HTThanhToan as N'Hình thức thanh toán',DH.TinhTrang as N'Tình trạng', DH.MaCN as N'Mã Chi Nhánh', DH.MaTX as N'Mã tài xế' from DonHang DH, ChiNhanh CN where CN.MaCN = DH.MaCN and CN.MaDT ='" + userID + "'"; 
                adapter.SelectCommand = command;
                tableOrders.Clear();
                adapter.Fill(tableOrders);
                odgv.DataSource = tableOrders;
                odgv.Columns[1].Width = 140;
                odgv.Columns[2].Width = 359;
                odgv.Columns[3].Width = 120;
                odgv.Columns[4].Width = 120;
                odgv.Columns[5].Width = 175;
                odgv.Columns[6].Width = 115;
                odgv.Columns[7].Width = 140;
                command.CommandType = CommandType.Text;
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
        //Khởi tạo danh sách đơn hàng
        public detailorder(string ID)
        {
            userID = ID;
            InitializeComponent();
        }
        //Chuyển qua giao diện sản phẩm
        private void product_Click(object sender, EventArgs e)
        {
            Hide();
            products ViewProduct = new products(userID);
            ViewProduct.ShowDialog();
            this.Close();
        }
        //Tính doanh thu
        private void revenueBtn_Click(object sender, EventArgs e)
        {
            try
            { 
            command.CommandText = "sp_ThongKe";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@MADT", userID));
            command.Parameters.Add("@DoanhThu", SqlDbType.Int).Direction = ParameterDirection.Output;
            adapter.SelectCommand = command;
            tableOrders.Clear();
            adapter.Fill(tableOrders);
            int DT = Convert.ToInt32(command.Parameters["@DoanhThu"].Value);
            revenue.Text = DT.ToString();
            odgv.DataSource = tableOrders;
            odgv.Columns[1].Width = 140;
            odgv.Columns[2].Width = 359;
            odgv.Columns[3].Width = 120;
            odgv.Columns[4].Width = 120;
            odgv.Columns[5].Width = 175;
            odgv.Columns[6].Width = 115;
            odgv.Columns[7].Width = 140;
            command.CommandType = CommandType.Text;
        }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
}
        
        //Coi chi tiết đơn hàng
        private void odgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = odgv.CurrentRow.Index;
            MaDH.Text = odgv.Rows[i].Cells[0].Value.ToString();
            MaKH.Text = odgv.Rows[i].Cells[1].Value.ToString();
            DiaChiGH.Text = odgv.Rows[i].Cells[2].Value.ToString();
            PhiVanChuyen.Text = odgv.Rows[i].Cells[3].Value.ToString();
            TongTien.Text = odgv.Rows[i].Cells[4].Value.ToString();
            HTTT.Text = odgv.Rows[i].Cells[5].Value.ToString();
            TinhTrangDH.Text = odgv.Rows[i].Cells[6].Value.ToString();
            MaCN.Text = odgv.Rows[i].Cells[7].Value.ToString();
            MaTX.Text = odgv.Rows[i].Cells[8].Value.ToString();
            //Lấy thông tin khách hàng
            try
            {
                DataTable tableCustomer = new DataTable();
                command.CommandText = "select MaKH,TenKH,SDT,Email as Tong from KhachHang where MaKH = '" + odgv.Rows[i].Cells[1].Value.ToString() + "'";
                adapter.SelectCommand = command;
                tableCustomer.Clear();
                adapter.Fill(tableCustomer);
                if (tableCustomer.Rows.Count > 0)
                {
                    TenKH.Text = tableCustomer.Rows[0].Field<string>(1);
                    DTKH.Text = tableCustomer.Rows[0].Field<string>(2);
                    EmailKH.Text = tableCustomer.Rows[0].Field<string>(3);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }

            //Lấy thông tin tài xế
            try
            {
                DataTable tableShipper = new DataTable();
                command.CommandText = "select MaTX,TenTX,SDT,EMail as Tong from TaiXe where MaTX = '" + odgv.Rows[i].Cells[8].Value.ToString() + "'";
                adapter.SelectCommand = command;
                tableShipper.Clear();
                adapter.Fill(tableShipper);
                if (tableShipper.Rows.Count > 0)
                {
                    TenTX.Text = tableShipper.Rows[0].Field<string>(1);
                    DTTX.Text = tableShipper.Rows[0].Field<string>(2);
                    EmailTX.Text = tableShipper.Rows[0].Field<string>(3);

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
            //Lấy thông tin sản phẩm
            try
            {
                DataTable tableDetail = new DataTable();
                command.CommandText = "select SP.MaSP as N'Mã', SP.TenSP as N'Tên sản phẩm', SP.DonGia as N'Đơn giá', CT.SoLuong as N'Số Lượng' from CTDonHang CT, SanPham SP where CT.MaDH = '" + odgv.Rows[i].Cells[0].Value.ToString() + "' and CT.MaSP = SP.MaSP";
                adapter.SelectCommand = command;
                tableDetail.Clear();
                adapter.Fill(tableDetail);
                opdgv.DataSource = tableDetail;
                opdgv.Columns[1].Width = 400;
                opdgv.Columns[2].Width = 120;
                opdgv.Columns[3].Width = 80;
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
        //Cập nhật tình trạng đơn hàng
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaDH.Text == "")
                {
                    notice.Text = "Chọn đơn hàng trước khi cập nhật!";
                    return;
                }
                if (TinhTrangDH.Text == "")
                {
                    notice.Text = "Bạn chưa nhập trạng thái cần cập nhật!";
                    return;
                }
                command.CommandText = "sp_partner_updateOrder_lostUpdate";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@MADH", MaDH.Text));
                command.Parameters.Add(new SqlParameter("@TinhTrang", TinhTrangDH.Text));
                command.ExecuteNonQuery();
                command.CommandType = CommandType.Text;
                loadListOrders();
                notice.Text = "Cập nhật thành công!";

            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
        
        //Start 
        private void orders_Load(object sender, EventArgs e)
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
                connnect = new SqlConnection(strconn);
                connnect.Open();
       
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }

    }
}
