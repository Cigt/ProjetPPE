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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpBCreaPays.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBCreaPays
            // 
            this.grpBCreaPays.Controls.Add(this.textBox2);
            this.grpBCreaPays.Controls.Add(this.textBox1);
            this.grpBCreaPays.Controls.Add(this.label2);
            this.grpBCreaPays.Controls.Add(this.label1);
            this.grpBCreaPays.Location = new System.Drawing.Point(12, 12);
            this.grpBCreaPays.Name = "grpBCreaPays";
            this.grpBCreaPays.Size = new System.Drawing.Size(319, 290);
            this.grpBCreaPays.TabIndex = 4;
            this.grpBCreaPays.TabStop = false;
            this.grpBCreaPays.Text = "Ajout d\'un pays :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Pays :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du Pays :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Pays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBCreaPays);
            this.Name = "Pays";
            this.Text = "Pays";
            this.grpBCreaPays.ResumeLayout(false);
            this.grpBCreaPays.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBCreaPays;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}