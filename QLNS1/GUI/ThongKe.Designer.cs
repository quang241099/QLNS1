
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
               this.cbxTK = new DevExpress.XtraEditors.ComboBoxEdit();
               this.dgvTK = new System.Windows.Forms.DataGridView();
               this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
               this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
               this.btnTK = new DevExpress.XtraEditors.SimpleButton();
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               ((System.ComponentModel.ISupportInitialize)(this.cbxTK.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
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
               // cbxTK
               // 
               this.cbxTK.Location = new System.Drawing.Point(214, 26);
               this.cbxTK.Name = "cbxTK";
               this.cbxTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.cbxTK.Properties.Items.AddRange(new object[] {
            "Bảo hiểm",
            "Chức vụ",
            "Phòng ban",
            "Trình độ",
            "Khen thưởng kỉ luật"});
               this.cbxTK.Size = new System.Drawing.Size(125, 22);
               this.cbxTK.TabIndex = 0;
               // 
               // dgvTK
               // 
               this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvTK.Location = new System.Drawing.Point(37, 95);
               this.dgvTK.Name = "dgvTK";
               this.dgvTK.RowHeadersWidth = 51;
               this.dgvTK.RowTemplate.Height = 24;
               this.dgvTK.Size = new System.Drawing.Size(514, 442);
               this.dgvTK.TabIndex = 1;
               // 
               // chartControl2
               // 
               this.chartControl2.Legend.Name = "Default Legend";
               this.chartControl2.Location = new System.Drawing.Point(557, 95);
               this.chartControl2.Name = "chartControl2";
               this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
               this.chartControl2.Size = new System.Drawing.Size(569, 442);
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
               this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
               // 
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(118, 29);
               this.labelControl1.Name = "labelControl1";
               this.labelControl1.Size = new System.Drawing.Size(90, 17);
               this.labelControl1.TabIndex = 6;
               this.labelControl1.Text = "Thống kê theo";
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
               this.Controls.Add(this.dgvTK);
               this.Controls.Add(this.cbxTK);
               this.Name = "ThongKe";
               this.Text = "ThongKe";
               this.Load += new System.EventHandler(this.ThongKe_Load);
               ((System.ComponentModel.ISupportInitialize)(this.cbxTK.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
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

          private DevExpress.XtraEditors.ComboBoxEdit cbxTK;
          private System.Windows.Forms.DataGridView dgvTK;
          private DevExpress.XtraCharts.ChartControl chartControl2;
          private LayoutControl layoutControl1;
          private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
          private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
          private LayoutControlGroup Root;
          private LayoutControlItem layoutControlItem1;
          private EmptySpaceItem emptySpaceItem1;
          private SimpleButton btnTK;
          private LabelControl labelControl1;
     }
}