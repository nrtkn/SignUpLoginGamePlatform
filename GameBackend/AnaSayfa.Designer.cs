namespace GameBackend
{
    partial class AnaSayfa
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
            this.dgGames = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGames
            // 
            this.dgGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGames.Location = new System.Drawing.Point(27, 57);
            this.dgGames.Name = "dgGames";
            this.dgGames.RowHeadersWidth = 62;
            this.dgGames.RowTemplate.Height = 28;
            this.dgGames.Size = new System.Drawing.Size(493, 150);
            this.dgGames.TabIndex = 0;
            this.dgGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgGames_CellContentClick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgGames);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dgGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGames;
    }
}