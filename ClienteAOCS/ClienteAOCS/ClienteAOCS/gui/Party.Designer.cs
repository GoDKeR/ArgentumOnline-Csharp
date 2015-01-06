namespace ClienteAOCS.gui
{
    partial class Party
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
            this.imgSalirParty = new System.Windows.Forms.PictureBox();
            this.imgAgregar = new System.Windows.Forms.PictureBox();
            this.lblTotalExp = new System.Windows.Forms.Label();
            this.txtToAdd = new System.Windows.Forms.TextBox();
            this.imgLiderGrupo = new System.Windows.Forms.PictureBox();
            this.imgExpulsar = new System.Windows.Forms.PictureBox();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.SendTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalirParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLiderGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExpulsar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCerrar
            // 
            this.imgCerrar.BackColor = System.Drawing.Color.Transparent;
            this.imgCerrar.Location = new System.Drawing.Point(258, 358);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(97, 24);
            this.imgCerrar.TabIndex = 17;
            this.imgCerrar.TabStop = false;
            // 
            // imgSalirParty
            // 
            this.imgSalirParty.BackColor = System.Drawing.Color.Transparent;
            this.imgSalirParty.Location = new System.Drawing.Point(22, 358);
            this.imgSalirParty.Name = "imgSalirParty";
            this.imgSalirParty.Size = new System.Drawing.Size(97, 25);
            this.imgSalirParty.TabIndex = 16;
            this.imgSalirParty.TabStop = false;
            // 
            // imgAgregar
            // 
            this.imgAgregar.BackColor = System.Drawing.Color.Transparent;
            this.imgAgregar.Location = new System.Drawing.Point(138, 320);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(97, 24);
            this.imgAgregar.TabIndex = 15;
            this.imgAgregar.TabStop = false;
            // 
            // lblTotalExp
            // 
            this.lblTotalExp.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExp.ForeColor = System.Drawing.Color.White;
            this.lblTotalExp.Location = new System.Drawing.Point(207, 208);
            this.lblTotalExp.Name = "lblTotalExp";
            this.lblTotalExp.Size = new System.Drawing.Size(89, 17);
            this.lblTotalExp.TabIndex = 14;
            this.lblTotalExp.Text = "000000";
            // 
            // txtToAdd
            // 
            this.txtToAdd.BackColor = System.Drawing.Color.Black;
            this.txtToAdd.ForeColor = System.Drawing.Color.White;
            this.txtToAdd.Location = new System.Drawing.Point(104, 290);
            this.txtToAdd.Name = "txtToAdd";
            this.txtToAdd.Size = new System.Drawing.Size(172, 20);
            this.txtToAdd.TabIndex = 13;
            // 
            // imgLiderGrupo
            // 
            this.imgLiderGrupo.BackColor = System.Drawing.Color.Transparent;
            this.imgLiderGrupo.Location = new System.Drawing.Point(194, 230);
            this.imgLiderGrupo.Name = "imgLiderGrupo";
            this.imgLiderGrupo.Size = new System.Drawing.Size(97, 24);
            this.imgLiderGrupo.TabIndex = 12;
            this.imgLiderGrupo.TabStop = false;
            // 
            // imgExpulsar
            // 
            this.imgExpulsar.BackColor = System.Drawing.Color.Transparent;
            this.imgExpulsar.Location = new System.Drawing.Point(90, 230);
            this.imgExpulsar.Name = "imgExpulsar";
            this.imgExpulsar.Size = new System.Drawing.Size(97, 24);
            this.imgExpulsar.TabIndex = 11;
            this.imgExpulsar.TabStop = false;
            // 
            // lstMembers
            // 
            this.lstMembers.BackColor = System.Drawing.Color.Black;
            this.lstMembers.ForeColor = System.Drawing.Color.White;
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.Location = new System.Drawing.Point(104, 104);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(173, 82);
            this.lstMembers.TabIndex = 10;
            // 
            // SendTxt
            // 
            this.SendTxt.BackColor = System.Drawing.Color.Black;
            this.SendTxt.ForeColor = System.Drawing.Color.White;
            this.SendTxt.Location = new System.Drawing.Point(39, 46);
            this.SendTxt.Name = "SendTxt";
            this.SendTxt.Size = new System.Drawing.Size(302, 20);
            this.SendTxt.TabIndex = 9;
            // 
            // Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 428);
            this.Controls.Add(this.imgCerrar);
            this.Controls.Add(this.imgSalirParty);
            this.Controls.Add(this.imgAgregar);
            this.Controls.Add(this.lblTotalExp);
            this.Controls.Add(this.txtToAdd);
            this.Controls.Add(this.imgLiderGrupo);
            this.Controls.Add(this.imgExpulsar);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.SendTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Party";
            this.Text = "Party";
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalirParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLiderGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExpulsar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgCerrar;
        internal System.Windows.Forms.PictureBox imgSalirParty;
        internal System.Windows.Forms.PictureBox imgAgregar;
        internal System.Windows.Forms.Label lblTotalExp;
        internal System.Windows.Forms.TextBox txtToAdd;
        internal System.Windows.Forms.PictureBox imgLiderGrupo;
        internal System.Windows.Forms.PictureBox imgExpulsar;
        internal System.Windows.Forms.ListBox lstMembers;
        internal System.Windows.Forms.TextBox SendTxt;
    }
}