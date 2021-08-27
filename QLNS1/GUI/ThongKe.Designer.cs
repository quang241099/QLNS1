
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
               this.btnTK.Location = new System.Drawing.Point(355, 22);
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
     }
}