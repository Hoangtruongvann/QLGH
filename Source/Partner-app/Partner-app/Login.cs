using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Partner_app
{
    public partial class Login : Form
    {
        SqlConnection connnect;
        SqlCommand command;
        string strconn = "data source=DESKTOP-S7P1JHC;initial catalog=QLGH;trusted_connection=true";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablePartner = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try 
            {
                connnect = new SqlConnection(strconn);
                connnect.Open();
                command = connnect.CreateCommand();
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }

        private void sigin_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == "" || pass.Text == "")
                {
                    notice.Text = "Bạn cần nhập đầy đủ thông tin để đăng nhập!";
                    return;
                }
                command.CommandText = "select * from Account where Username ='" + username.Text + "' and MatKhau = '" + pass.Text + "'";
                object account = command.ExecuteScalar();
                if (account == null)
                {
                    notice.Text = "Thông tin tài khoản hoặc mật khẩu chưa chính xác!";
                    return;
                }
                else
                {
                    command.CommandText = "select DT.MaDT from DoiTac DT,Account A where DT.Username = A.Username and A.Username = '" + username.Text + "'";
                    adapter.SelectCommand = command;
                    tablePartner.Clear();
                    adapter.Fill(tablePartner);
                    if (tablePartner.Rows.Count > 0)
                    {
                        this.Hide();
                        products ViewProduct = new products(tablePartner.Rows[0].Field<string>(0));
                        ViewProduct.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("error: " + exp.Message);
            }
        }
    }
}
