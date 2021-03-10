namespace ppe1
{
    partial class FrmPartenariat
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
            this.grpBPartenariat = new System.Windows.Forms.GroupBox();
            this.grpBPartExi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpBPartExi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBPartenariat
            // 
            this.grpBPartenariat.Location = new System.Drawing.Point(12, 12);
            this.grpBPartenariat.Name = "grpBPartenariat";
            this.grpBPartenariat.Size = new System.Drawing.Size(391, 256);
            this.grpBPartenariat.TabIndex = 0;
            this.grpBPartenariat.TabStop = false;
            this.grpBPartenariat.Text = "Nouveau Partenariat";
            // 
            // grpBPartExi
            // 
            this.grpBPartExi.Controls.Add(this.dataGridView1);
            this.grpBPartExi.Location = new System.Drawing.Point(441, 12);
            this.grpBPartExi.Name = "grpBPartExi";
            this.grpBPartExi.Size = new System.Drawing.Size(321, 256);
            this.grpBPartExi.TabIndex = 1;
            this.grpBPartExi.TabStop = false;
            this.grpBPartExi.Text = "Partenariat existant";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmPartenariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBPartExi);
            this.Controls.Add(this.grpBPartenariat);
            this.Name = "FrmPartenariat";
            this.Text = "FrmPartenariat";
            this.grpBPartExi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBPartenariat;
        private System.Windows.Forms.GroupBox grpBPartExi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}