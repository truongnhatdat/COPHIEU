namespace COPHIEU
{
    partial class FormXemCP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnDat = new DevExpress.XtraBars.BarButtonItem();
            this.btnXacnhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnbangkhop = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnquaylai = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbmacp = new System.Windows.Forms.ComboBox();
            this.sPLoadMaCPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUNGKHOANDataSet = new COPHIEU.CHUNGKHOANDataSet();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvcp = new System.Windows.Forms.DataGridView();
            this.sP_LoadMaCPTableAdapter = new COPHIEU.CHUNGKHOANDataSetTableAdapters.SP_LoadMaCPTableAdapter();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txttongkhop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgiadat = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.cmbloaigd = new System.Windows.Forms.ComboBox();
            this.dtngaydat = new System.Windows.Forms.DateTimePicker();
            this.txtmacp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lENHDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lENHDATTableAdapter = new COPHIEU.CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPLoadMaCPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDat,
            this.btnXacnhan,
            this.btnHuy,
            this.btnLoad,
            this.btnThoat,
            this.btnbangkhop,
            this.btnquaylai});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXacnhan),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnbangkhop)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnDat
            // 
            this.btnDat.Caption = "Đặt CP";
            this.btnDat.Id = 0;
            this.btnDat.Name = "btnDat";
            this.btnDat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDat_ItemClick);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Caption = "Xác nhận";
            this.btnXacnhan.Id = 1;
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXacnhan_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 2;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "ReadLoad";
            this.btnLoad.Id = 3;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnbangkhop
            // 
            this.btnbangkhop.Caption = "Bảng Khớp";
            this.btnbangkhop.Id = 5;
            this.btnbangkhop.Name = "btnbangkhop";
            this.btnbangkhop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnbangkhop_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1073, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 726);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1073, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 675);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1073, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 675);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Caption = "Quay Lại";
            this.btnquaylai.Id = 6;
            this.btnquaylai.Name = "btnquaylai";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbmacp);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1073, 81);
            this.groupControl1.TabIndex = 4;
            // 
            // cmbmacp
            // 
            this.cmbmacp.DataSource = this.sPLoadMaCPBindingSource;
            this.cmbmacp.DisplayMember = "MACP";
            this.cmbmacp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmacp.FormattingEnabled = true;
            this.cmbmacp.Location = new System.Drawing.Point(355, 37);
            this.cmbmacp.Name = "cmbmacp";
            this.cmbmacp.Size = new System.Drawing.Size(267, 27);
            this.cmbmacp.TabIndex = 3;
            this.cmbmacp.ValueMember = "MACP";
            // 
            // sPLoadMaCPBindingSource
            // 
            this.sPLoadMaCPBindingSource.DataMember = "SP_LoadMaCP";
            this.sPLoadMaCPBindingSource.DataSource = this.cHUNGKHOANDataSet;
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(653, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvcp);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 132);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1073, 247);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "SÀN CỔ PHIẾU";
            // 
            // dgvcp
            // 
            this.dgvcp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcp.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvcp.Location = new System.Drawing.Point(2, 20);
            this.dgvcp.Name = "dgvcp";
            this.dgvcp.Size = new System.Drawing.Size(1069, 227);
            this.dgvcp.TabIndex = 0;
            // 
            // sP_LoadMaCPTableAdapter
            // 
            this.sP_LoadMaCPTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txttongkhop);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.txtgiadat);
            this.groupControl3.Controls.Add(this.txtsoluong);
            this.groupControl3.Controls.Add(this.cmbloaigd);
            this.groupControl3.Controls.Add(this.dtngaydat);
            this.groupControl3.Controls.Add(this.txtmacp);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 379);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1073, 347);
            this.groupControl3.TabIndex = 15;
            this.groupControl3.Text = "groupControl3";
            // 
            // txttongkhop
            // 
            this.txttongkhop.Enabled = false;
            this.txttongkhop.Location = new System.Drawing.Point(316, 117);
            this.txttongkhop.Name = "txttongkhop";
            this.txttongkhop.Size = new System.Drawing.Size(200, 21);
            this.txttongkhop.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tổng khớp";
            // 
            // txtgiadat
            // 
            this.txtgiadat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiadat.Location = new System.Drawing.Point(663, 119);
            this.txtgiadat.Name = "txtgiadat";
            this.txtgiadat.Size = new System.Drawing.Size(200, 26);
            this.txtgiadat.TabIndex = 29;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(663, 73);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(200, 26);
            this.txtsoluong.TabIndex = 28;
            // 
            // cmbloaigd
            // 
            this.cmbloaigd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloaigd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbloaigd.FormattingEnabled = true;
            this.cmbloaigd.Items.AddRange(new object[] {
            "M",
            "B"});
            this.cmbloaigd.Location = new System.Drawing.Point(663, 37);
            this.cmbloaigd.Name = "cmbloaigd";
            this.cmbloaigd.Size = new System.Drawing.Size(200, 27);
            this.cmbloaigd.TabIndex = 27;
            // 
            // dtngaydat
            // 
            this.dtngaydat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaydat.Location = new System.Drawing.Point(316, 75);
            this.dtngaydat.Name = "dtngaydat";
            this.dtngaydat.Size = new System.Drawing.Size(200, 26);
            this.dtngaydat.TabIndex = 26;
            // 
            // txtmacp
            // 
            this.txtmacp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacp.Location = new System.Drawing.Point(316, 38);
            this.txtmacp.Name = "txtmacp";
            this.txtmacp.Size = new System.Drawing.Size(200, 26);
            this.txtmacp.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Giá Đặt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(558, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Loại GD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày Đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã CP";
            // 
            // lENHDATBindingSource
            // 
            this.lENHDATBindingSource.DataMember = "LENHDAT";
            this.lENHDATBindingSource.DataSource = this.cHUNGKHOANDataSet;
            // 
            // lENHDATTableAdapter
            // 
            this.lENHDATTableAdapter.ClearBeforeFill = true;
            // 
            // FormXemCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 749);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormXemCP";
            this.Text = "FormXemCP";
            this.Load += new System.EventHandler(this.FormXemCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPLoadMaCPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbmacp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvcp;
        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
        private System.Windows.Forms.BindingSource sPLoadMaCPBindingSource;
        private CHUNGKHOANDataSetTableAdapters.SP_LoadMaCPTableAdapter sP_LoadMaCPTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnDat;
        private DevExpress.XtraBars.BarButtonItem btnXacnhan;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnbangkhop;
        private DevExpress.XtraBars.BarButtonItem btnquaylai;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TextBox txtgiadat;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ComboBox cmbloaigd;
        private System.Windows.Forms.DateTimePicker dtngaydat;
        private System.Windows.Forms.TextBox txtmacp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource lENHDATBindingSource;
        private CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter lENHDATTableAdapter;
        private System.Windows.Forms.TextBox txttongkhop;
        private System.Windows.Forms.Label label7;
    }
}