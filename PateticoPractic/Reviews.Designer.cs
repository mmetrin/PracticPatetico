namespace PateticoPractic
{
    partial class Reviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reviews));
            this.roundBtnCatalog = new PateticoPractic.RoundButton();
            this.labelBack = new System.Windows.Forms.Label();
            this.picArrowBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowBack)).BeginInit();
            this.SuspendLayout();
            // 
            // roundBtnCatalog
            // 
            this.roundBtnCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.roundBtnCatalog.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.roundBtnCatalog.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.roundBtnCatalog.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(160)))));
            this.roundBtnCatalog.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(120)))));
            this.roundBtnCatalog.ButtonHighlightForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(139)))), ((int)(((byte)(92)))));
            this.roundBtnCatalog.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.roundBtnCatalog.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(139)))), ((int)(((byte)(92)))));
            this.roundBtnCatalog.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundBtnCatalog.ButtonRoundRadius = 30;
            this.roundBtnCatalog.Font = new System.Drawing.Font("Cormorant Garamond Medium", 15F, System.Drawing.FontStyle.Bold);
            this.roundBtnCatalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.roundBtnCatalog.Location = new System.Drawing.Point(521, 385);
            this.roundBtnCatalog.Name = "roundBtnCatalog";
            this.roundBtnCatalog.Size = new System.Drawing.Size(235, 60);
            this.roundBtnCatalog.TabIndex = 147;
            this.roundBtnCatalog.Text = "Перейти к каталогу";
            this.roundBtnCatalog.Click += new System.EventHandler(this.roundBtnCatalog_Click);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Cormorant Unicase", 13.25F);
            this.labelBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.labelBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBack.Location = new System.Drawing.Point(54, 22);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(140, 22);
            this.labelBack.TabIndex = 166;
            this.labelBack.Text = "В главное меню";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // picArrowBack
            // 
            this.picArrowBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrowBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrowBack.Image = global::PateticoPractic.Properties.Resources.arrow;
            this.picArrowBack.Location = new System.Drawing.Point(15, 14);
            this.picArrowBack.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowBack.Name = "picArrowBack";
            this.picArrowBack.Size = new System.Drawing.Size(38, 41);
            this.picArrowBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowBack.TabIndex = 165;
            this.picArrowBack.TabStop = false;
            this.picArrowBack.Click += new System.EventHandler(this.picArrowBack_Click);
            // 
            // Reviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources.rev;
            this.ClientSize = new System.Drawing.Size(932, 543);
            this.ControlBox = false;
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.picArrowBack);
            this.Controls.Add(this.roundBtnCatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reviews";
            ((System.ComponentModel.ISupportInitialize)(this.picArrowBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundBtnCatalog;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.PictureBox picArrowBack;
    }
}