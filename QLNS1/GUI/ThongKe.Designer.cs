
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
               DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
               DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
               this.cbxTK = new DevExpress.XtraEditors.ComboBoxEdit();
               this.dgvTK = new System.Windows.Forms.DataGridView();
               this.chartTK = new DevExpress.XtraCharts.ChartControl();
               this.btnTK = new DevExpress.XtraEditors.SimpleButton();
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               ((System.ComponentModel.ISupportInitialize)(this.cbxTK.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartTK)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
               this.SuspendLayout();
               // 
               // cbxTK
               // 
               this.cbxTK.Location = new System.Drawing.Point(214, 12);
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
               this.dgvTK.Location = new System.Drawing.Point(37, 57);
               this.dgvTK.Name = "dgvTK";
               this.dgvTK.RowHeadersWidth = 51;
               this.dgvTK.RowTemplate.Height = 24;
               this.dgvTK.Size = new System.Drawing.Size(567, 480);
               this.dgvTK.TabIndex = 1;
               // 
               // chartTK
               // 
               this.chartTK.Legend.Name = "Default Legend";
               this.chartTK.Location = new System.Drawing.Point(610, 57);
               this.chartTK.Name = "chartTK";
               series1.Name = "Series 1";
               series1.View = pieSeriesView1;
               this.chartTK.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
               this.chartTK.Size = new System.Drawing.Size(516, 480);
               this.chartTK.TabIndex = 3;
               // 
               // btnTK
               // 
               this.btnTK.Location = new System.Drawing.Point(345, 8);
               this.btnTK.Name = "btnTK";
               this.btnTK.Size = new System.Drawing.Size(94, 29);
               this.btnTK.TabIndex = 5;
               this.btnTK.Text = "Thống kê";
               this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
               // 
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(118, 12);
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
               this.Controls.Add(this.chartTK);
               this.Controls.Add(this.dgvTK);
               this.Controls.Add(this.cbxTK);
               this.Name = "ThongKe";
               this.Text = "ThongKe";
               this.Load += new System.EventHandler(this.ThongKe_Load);
               ((System.ComponentModel.ISupportInitialize)(this.cbxTK.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartTK)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private DevExpress.XtraEditors.ComboBoxEdit cbxTK;
          private System.Windows.Forms.DataGridView dgvTK;
          private DevExpress.XtraCharts.ChartControl chartTK;
          private SimpleButton btnTK;
          private LabelControl labelControl1;
     }
}