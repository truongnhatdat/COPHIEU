using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;
namespace COPHIEU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static FormMain FormChinh;
        public static String servername = "DESKTOP-8CKAIU0";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String mGroup = "";

        public static String database = "CHUNGKHOAN";
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }


        }
        public static void ExeDatLenh(String strLenh, String macp, String ngay, String loaigd, int soluong,float gia)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@macp", macp);
                Sqlcmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@Ngay", ngay);
                Sqlcmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@LoaiGD", loaigd);
                Sqlcmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@soluongMB", soluong);
                Sqlcmd.Parameters.Add(p4);
                SqlParameter p5 = new SqlParameter("@giadatMB", gia);
                Sqlcmd.Parameters.Add(p5);
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Đặt thành công", "", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Đặt thất bại " + ex.Message, "", MessageBoxButtons.OK);
            }

        }
        public static void ExeThemCP(String strLenh, String macp, String ngay, String loaigd, int soluong, float gia)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@macp", macp);
                Sqlcmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@ngay", ngay);
                Sqlcmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@loaigd", loaigd);
                Sqlcmd.Parameters.Add(p3);
               // SqlParameter p6 = new SqlParameter("@LoaiGD", loaigd);
                //Sqlcmd.Parameters.Add(p6);
                SqlParameter p4 = new SqlParameter("@soluong", soluong);
                Sqlcmd.Parameters.Add(p4);
                SqlParameter p5 = new SqlParameter("@gia", gia);
                Sqlcmd.Parameters.Add(p5);
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Đặt thành công", "", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Đặt thất bại " + ex.Message, "", MessageBoxButtons.OK);
            }

        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            FormChinh = new FormMain();
            Application.Run(FormChinh);
        }
    }
}
