namespace ppe1
{
    partial class Authentification
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lbmdp = new System.Windows.Forms.Label();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.txtBmdp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTHENTIFICATION";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(207, 134);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(59, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Identifiant :";
            // 
            // lbmdp
            // 
            this.lbmdp.AutoSize = true;
            this.lbmdp.Location = new System.Drawing.Point(207, 213);
            this.lbmdp.Name = "lbmdp";
            this.lbmdp.Size = new System.Drawing.Size(77, 13);
            this.lbmdp.TabIndex = 2;
            this.lbmdp.Text = "Mot de passe :";
            // 
            // txtBId
            // 
            this.txtBId.Location = new System.Drawing.Point(295, 131);
            this.txtBId.Name = "txtBId";
            this.txtBId.Size = new System.Drawing.Size(207, 20);
            this.txtBId.TabIndex = 3;
            // 
            // txtBmdp
            // 
            this.txtBmdp.Location = new System.Drawing.Point(295, 210);
            this.txtBmdp.Name = "txtBmdp";
            this.txtBmdp.Size = new System.Drawing.Size(207, 20);
            this.txtBmdp.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(341, 265);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtBmdp);
            this.Controls.Add(this.txtBId);
            this.Controls.Add(this.lbmdp);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbmdp;
        private System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.TextBox txtBmdp;
        private System.Windows.Forms.Button btnConnect;
    }
}