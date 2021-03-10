namespace ppe1
{
    partial class FrmAssociation
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
            this.grpBAssos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbMission = new System.Windows.Forms.ComboBox();
            this.txtBResp = new System.Windows.Forms.TextBox();
            this.txtBNumA = new System.Windows.Forms.TextBox();
            this.lblMission = new System.Windows.Forms.Label();
            this.txtNomA = new System.Windows.Forms.TextBox();
            this.lblNumA = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.lblNomA = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.Btn_ajout = new System.Windows.Forms.Button();
            this.grpBAssos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBAssos
            // 
            this.grpBAssos.Controls.Add(this.Btn_ajout);
            this.grpBAssos.Controls.Add(this.btn_mod);
            this.grpBAssos.Controls.Add(this.btn_suppr);
            this.grpBAssos.Controls.Add(this.cbMission);
            this.grpBAssos.Controls.Add(this.txtBResp);
            this.grpBAssos.Controls.Add(this.txtBNumA);
            this.grpBAssos.Controls.Add(this.lblMission);
            this.grpBAssos.Controls.Add(this.txtNomA);
            this.grpBAssos.Controls.Add(this.lblNumA);
            this.grpBAssos.Controls.Add(this.lblResp);
            this.grpBAssos.Controls.Add(this.lblNomA);
            this.grpBAssos.Location = new System.Drawing.Point(23, 25);
            this.grpBAssos.Name = "grpBAssos";
            this.grpBAssos.Size = new System.Drawing.Size(323, 302);
            this.grpBAssos.TabIndex = 0;
            this.grpBAssos.TabStop = false;
            this.grpBAssos.Text = "Association";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 263);
            this.dataGridView1.TabIndex = 5;
            // 
            // cbMission
            // 
            this.cbMission.FormattingEnabled = true;
            this.cbMission.Location = new System.Drawing.Point(147, 115);
            this.cbMission.Name = "cbMission";
            this.cbMission.Size = new System.Drawing.Size(121, 21);
            this.cbMission.TabIndex = 1;
            // 
            // txtBResp
            // 
            this.txtBResp.Location = new System.Drawing.Point(147, 83);
            this.txtBResp.Name = "txtBResp";
            this.txtBResp.Size = new System.Drawing.Size(100, 20);
            this.txtBResp.TabIndex = 3;
            // 
            // txtBNumA
            // 
            this.txtBNumA.Location = new System.Drawing.Point(147, 30);
            this.txtBNumA.Name = "txtBNumA";
            this.txtBNumA.Size = new System.Drawing.Size(19, 20);
            this.txtBNumA.TabIndex = 4;
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(6, 118);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(48, 13);
            this.lblMission.TabIndex = 4;
            this.lblMission.Text = "Mission :";
            // 
            // txtNomA
            // 
            this.txtNomA.Location = new System.Drawing.Point(147, 56);
            this.txtNomA.Name = "txtNomA";
            this.txtNomA.Size = new System.Drawing.Size(100, 20);
            this.txtNomA.TabIndex = 1;
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Location = new System.Drawing.Point(6, 33);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(50, 13);
            this.lblNumA.TabIndex = 1;
            this.lblNumA.Text = "Numéro :";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(6, 90);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(75, 13);
            this.lblResp.TabIndex = 3;
            this.lblResp.Text = "Responsable :";
            this.lblResp.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNomA
            // 
            this.lblNomA.AutoSize = true;
            this.lblNomA.Location = new System.Drawing.Point(6, 59);
            this.lblNomA.Name = "lblNomA";
            this.lblNomA.Size = new System.Drawing.Size(35, 13);
            this.lblNomA.TabIndex = 2;
            this.lblNomA.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(382, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 302);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Association existante";
            // 
            // btn_suppr
            // 
            this.btn_suppr.Location = new System.Drawing.Point(226, 260);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(75, 23);
            this.btn_suppr.TabIndex = 8;
            this.btn_suppr.Text = "Supprimer";
            this.btn_suppr.UseVisualStyleBackColor = true;
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(122, 260);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 23);
            this.btn_mod.TabIndex = 9;
            this.btn_mod.Text = "Modifier";
            this.btn_mod.UseVisualStyleBackColor = true;
            // 
            // Btn_ajout
            // 
            this.Btn_ajout.Location = new System.Drawing.Point(6, 260);
            this.Btn_ajout.Name = "Btn_ajout";
            this.Btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.Btn_ajout.TabIndex = 10;
            this.Btn_ajout.Text = "Ajouter";
            this.Btn_ajout.UseVisualStyleBackColor = true;
            // 
            // FrmAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBAssos);
            this.Name = "FrmAssociation";
            this.Text = "FrmAssociation";
            this.Load += new System.EventHandler(this.FrmAssociation_Load);
            this.grpBAssos.ResumeLayout(false);
            this.grpBAssos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBAssos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbMission;
        private System.Windows.Forms.TextBox txtBResp;
        private System.Windows.Forms.TextBox txtBNumA;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.TextBox txtNomA;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Label lblNomA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_ajout;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_suppr;
    }
}