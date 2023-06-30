namespace QuanLyKhoHangGiay.FRM
{
    partial class frmDSNhapTheoNgay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ngàyNhậpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốHóaĐơnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngGiáTrịDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongKeDSNhapTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoDataSet_DSNhapTheoNgay = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSNhapTheoNgay();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.dtTimKiem = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.thongKeDSNhapTheoNgayTableAdapter = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSNhapTheoNgayTableAdapters.ThongKeDSNhapTheoNgayTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDSNhapTheoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSNhapTheoNgay)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.264462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.73553F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1131, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDS
            // 
            this.dgvDS.AutoGenerateColumns = false;
            this.dgvDS.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngàyNhậpDataGridViewTextBoxColumn,
            this.sốHóaĐơnDataGridViewTextBoxColumn,
            this.tổngHàngDataGridViewTextBoxColumn,
            this.tổngGiáTrịDataGridViewTextBoxColumn});
            this.dgvDS.DataSource = this.thongKeDSNhapTheoNgayBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.EnableHeadersVisualStyles = false;
            this.dgvDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDS.Location = new System.Drawing.Point(4, 53);
            this.dgvDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDS.Name = "dgvDS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.Size = new System.Drawing.Size(1123, 539);
            this.dgvDS.TabIndex = 2;
            // 
            // ngàyNhậpDataGridViewTextBoxColumn
            // 
            this.ngàyNhậpDataGridViewTextBoxColumn.DataPropertyName = "Ngày nhập";
            this.ngàyNhậpDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngàyNhậpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngàyNhậpDataGridViewTextBoxColumn.Name = "ngàyNhậpDataGridViewTextBoxColumn";
            this.ngàyNhậpDataGridViewTextBoxColumn.Width = 200;
            // 
            // sốHóaĐơnDataGridViewTextBoxColumn
            // 
            this.sốHóaĐơnDataGridViewTextBoxColumn.DataPropertyName = "Số hóa đơn";
            this.sốHóaĐơnDataGridViewTextBoxColumn.HeaderText = "Số hóa đơn";
            this.sốHóaĐơnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sốHóaĐơnDataGridViewTextBoxColumn.Name = "sốHóaĐơnDataGridViewTextBoxColumn";
            this.sốHóaĐơnDataGridViewTextBoxColumn.Width = 200;
            // 
            // tổngHàngDataGridViewTextBoxColumn
            // 
            this.tổngHàngDataGridViewTextBoxColumn.DataPropertyName = "Tổng hàng";
            this.tổngHàngDataGridViewTextBoxColumn.HeaderText = "Tổng hàng";
            this.tổngHàngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tổngHàngDataGridViewTextBoxColumn.Name = "tổngHàngDataGridViewTextBoxColumn";
            this.tổngHàngDataGridViewTextBoxColumn.Width = 200;
            // 
            // tổngGiáTrịDataGridViewTextBoxColumn
            // 
            this.tổngGiáTrịDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tổngGiáTrịDataGridViewTextBoxColumn.DataPropertyName = "Tổng giá trị";
            this.tổngGiáTrịDataGridViewTextBoxColumn.HeaderText = "Tổng giá trị";
            this.tổngGiáTrịDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tổngGiáTrịDataGridViewTextBoxColumn.Name = "tổngGiáTrịDataGridViewTextBoxColumn";
            // 
            // thongKeDSNhapTheoNgayBindingSource
            // 
            this.thongKeDSNhapTheoNgayBindingSource.DataMember = "ThongKeDSNhapTheoNgay";
            this.thongKeDSNhapTheoNgayBindingSource.DataSource = this.quanLyKhoDataSet_DSNhapTheoNgay;
            // 
            // quanLyKhoDataSet_DSNhapTheoNgay
            // 
            this.quanLyKhoDataSet_DSNhapTheoNgay.DataSetName = "QuanLyKhoDataSet_DSNhapTheoNgay";
            this.quanLyKhoDataSet_DSNhapTheoNgay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.17102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.82898F));
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtTimKiem, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1123, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Location = new System.Drawing.Point(4, 4);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(196, 33);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtTimKiem
            // 
            // 
            // 
            // 
            this.dtTimKiem.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTimKiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimKiem.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTimKiem.ButtonDropDown.Visible = true;
            this.dtTimKiem.IsPopupCalendarOpen = false;
            this.dtTimKiem.Location = new System.Drawing.Point(208, 4);
            this.dtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // 
            // 
            this.dtTimKiem.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTimKiem.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimKiem.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTimKiem.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimKiem.MonthCalendar.DisplayMonth = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dtTimKiem.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtTimKiem.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTimKiem.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTimKiem.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimKiem.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTimKiem.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimKiem.MonthCalendar.TodayButtonVisible = true;
            this.dtTimKiem.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtTimKiem.Name = "dtTimKiem";
            this.dtTimKiem.Size = new System.Drawing.Size(475, 22);
            this.dtTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTimKiem.TabIndex = 6;
            // 
            // thongKeDSNhapTheoNgayTableAdapter
            // 
            this.thongKeDSNhapTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // frmDSNhapTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDSNhapTheoNgay";
            this.Text = "frmDSNhapTheoNgay";
            this.Load += new System.EventHandler(this.frmDSNhapTheoNgay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDSNhapTheoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSNhapTheoNgay)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private QuanLyKhoDataSet_DSNhapTheoNgay quanLyKhoDataSet_DSNhapTheoNgay;
        private System.Windows.Forms.BindingSource thongKeDSNhapTheoNgayBindingSource;
        private QuanLyKhoDataSet_DSNhapTheoNgayTableAdapters.ThongKeDSNhapTheoNgayTableAdapter thongKeDSNhapTheoNgayTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyNhậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốHóaĐơnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngGiáTrịDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTimKiem;
    }
}