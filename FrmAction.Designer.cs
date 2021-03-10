namespace ppe1
{
    partial class FrmAction
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
            this.grpBCreaAction = new System.Windows.Forms.GroupBox();
            this.lblMontantDep = new System.Windows.Forms.Label();
            this.txtBMontantPrev = new System.Windows.Forms.TextBox();
            this.lblMontantPrev = new System.Windows.Forms.Label();
            this.txtBMontantDep = new System.Windows.Forms.TextBox();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.cmbBAction = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.txtBNomAction = new System.Windows.Forms.TextBox();
            this.lblNumAction = new System.Windows.Forms.Label();
            this.txtBNumAction = new System.Windows.Forms.TextBox();
            this.lblNomAction = new System.Windows.Forms.Label();
            this.grpBAction = new System.Windows.Forms.GroupBox();
            this.dgvAction = new System.Windows.Forms.DataGridView();
            this.grpBCreaAction.SuspendLayout();
            this.grpBAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAction)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBCreaAction
            // 
            this.grpBCreaAction.Controls.Add(this.lblMontantDep);
            this.grpBCreaAction.Controls.Add(this.txtBMontantPrev);
            this.grpBCreaAction.Controls.Add(this.lblMontantPrev);
            this.grpBCreaAction.Controls.Add(this.txtBMontantDep);
            this.grpBCreaAction.Controls.Add(this.btn_suppr);
            this.grpBCreaAction.Controls.Add(this.btn_ajouter);
            this.grpBCreaAction.Controls.Add(this.cmbBAction);
            this.grpBCreaAction.Controls.Add(this.lblAction);
            this.grpBCreaAction.Controls.Add(this.txtBNomAction);
            this.grpBCreaAction.Controls.Add(this.lblNumAction);
            this.grpBCreaAction.Controls.Add(this.txtBNumAction);
            this.grpBCreaAction.Controls.Add(this.lblNomAction);
            this.grpBCreaAction.Location = new System.Drawing.Point(16, 15);
            this.grpBCreaAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBCreaAction.Name = "grpBCreaAction";
            this.grpBCreaAction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBCreaAction.Size = new System.Drawing.Size(373, 268);
            this.grpBCreaAction.TabIndex = 0;
            this.grpBCreaAction.TabStop = false;
            this.grpBCreaAction.Text = "Nouvelle Action";
            this.grpBCreaAction.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblMontantDep
            // 
            this.lblMontantDep.AutoSize = true;
            this.lblMontantDep.Location = new System.Drawing.Point(8, 178);
            this.lblMontantDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantDep.Name = "lblMontantDep";
            this.lblMontantDep.Size = new System.Drawing.Size(97, 17);
            this.lblMontantDep.TabIndex = 3;
            this.lblMontantDep.Text = "Montant Dép :";
            // 
            // txtBMontantPrev
            // 
            this.txtBMontantPrev.Location = new System.Drawing.Point(149, 138);
            this.txtBMontantPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBMontantPrev.Name = "txtBMontantPrev";
            this.txtBMontantPrev.Size = new System.Drawing.Size(161, 22);
            this.txtBMontantPrev.TabIndex = 2;
            // 
            // lblMontantPrev
            // 
            this.lblMontantPrev.AutoSize = true;
            this.lblMontantPrev.Location = new System.Drawing.Point(8, 146);
            this.lblMontantPrev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantPrev.Name = "lblMontantPrev";
            this.lblMontantPrev.Size = new System.Drawing.Size(100, 17);
            this.lblMontantPrev.TabIndex = 2;
            this.lblMontantPrev.Text = "Montant Prev :";
            // 
            // txtBMontantDep
            // 
            this.txtBMontantDep.Location = new System.Drawing.Point(149, 170);
            this.txtBMontantDep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBMontantDep.Name = "txtBMontantDep";
            this.txtBMontantDep.Size = new System.Drawing.Size(160, 22);
            this.txtBMontantDep.TabIndex = 3;
            // 
            // btn_suppr
            // 
            this.btn_suppr.Location = new System.Drawing.Point(151, 219);
            this.btn_suppr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(100, 28);
            this.btn_suppr.TabIndex = 2;
            this.btn_suppr.Text = "Supprimer";
            this.btn_suppr.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(12, 219);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(113, 28);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // cmbBAction
            // 
            this.cmbBAction.FormattingEnabled = true;
            this.cmbBAction.Location = new System.Drawing.Point(151, 105);
            this.cmbBAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBAction.Name = "cmbBAction";
            this.cmbBAction.Size = new System.Drawing.Size(160, 24);
            this.cmbBAction.TabIndex = 1;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(8, 108);
            this.lblAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(55, 17);
            this.lblAction.TabIndex = 4;
            this.lblAction.Text = "Action :";
            // 
            // txtBNomAction
            // 
            this.txtBNomAction.Location = new System.Drawing.Point(151, 68);
            this.txtBNomAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBNomAction.Name = "txtBNomAction";
            this.txtBNomAction.Size = new System.Drawing.Size(131, 22);
            this.txtBNomAction.TabIndex = 3;
            // 
            // lblNumAction
            // 
            this.lblNumAction.AutoSize = true;
            this.lblNumAction.Location = new System.Drawing.Point(8, 37);
            this.lblNumAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumAction.Name = "lblNumAction";
            this.lblNumAction.Size = new System.Drawing.Size(109, 17);
            this.lblNumAction.TabIndex = 1;
            this.lblNumAction.Text = "Numéro Action :";
            // 
            // txtBNumAction
            // 
            this.txtBNumAction.Location = new System.Drawing.Point(151, 33);
            this.txtBNumAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBNumAction.Name = "txtBNumAction";
            this.txtBNumAction.Size = new System.Drawing.Size(33, 22);
            this.txtBNumAction.TabIndex = 1;
            // 
            // lblNomAction
            // 
            this.lblNomAction.AutoSize = true;
            this.lblNomAction.Location = new System.Drawing.Point(8, 68);
            this.lblNomAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomAction.Name = "lblNomAction";
            this.lblNomAction.Size = new System.Drawing.Size(88, 17);
            this.lblNomAction.TabIndex = 2;
            this.lblNomAction.Text = "Nom Action :";
            this.lblNomAction.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpBAction
            // 
            this.grpBAction.Controls.Add(this.dgvAction);
            this.grpBAction.Location = new System.Drawing.Point(440, 20);
            this.grpBAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBAction.Name = "grpBAction";
            this.grpBAction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBAction.Size = new System.Drawing.Size(369, 263);
            this.grpBAction.TabIndex = 1;
            this.grpBAction.TabStop = false;
            this.grpBAction.Text = "Action existante";
            this.grpBAction.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvAction
            // 
            this.dgvAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAction.Location = new System.Drawing.Point(21, 23);
            this.dgvAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAction.Name = "dgvAction";
            this.dgvAction.RowHeadersWidth = 51;
            this.dgvAction.Size = new System.Drawing.Size(320, 219);
            this.dgvAction.TabIndex = 0;
            // 
            // FrmAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpBAction);
            this.Controls.Add(this.grpBCreaAction);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAction";
            this.Text = "Mission";
            this.grpBCreaAction.ResumeLayout(false);
            this.grpBCreaAction.PerformLayout();
            this.grpBAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBCreaAction;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtBNomAction;
        private System.Windows.Forms.Label lblNumAction;
        private System.Windows.Forms.TextBox txtBNumAction;
        private System.Windows.Forms.Label lblNomAction;
        private System.Windows.Forms.ComboBox cmbBAction;
        private System.Windows.Forms.GroupBox grpBAction;
        private System.Windows.Forms.DataGridView dgvAction;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label lblMontantDep;
        private System.Windows.Forms.TextBox txtBMontantPrev;
        private System.Windows.Forms.Label lblMontantPrev;
        private System.Windows.Forms.TextBox txtBMontantDep;
    }
}