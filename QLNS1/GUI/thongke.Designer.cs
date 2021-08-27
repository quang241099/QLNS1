
namespace QLNS1.GUI
{
     partial class thongke
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
               this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
               ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
               this.SuspendLayout();
               // 
               // listBoxControl1
               // 
               this.listBoxControl1.Location = new System.Drawing.Point(356, 47);
               this.listBoxControl1.Name = "listBoxControl1";
               this.listBoxControl1.Size = new System.Drawing.Size(120, 95);
               this.listBoxControl1.TabIndex = 0;
               // 
               // thongke
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.listBoxControl1);
               this.Name = "thongke";
               this.Text = "thongke";
               ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
     }
}