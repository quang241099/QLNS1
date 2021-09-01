
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace QLNS1.GUI
{
     partial class ThongKe
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
               this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
               this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
               this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
               this.btnTK = new DevExpress.XtraEditors.SimpleButton();
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
               this.SuspendLayout();
               // 
               // comboBoxEdit1
               // 
               this.comboBoxEdit1.Location = new System.Drawing.Point(214, 26);
               this.comboBoxEdit1.Name = "comboBoxEdit1";
               this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.comboBoxEdit1.Size = new System.Drawing.Size(125, 22);
               this.comboBoxEdit1.TabIndex = 0;
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
               this.dataGridView1.Location = new System.Drawing.Point(37, 95);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowHeadersWidth = 51;
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.Size = new System.Drawing.Size(514, 442);
               this.dataGridView1.TabIndex = 1;
               // 
               // chartControl1
               // 
               this.chartControl1.Legend.Name = "Default Legend";
               this.chartControl1.Location = new System.Drawing.Point(559, 95);
               this.chartControl1.Name = "chartControl1";
               this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
               this.chartControl1.Size = new System.Drawing.Size(569, 216);
               this.chartControl1.TabIndex = 2;
               // 
               // chartControl2
               // 
               this.chartControl2.Legend.Name = "Default Legend";
               this.chartControl2.Location = new System.Drawing.Point(557, 317);
               this.chartControl2.Name = "chartControl2";
               this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
               this.chartControl2.Size = new System.Drawing.Size(569, 220);
               this.chartControl2.TabIndex = 3;
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
               this.layoutControl1.Location = new System.Drawing.Point(559, 9);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.Root = this.Root;
               this.layoutControl1.Size = new System.Drawing.Size(564, 89);
               this.layoutControl1.TabIndex = 4;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // searchLookUpEdit1
               // 
               this.searchLookUpEdit1.Location = new System.Drawing.Point(123, 12);
               this.searchLookUpEdit1.Name = "searchLookUpEdit1";
               this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
               this.searchLookUpEdit1.Size = new System.Drawing.Size(429, 22);
               this.searchLookUpEdit1.StyleController = this.layoutControl1;
               this.searchLookUpEdit1.TabIndex = 4;
               // 
               // searchLookUpEdit1View
               // 
               this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
               this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
               this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
               this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(564, 89);
               this.Root.TextVisible = false;
               // 
               // layoutControlItem1
               // 
               this.layoutControlItem1.Control = this.searchLookUpEdit1;
               this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem1.Name = "layoutControlItem1";
               this.layoutControlItem1.Size = new System.Drawing.Size(544, 26);
               this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 16);
               // 
               // emptySpaceItem1
               // 
               this.emptySpaceItem1.AllowHotTrack = false;
               this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
               this.emptySpaceItem1.Name = "emptySpaceItem1";
               this.emptySpaceItem1.Size = new System.Drawing.Size(544, 43);
               this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
               // 
               // btnTK
               // 
               this.btnTK.Location = new System.Drawing.Point(345, 22);
               this.btnTK.Name = "btnTK";
               this.btnTK.Size = new System.Drawing.Size(94, 29);
               this.btnTK.TabIndex = 5;
               this.btnTK.Text = "Thống kê";
               // 
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(118, 29);
               this.labelControl1.Name = "labelControl1";
               this.labelControl1.Size = new System.Drawing.Size(90, 17);
               this.labelControl1.TabIndex = 6;
               this.labelControl1.Text = "Thống kê theo";
               // 
               // Column1
               // 
               this.Column1.HeaderText = "Mã nhân viên";
               this.Column1.MinimumWidth = 6;
               this.Column1.Name = "Column1";
               this.Column1.Width = 125;
               // 
               // Column2
               // 
               this.Column2.HeaderText = "Mã HTTD";
               this.Column2.MinimumWidth = 6;
               this.Column2.Name = "Column2";
               this.Column2.Width = 125;
               // 
               // Column3
               // 
               this.Column3.HeaderText = "Mã chức vụ";
               this.Column3.MinimumWidth = 6;
               this.Column3.Name = "Column3";
               this.Column3.Width = 125;
               // 
               // Column4
               // 
               this.Column4.HeaderText = "Mã phòng ban";
               this.Column4.MinimumWidth = 6;
               this.Column4.Name = "Column4";
               this.Column4.Width = 125;
               // 
               // Column5
               // 
               this.Column5.HeaderText = "Nơi làm việc";
               this.Column5.MinimumWidth = 6;
               this.Column5.Name = "Column5";
               this.Column5.Width = 125;
               // 
               // Column6
               // 
               this.Column6.HeaderText = "Họ tên";
               this.Column6.MinimumWidth = 6;
               this.Column6.Name = "Column6";
               this.Column6.Width = 125;
               // 
               // Column7
               // 
               this.Column7.HeaderText = "Ngày sinh";
               this.Column7.MinimumWidth = 6;
               this.Column7.Name = "Column7";
               this.Column7.Width = 125;
               // 
               // Column8
               // 
               this.Column8.HeaderText = "Quê quán";
               this.Column8.MinimumWidth = 6;
               this.Column8.Name = "Column8";
               this.Column8.Width = 125;
               // 
               // Column9
               // 
               this.Column9.HeaderText = "Giới tính";
               this.Column9.MinimumWidth = 6;
               this.Column9.Name = "Column9";
               this.Column9.Width = 125;
               // 
               // Column10
               // 
               this.Column10.HeaderText = "Số CMND";
               this.Column10.MinimumWidth = 6;
               this.Column10.Name = "Column10";
               this.Column10.Width = 125;
               // 
               // Column11
               // 
               this.Column11.HeaderText = "Trình độ";
               this.Column11.MinimumWidth = 6;
               this.Column11.Name = "Column11";
               this.Column11.Width = 125;
               // 
               // Column12
               // 
               this.Column12.HeaderText = "SĐT";
               this.Column12.MinimumWidth = 6;
               this.Column12.Name = "Column12";
               this.Column12.Width = 125;
               // 
               // Column13
               // 
               this.Column13.HeaderText = "Email";
               this.Column13.MinimumWidth = 6;
               this.Column13.Name = "Column13";
               this.Column13.Width = 125;
               // 
               // Column14
               // 
               this.Column14.HeaderText = "Nơi ở";
               this.Column14.MinimumWidth = 6;
               this.Column14.Name = "Column14";
               this.Column14.Width = 125;
               // 
               // Column15
               // 
               this.Column15.HeaderText = "Nơi sinh";
               this.Column15.MinimumWidth = 6;
               this.Column15.Name = "Column15";
               this.Column15.Width = 125;
               // 
               // ThongKe
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1138, 549);
               this.Controls.Add(this.labelControl1);
               this.Controls.Add(this.btnTK);
               this.Controls.Add(this.layoutControl1);
               this.Controls.Add(this.chartControl2);
               this.Controls.Add(this.chartControl1);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.comboBoxEdit1);
               this.Name = "ThongKe";
               this.Text = "ThongKe";
               this.Load += new System.EventHandler(this.ThongKe_Load);
               ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
          private System.Windows.Forms.DataGridView dataGridView1;
          private DevExpress.XtraCharts.ChartControl chartControl1;
          private DevExpress.XtraCharts.ChartControl chartControl2;
          private LayoutControl layoutControl1;
          private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
          private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
          private LayoutControlGroup Root;
          private LayoutControlItem layoutControlItem1;
          private EmptySpaceItem emptySpaceItem1;
          private SimpleButton btnTK;
          private LabelControl labelControl1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
     }
}