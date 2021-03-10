namespace ppe1
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.associationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleAssociationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partenariatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleAssociationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nouveauPartenariatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associationToolStripMenuItem,
            this.partenariatToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.paysToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // associationToolStripMenuItem
            // 
            this.associationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleAssociationToolStripMenuItem});
            this.associationToolStripMenuItem.Name = "associationToolStripMenuItem";
            this.associationToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.associationToolStripMenuItem.Text = "Action";
            this.associationToolStripMenuItem.Click += new System.EventHandler(this.associationToolStripMenuItem_Click);
            // 
            // nouvelleAssociationToolStripMenuItem
            // 
            this.nouvelleAssociationToolStripMenuItem.Name = "nouvelleAssociationToolStripMenuItem";
            this.nouvelleAssociationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouvelleAssociationToolStripMenuItem.Text = "Nouvelle action";
            this.nouvelleAssociationToolStripMenuItem.Click += new System.EventHandler(this.nouvelleAssociationToolStripMenuItem_Click);
            // 
            // partenariatToolStripMenuItem
            // 
            this.partenariatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleAssociationToolStripMenuItem1});
            this.partenariatToolStripMenuItem.Name = "partenariatToolStripMenuItem";
            this.partenariatToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.partenariatToolStripMenuItem.Text = "Association";
            this.partenariatToolStripMenuItem.Click += new System.EventHandler(this.partenariatToolStripMenuItem_Click);
            // 
            // nouvelleAssociationToolStripMenuItem1
            // 
            this.nouvelleAssociationToolStripMenuItem1.Name = "nouvelleAssociationToolStripMenuItem1";
            this.nouvelleAssociationToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.nouvelleAssociationToolStripMenuItem1.Text = "Nouvelle association";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauPartenariatToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.actionToolStripMenuItem.Text = "Partenariat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 248);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nouveauPartenariatToolStripMenuItem
            // 
            this.nouveauPartenariatToolStripMenuItem.Name = "nouveauPartenariatToolStripMenuItem";
            this.nouveauPartenariatToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nouveauPartenariatToolStripMenuItem.Text = "Nouveau partenariat";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // paysToolStripMenuItem
            // 
            this.paysToolStripMenuItem.Name = "paysToolStripMenuItem";
            this.paysToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.paysToolStripMenuItem.Text = "Pays";
            this.paysToolStripMenuItem.Click += new System.EventHandler(this.paysToolStripMenuItem_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAccueil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAccueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem associationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partenariatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleAssociationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem nouvelleAssociationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouveauPartenariatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paysToolStripMenuItem;
    }
}

