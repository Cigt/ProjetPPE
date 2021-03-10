namespace ppe1
{
    partial class Pays
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
            this.grpBCreaPays = new System.Windows.Forms.GroupBox();
            this.txtBNomPays = new System.Windows.Forms.TextBox();
            this.txtBIDPays = new System.Windows.Forms.TextBox();
            this.lblNomPays = new System.Windows.Forms.Label();
            this.lblIDPays = new System.Windows.Forms.Label();
            this.grpBPays = new System.Windows.Forms.GroupBox();
            this.dgvPays = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.grpBCreaPays.SuspendLayout();
            this.grpBPays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBCreaPays
            // 
            this.grpBCreaPays.Controls.Add(this.btnSuppr);
            this.grpBCreaPays.Controls.Add(this.btnAjouter);
            this.grpBCreaPays.Controls.Add(this.txtBNomPays);
            this.grpBCreaPays.Controls.Add(this.txtBIDPays);
            this.grpBCreaPays.Controls.Add(this.lblNomPays);
            this.grpBCreaPays.Controls.Add(this.lblIDPays);
            this.grpBCreaPays.Location = new System.Drawing.Point(16, 15);
            this.grpBCreaPays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBCreaPays.Name = "grpBCreaPays";
            this.grpBCreaPays.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBCreaPays.Size = new System.Drawing.Size(425, 357);
            this.grpBCreaPays.TabIndex = 4;
            this.grpBCreaPays.TabStop = false;
            this.grpBCreaPays.Text = "Ajout d\'un pays :";
            this.grpBCreaPays.Enter += new System.EventHandler(this.grpBCreaPays_Enter);
            // 
            // txtBNomPays
            // 
            this.txtBNomPays.Location = new System.Drawing.Point(139, 86);
            this.txtBNomPays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBNomPays.Name = "txtBNomPays";
            this.txtBNomPays.Size = new System.Drawing.Size(192, 22);
            this.txtBNomPays.TabIndex = 3;
            // 
            // txtBIDPays
            // 
            this.txtBIDPays.Location = new System.Drawing.Point(139, 54);
            this.txtBIDPays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBIDPays.Name = "txtBIDPays";
            this.txtBIDPays.Size = new System.Drawing.Size(192, 22);
            this.txtBIDPays.TabIndex = 2;
            // 
            // lblNomPays
            // 
            this.lblNomPays.AutoSize = true;
            this.lblNomPays.Location = new System.Drawing.Point(29, 90);
            this.lblNomPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomPays.Name = "lblNomPays";
            this.lblNomPays.Size = new System.Drawing.Size(100, 17);
            this.lblNomPays.TabIndex = 1;
            this.lblNomPays.Text = "Nom du Pays :";
            // 
            // lblIDPays
            // 
            this.lblIDPays.AutoSize = true;
            this.lblIDPays.Location = new System.Drawing.Point(29, 54);
            this.lblIDPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDPays.Name = "lblIDPays";
            this.lblIDPays.Size = new System.Drawing.Size(62, 17);
            this.lblIDPays.TabIndex = 0;
            this.lblIDPays.Text = "Id Pays :";
            // 
            // grpBPays
            // 
            this.grpBPays.Controls.Add(this.dgvPays);
            this.grpBPays.Location = new System.Drawing.Point(540, 15);
            this.grpBPays.Name = "grpBPays";
            this.grpBPays.Size = new System.Drawing.Size(328, 357);
            this.grpBPays.TabIndex = 5;
            this.grpBPays.TabStop = false;
            this.grpBPays.Text = "Pays existant";
            // 
            // dgvPays
            // 
            this.dgvPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPays.Location = new System.Drawing.Point(48, 31);
            this.dgvPays.Name = "dgvPays";
            this.dgvPays.RowHeadersWidth = 51;
            this.dgvPays.RowTemplate.Height = 24;
            this.dgvPays.Size = new System.Drawing.Size(240, 303);
            this.dgvPays.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(40, 171);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(89, 31);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(228, 171);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(89, 31);
            this.btnSuppr.TabIndex = 5;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // Pays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpBPays);
            this.Controls.Add(this.grpBCreaPays);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pays";
            this.Text = "Pays";
            this.Load += new System.EventHandler(this.Pays_Load);
            this.grpBCreaPays.ResumeLayout(false);
            this.grpBCreaPays.PerformLayout();
            this.grpBPays.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBCreaPays;
        private System.Windows.Forms.TextBox txtBNomPays;
        private System.Windows.Forms.TextBox txtBIDPays;
        private System.Windows.Forms.Label lblNomPays;
        private System.Windows.Forms.Label lblIDPays;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox grpBPays;
        private System.Windows.Forms.DataGridView dgvPays;
    }
}