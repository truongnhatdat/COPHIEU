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
    public partial class FormXemCP : Form
    {
        public delegate void NewHome();
        public event NewHome OnNewHome;
        public FormXemCP()
        {
            InitializeComponent();
        }

        //Ham load data
        void LoadData()
        {
            String strlenh = "SP_LoadCoPhieu";
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable(strlenh, Program.connstr);
            dgvcp.DataSource = dt;
            dgvcp.DataSource = dt;
        }
        
        private void FormXemCP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.LENHDAT' table. You can move, or remove it, as needed.
            this.lENHDATTableAdapter.Fill(this.cHUNGKHOANDataSet.LENHDAT);

            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.SP_LoadMaCP' table. You can move, or remove it, as needed.
            this.sP_LoadMaCPTableAdapter.Fill(this.cHUNGKHOANDataSet.SP_LoadMaCP);
            //load data vao datagrid
            LoadData();
            btnDat.Enabled = true;
            btnXacnhan.Enabled = btnHuy.Enabled = groupControl3.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String Lenh = "exec SP_LoadCP '" + cmbmacp.Text + "'";
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable(Lenh, Program.connstr);
            dgvcp.DataSource = dt;
        }

        private void btnDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dtngaydat.Enabled = false;
            btnXacnhan.Enabled = btnHuy.Enabled = groupControl3.Enabled = true;
            btnDat.Enabled=btnLoad.Enabled = btnThoat.Enabled = false;
        }

        private void btnXacnhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtmacp.Text == "" || txtsoluong.Text == "" || txtgiadat.Text == "" || dtngaydat.Text == "" || cmbloaigd.Text == "")
            {
                MessageBox.Show("Mời bạn điền đầy đủ thông tin.", "", MessageBoxButtons.OK);
                return;
            }
            //try
            {
                String Lenh = "SP_KHOPLENH_LO";
                Program.ExeDatLenh(Lenh, txtmacp.Text, dtngaydat.Text, cmbloaigd.Text, Int32.Parse(txtsoluong.Text), float.Parse(txtgiadat.Text));
                Program.conn.Close();
                SqlDataReader Reader;
                String strtongkhop = "exec SP_TONGSOLUONGKHOP";
                Reader = Program.ExecSqlDataReader(strtongkhop);
                if (Reader == null) return;
                Reader.Read();
                if (Reader.GetString(0) == null) return;
                String tong = Reader.GetString(0);
                txttongkhop.Text = tong;
                Reader.Close();
                Program.conn.Close();
                Program.conn.Close();
                btnXacnhan.Enabled = btnHuy.Enabled = groupControl3.Enabled = false;
                btnDat.Enabled=btnLoad.Enabled = btnThoat.Enabled = true;
            }
           // catch (Exception)
            {

            }
            
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl3.Enabled = btnXacnhan.Enabled = btnHuy.Enabled = false;
            btnDat.Enabled = btnLoad.Enabled = btnThoat.Enabled = true;
        }

        private void btnbangkhop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Banggiatructuyen f = new Banggiatructuyen();
            f.Show();
        }
    }
}
