using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COPHIEU
{
    public partial class Banggiatructuyen : Form
    {
        public delegate void NewHome();
        public event NewHome OnNewHome;
        public Banggiatructuyen()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(Program.connstr);
            SqlDependency.Start(Program.connstr);
        }
        public void Banggiatructuyen_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                NewHome dd = new NewHome(Banggiatructuyen_OnNewHome);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();

        }
        void LoadData()
        {
           // try
            {
                DataTable dt = new DataTable();
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }
                String strlenh = "SP_BANGGIATRUCTUYEN";
                SqlCommand cmd = new SqlCommand(strlenh, Program.conn);
                cmd.Notification = null;

                SqlDependency de = new SqlDependency(cmd);
                de.OnChange += new OnChangeEventHandler(de_OnChange);

                dt.Load(cmd.ExecuteReader());
                dtgdumua.DataSource = dt;
            }
           // catch(Exception ex)
            {

            }
            

        }
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Banggiatructuyen_Load(object sender, EventArgs e)
        {
            //dtgdumua.Show();
            //panelControl1.Show();
            OnNewHome += new NewHome(Banggiatructuyen_OnNewHome);//tab
            
            //load data vao datagrid
            LoadData();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            String strLenh = "SP_DELETE";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strLenh, Program.conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa", "", MessageBoxButtons.OK);
                return;
            }
            catch(Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Xóa thất bại " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }
}
