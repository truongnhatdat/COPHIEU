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

namespace COPHIEU
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;

            if (Program.KetNoi() == 0)
            {
                return;
            }
            else
            {
                // MessageBox.Show("Đăng nhập thành công", " ", MessageBoxButtons.OK);
                SqlDataReader myReader;
                String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) return;
                myReader.Read();
                Program.username = myReader.GetString(0);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }

                Program.mGroup = myReader.GetString(1);
                myReader.Close();
                Program.conn.Close();

                Program.FormChinh.sttlogin.Text = "User : " + Program.username;
                Program.FormChinh.sttgroup.Text = "Nhóm : " + Program.mGroup;
            }
        }
    }
}
