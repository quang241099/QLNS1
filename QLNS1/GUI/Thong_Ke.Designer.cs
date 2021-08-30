
namespace QLNS1.GUI
{
     partial class Thong_Ke
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.dgvTK = new System.Windows.Forms.DataGridView();
               this.chartTK = new DevExpress.XtraCharts.ChartControl();
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               this.cbxTK = new DevExpress.XtraEditors.ComboBoxEdit();
               this.btnTK = new DevExpress.XtraEditors.SimpleButton();
               ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartTK)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.cbxTK.Properties)).BeginInit();
               this.SuspendLayout();
               // 
               // dgvTK
               // 
               this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvTK.Location = new System.Drawing.Point(21, 93);
               this.dgvTK.Name = "dgvTK";
               this.dgvTK.RowHeadersWidth = 51;
               this.dgvTK.RowTemplate.Height = 24;
               this.dgvTK.Size = new System.Drawing.Size(563, 494);
               this.dgvTK.TabIndex = 0;
               // 
               // chartTK
               // 
               this.chartTK.Legend.Name = "Default Legend";
               this.chartTK.Location = new System.Drawing.Point(590, 93);
               this.chartTK.Name = "chartTK";
               this.chartTK.PaletteName = "Apex";
               this.chartTK.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
               this.chartTK.Size = new System.Drawing.Size(590, 494);
               this.chartTK.TabIndex = 1;
               // 
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(86, 36);
               this.labelControl1.Name = "labelControl1";
               this.labelControl1.Size = new System.Drawing.Size(90, 17);
               this.labelControl1.TabIndex = 2;
               this.labelControl1.Text = "Thống kê theo";
               // 
               // cbxTK
               // 
               this.cbxTK.Location = new System.Drawing.Point(182, 33);
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
               this.cbxTK.TabIndex = 3;
               // 
               // btnTK
               // 
               this.btnTK.Location = new System.Drawing.Point(313, 29);
               this.btnTK.Name = "btnTK";
               this.btnTK.Size = new System.Drawing.Size(94, 29);
               this.btnTK.TabIndex = 4;
               this.btnTK.Text = "Thống kê";
               this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
               // 
               // Thong_Ke
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.btnTK);
               this.Controls.Add(this.cbxTK);
               this.Controls.Add(this.labelControl1);
               this.Controls.Add(this.chartTK);
               this.Controls.Add(this.dgvTK);
               this.Name = "Thong_Ke";
               this.Size = new System.Drawing.Size(1183, 606);
               ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartTK)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.cbxTK.Properties)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dgvTK;
          private DevExpress.XtraCharts.ChartControl chartTK;
          private DevExpress.XtraEditors.LabelControl labelControl1;
          private DevExpress.XtraEditors.ComboBoxEdit cbxTK;
          private DevExpress.XtraEditors.SimpleButton btnTK;
     }
}
