namespace GameBackend
{
    partial class Giris
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
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.LblGirisPwd = new System.Windows.Forms.Label();
            this.tbxGirisPwd = new System.Windows.Forms.TextBox();
            this.LblNatID = new System.Windows.Forms.Label();
            this.tbxGirisNatID = new System.Windows.Forms.TextBox();
            this.LLblKayit = new System.Windows.Forms.LinkLabel();
            this.gbGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.LLblKayit);
            this.gbGiris.Controls.Add(this.btnGiris);
            this.gbGiris.Controls.Add(this.LblGirisPwd);
            this.gbGiris.Controls.Add(this.tbxGirisPwd);
            this.gbGiris.Controls.Add(this.LblNatID);
            this.gbGiris.Controls.Add(this.tbxGirisNatID);
            this.gbGiris.Location = new System.Drawing.Point(63, 48);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(397, 382);
            this.gbGiris.TabIndex = 0;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Giriş";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(31, 233);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(107, 41);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // LblGirisPwd
            // 
            this.LblGirisPwd.AutoSize = true;
            this.LblGirisPwd.Location = new System.Drawing.Point(27, 128);
            this.LblGirisPwd.Name = "LblGirisPwd";
            this.LblGirisPwd.Size = new System.Drawing.Size(42, 20);
            this.LblGirisPwd.TabIndex = 3;
            this.LblGirisPwd.Text = "Şifre";
            // 
            // tbxGirisPwd
            // 
            this.tbxGirisPwd.Location = new System.Drawing.Point(27, 154);
            this.tbxGirisPwd.Name = "tbxGirisPwd";
            this.tbxGirisPwd.Size = new System.Drawing.Size(233, 26);
            this.tbxGirisPwd.TabIndex = 2;
            this.tbxGirisPwd.TextChanged += new System.EventHandler(this.TbxGirisPwd_TextChanged);
            // 
            // LblNatID
            // 
            this.LblNatID.AutoSize = true;
            this.LblNatID.Location = new System.Drawing.Point(27, 50);
            this.LblNatID.Name = "LblNatID";
            this.LblNatID.Size = new System.Drawing.Size(61, 20);
            this.LblNatID.TabIndex = 1;
            this.LblNatID.Text = "T.C. No";
            // 
            // tbxGirisNatID
            // 
            this.tbxGirisNatID.Location = new System.Drawing.Point(27, 73);
            this.tbxGirisNatID.Name = "tbxGirisNatID";
            this.tbxGirisNatID.Size = new System.Drawing.Size(233, 26);
            this.tbxGirisNatID.TabIndex = 0;
            this.tbxGirisNatID.Tag = "";
            // 
            // LLblKayit
            // 
            this.LLblKayit.AutoSize = true;
            this.LLblKayit.Location = new System.Drawing.Point(27, 298);
            this.LLblKayit.Name = "LLblKayit";
            this.LLblKayit.Size = new System.Drawing.Size(74, 24);
            this.LLblKayit.TabIndex = 5;
            this.LLblKayit.TabStop = true;
            this.LLblKayit.Text = "Kayıt Ol";
            this.LLblKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblKayit_LinkClicked);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.gbGiris);
            this.Name = "Giris";
            this.Text = "Giris";
            this.gbGiris.ResumeLayout(false);
            this.gbGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label LblGirisPwd;
        private System.Windows.Forms.TextBox tbxGirisPwd;
        private System.Windows.Forms.Label LblNatID;
        private System.Windows.Forms.TextBox tbxGirisNatID;
        private System.Windows.Forms.LinkLabel LLblKayit;
    }
}