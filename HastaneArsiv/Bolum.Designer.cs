namespace HastaneArsiv
{
    partial class Bolum
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
            this.lbBolum = new System.Windows.Forms.ListBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbBolum
            // 
            this.lbBolum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbBolum.FormattingEnabled = true;
            this.lbBolum.Items.AddRange(new object[] {
            "Genel Cerrahi",
            "Enfeksiyon",
            "Çocuk Hastalıkları",
            "Ortapedi",
            "Göz"});
            this.lbBolum.Location = new System.Drawing.Point(0, 27);
            this.lbBolum.Name = "lbBolum";
            this.lbBolum.Size = new System.Drawing.Size(203, 225);
            this.lbBolum.TabIndex = 3;
            // 
            // txtBolum
            // 
            this.txtBolum.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBolum.Location = new System.Drawing.Point(0, 0);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(203, 20);
            this.txtBolum.TabIndex = 2;
            this.txtBolum.TextChanged += new System.EventHandler(this.txtBolum_TextChanged);
            this.txtBolum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBolum_KeyPress);
            // 
            // Bolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 252);
            this.Controls.Add(this.lbBolum);
            this.Controls.Add(this.txtBolum);
            this.Name = "Bolum";
            this.Text = "Bolum";
            this.Load += new System.EventHandler(this.Bolum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBolum;
        private System.Windows.Forms.TextBox txtBolum;
    }
}