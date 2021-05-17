namespace GameBackend
{
    partial class Kayıt
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
            this.gBoxSubscription = new System.Windows.Forms.GroupBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.LblPwd = new System.Windows.Forms.Label();
            this.txtBoxPwd = new System.Windows.Forms.TextBox();
            this.LblYoB = new System.Windows.Forms.Label();
            this.txtBoxYoB = new System.Windows.Forms.TextBox();
            this.LblNatID = new System.Windows.Forms.Label();
            this.txtBoxNatID = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.LLblGiris = new System.Windows.Forms.LinkLabel();
            this.gBoxSubscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSubscription
            // 
            this.gBoxSubscription.Controls.Add(this.LLblGiris);
            this.gBoxSubscription.Controls.Add(this.btnSubscribe);
            this.gBoxSubscription.Controls.Add(this.LblPwd);
            this.gBoxSubscription.Controls.Add(this.txtBoxPwd);
            this.gBoxSubscription.Controls.Add(this.LblYoB);
            this.gBoxSubscription.Controls.Add(this.txtBoxYoB);
            this.gBoxSubscription.Controls.Add(this.LblNatID);
            this.gBoxSubscription.Controls.Add(this.txtBoxNatID);
            this.gBoxSubscription.Controls.Add(this.LblSurname);
            this.gBoxSubscription.Controls.Add(this.txtBoxSurname);
            this.gBoxSubscription.Controls.Add(this.LblName);
            this.gBoxSubscription.Controls.Add(this.txtBoxName);
            this.gBoxSubscription.Location = new System.Drawing.Point(31, 31);
            this.gBoxSubscription.Name = "gBoxSubscription";
            this.gBoxSubscription.Size = new System.Drawing.Size(522, 364);
            this.gBoxSubscription.TabIndex = 0;
            this.gBoxSubscription.TabStop = false;
            this.gBoxSubscription.Text = "Kayıt";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(280, 205);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(136, 36);
            this.btnSubscribe.TabIndex = 12;
            this.btnSubscribe.Text = "KAYDOL";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(276, 112);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(42, 20);
            this.LblPwd.TabIndex = 11;
            this.LblPwd.Text = "Şifre";
            // 
            // txtBoxPwd
            // 
            this.txtBoxPwd.Location = new System.Drawing.Point(265, 144);
            this.txtBoxPwd.Name = "txtBoxPwd";
            this.txtBoxPwd.Size = new System.Drawing.Size(175, 26);
            this.txtBoxPwd.TabIndex = 10;
            this.txtBoxPwd.TextChanged += new System.EventHandler(this.TxtBoxPwd_TextChanged);
            // 
            // LblYoB
            // 
            this.LblYoB.AutoSize = true;
            this.LblYoB.Location = new System.Drawing.Point(276, 38);
            this.LblYoB.Name = "LblYoB";
            this.LblYoB.Size = new System.Drawing.Size(85, 20);
            this.LblYoB.TabIndex = 9;
            this.LblYoB.Text = "Doğum Yılı";
            // 
            // txtBoxYoB
            // 
            this.txtBoxYoB.Location = new System.Drawing.Point(265, 70);
            this.txtBoxYoB.Name = "txtBoxYoB";
            this.txtBoxYoB.Size = new System.Drawing.Size(175, 26);
            this.txtBoxYoB.TabIndex = 8;
            // 
            // LblNatID
            // 
            this.LblNatID.AutoSize = true;
            this.LblNatID.Location = new System.Drawing.Point(17, 183);
            this.LblNatID.Name = "LblNatID";
            this.LblNatID.Size = new System.Drawing.Size(61, 20);
            this.LblNatID.TabIndex = 7;
            this.LblNatID.Text = "T.C. No";
            // 
            // txtBoxNatID
            // 
            this.txtBoxNatID.Location = new System.Drawing.Point(6, 215);
            this.txtBoxNatID.Name = "txtBoxNatID";
            this.txtBoxNatID.Size = new System.Drawing.Size(175, 26);
            this.txtBoxNatID.TabIndex = 6;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(17, 108);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(54, 20);
            this.LblSurname.TabIndex = 3;
            this.LblSurname.Text = "Soyad";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(6, 144);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(175, 26);
            this.txtBoxSurname.TabIndex = 2;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(17, 38);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(29, 20);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Ad";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(6, 70);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(175, 26);
            this.txtBoxName.TabIndex = 0;
            // 
            // LLblGiris
            // 
            this.LLblGiris.AutoSize = true;
            this.LLblGiris.Location = new System.Drawing.Point(302, 255);
            this.LLblGiris.Name = "LLblGiris";
            this.LLblGiris.Size = new System.Drawing.Size(74, 20);
            this.LLblGiris.TabIndex = 13;
            this.LLblGiris.TabStop = true;
            this.LLblGiris.Text = "Giriş Yap";
            this.LLblGiris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblGiris_LinkClicked);
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxSubscription);
            this.Name = "Kayıt";
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.Kayıt_Load);
            this.gBoxSubscription.ResumeLayout(false);
            this.gBoxSubscription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSubscription;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label LblYoB;
        private System.Windows.Forms.TextBox txtBoxYoB;
        private System.Windows.Forms.Label LblNatID;
        private System.Windows.Forms.TextBox txtBoxNatID;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.TextBox txtBoxPwd;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.LinkLabel LLblGiris;
    }
}

