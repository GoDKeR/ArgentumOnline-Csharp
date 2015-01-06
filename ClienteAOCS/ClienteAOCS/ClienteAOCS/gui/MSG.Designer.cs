namespace ClienteAOCS.gui
{
    partial class MSG
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
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.List1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCerrar
            // 
            this.imgCerrar.BackColor = System.Drawing.Color.Transparent;
            this.imgCerrar.Location = new System.Drawing.Point(25, 163);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(114, 28);
            this.imgCerrar.TabIndex = 3;
            this.imgCerrar.TabStop = false;
            // 
            // List1
            // 
            this.List1.BackColor = System.Drawing.Color.Black;
            this.List1.ForeColor = System.Drawing.Color.White;
            this.List1.FormattingEnabled = true;
            this.List1.Location = new System.Drawing.Point(20, 28);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(123, 108);
            this.List1.TabIndex = 2;
            // 
            // MSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 218);
            this.Controls.Add(this.imgCerrar);
            this.Controls.Add(this.List1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MSG";
            this.Text = "MSG";
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgCerrar;
        internal System.Windows.Forms.ListBox List1;
    }
}