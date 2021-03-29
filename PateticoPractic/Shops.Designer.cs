namespace PateticoPractic
{
    partial class Shops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shops));
            this.TableShops = new System.Windows.Forms.DataGridView();
            this.labelTitleShops = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picArrawBack = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.roundBtnDelete = new PateticoPractic.RoundButton();
            this.roundBtnChange = new PateticoPractic.RoundButton();
            this.roundBtnAdd = new PateticoPractic.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableShops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // TableShops
            // 
            this.TableShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableShops.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.TableShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableShops.Location = new System.Drawing.Point(45, 101);
            this.TableShops.Margin = new System.Windows.Forms.Padding(2);
            this.TableShops.Name = "TableShops";
            this.TableShops.RowTemplate.Height = 24;
            this.TableShops.Size = new System.Drawing.Size(543, 264);
            this.TableShops.TabIndex = 106;
            this.TableShops.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableShops_CellClick);
            // 
            // labelTitleShops
            // 
            this.labelTitleShops.AutoSize = true;
            this.labelTitleShops.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleShops.Font = new System.Drawing.Font("Cormorant Garamond Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleShops.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleShops.Location = new System.Drawing.Point(253, 29);
            this.labelTitleShops.Name = "labelTitleShops";
            this.labelTitleShops.Size = new System.Drawing.Size(156, 39);
            this.labelTitleShops.TabIndex = 105;
            this.labelTitleShops.Text = "Магазины";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtitle.Font = new System.Drawing.Font("Cormorant Garamond", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSubtitle.Location = new System.Drawing.Point(106, 29);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(79, 23);
            this.labelSubtitle.TabIndex = 120;
            this.labelSubtitle.Text = "sweetshop";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Cormorant Garamond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.labelTitle.Location = new System.Drawing.Point(88, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(83, 29);
            this.labelTitle.TabIndex = 119;
            this.labelTitle.Text = "Patetico";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_double_chocolate_cake_64__1_;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(13, -9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(84, 72);
            this.picLogo.TabIndex = 118;
            this.picLogo.TabStop = false;
            // 
            // picArrawBack
            // 
            this.picArrawBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrawBack.BackgroundImage = global::PateticoPractic.Properties.Resources.back_to_48;
            this.picArrawBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrawBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrawBack.Location = new System.Drawing.Point(522, 6);
            this.picArrawBack.Name = "picArrawBack";
            this.picArrawBack.Size = new System.Drawing.Size(53, 46);
            this.picArrawBack.TabIndex = 122;
            this.picArrawBack.TabStop = false;
            this.picArrawBack.Click += new System.EventHandler(this.picArrawBack_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_close_window_48;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(580, 6);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 46);
            this.picExit.TabIndex = 121;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // roundBtnDelete
            // 
            this.roundBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.roundBtnDelete.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.roundBtnDelete.ButtonBorderColor = System.Drawing.Color.SlateGray;
            this.roundBtnDelete.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnDelete.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnDelete.ButtonHighlightForeColor = System.Drawing.Color.Maroon;
            this.roundBtnDelete.ButtonPressedColor = System.Drawing.Color.RosyBrown;
            this.roundBtnDelete.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundBtnDelete.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundBtnDelete.ButtonRoundRadius = 30;
            this.roundBtnDelete.Font = new System.Drawing.Font("Cormorant Garamond Medium", 15F, System.Drawing.FontStyle.Bold);
            this.roundBtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.roundBtnDelete.Location = new System.Drawing.Point(418, 396);
            this.roundBtnDelete.Name = "roundBtnDelete";
            this.roundBtnDelete.Size = new System.Drawing.Size(170, 40);
            this.roundBtnDelete.TabIndex = 117;
            this.roundBtnDelete.Text = "Удалить";
            this.roundBtnDelete.Click += new System.EventHandler(this.roundBtnDelete_Click);
            // 
            // roundBtnChange
            // 
            this.roundBtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.roundBtnChange.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.roundBtnChange.ButtonBorderColor = System.Drawing.Color.SlateGray;
            this.roundBtnChange.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnChange.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnChange.ButtonHighlightForeColor = System.Drawing.Color.Maroon;
            this.roundBtnChange.ButtonPressedColor = System.Drawing.Color.RosyBrown;
            this.roundBtnChange.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundBtnChange.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundBtnChange.ButtonRoundRadius = 30;
            this.roundBtnChange.Font = new System.Drawing.Font("Cormorant Garamond Medium", 15F, System.Drawing.FontStyle.Bold);
            this.roundBtnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.roundBtnChange.Location = new System.Drawing.Point(233, 396);
            this.roundBtnChange.Name = "roundBtnChange";
            this.roundBtnChange.Size = new System.Drawing.Size(170, 40);
            this.roundBtnChange.TabIndex = 116;
            this.roundBtnChange.Text = "Изменить";
            this.roundBtnChange.Click += new System.EventHandler(this.roundBtnChange_Click);
            // 
            // roundBtnAdd
            // 
            this.roundBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.roundBtnAdd.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.roundBtnAdd.ButtonBorderColor = System.Drawing.Color.SlateGray;
            this.roundBtnAdd.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnAdd.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnAdd.ButtonHighlightForeColor = System.Drawing.Color.Maroon;
            this.roundBtnAdd.ButtonPressedColor = System.Drawing.Color.RosyBrown;
            this.roundBtnAdd.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundBtnAdd.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundBtnAdd.ButtonRoundRadius = 30;
            this.roundBtnAdd.Font = new System.Drawing.Font("Cormorant Garamond Medium", 15F, System.Drawing.FontStyle.Bold);
            this.roundBtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.roundBtnAdd.Location = new System.Drawing.Point(45, 396);
            this.roundBtnAdd.Name = "roundBtnAdd";
            this.roundBtnAdd.Size = new System.Drawing.Size(170, 40);
            this.roundBtnAdd.TabIndex = 115;
            this.roundBtnAdd.Text = "Добавить";
            this.roundBtnAdd.Click += new System.EventHandler(this.roundBtnAdd_Click);
            // 
            // Shops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources.фон_размыт;
            this.ClientSize = new System.Drawing.Size(637, 473);
            this.ControlBox = false;
            this.Controls.Add(this.picArrawBack);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.roundBtnDelete);
            this.Controls.Add(this.roundBtnChange);
            this.Controls.Add(this.roundBtnAdd);
            this.Controls.Add(this.TableShops);
            this.Controls.Add(this.labelTitleShops);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shops";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shops";
            this.Load += new System.EventHandler(this.Shops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableShops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableShops;
        private System.Windows.Forms.Label labelTitleShops;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private RoundButton roundBtnDelete;
        private RoundButton roundBtnChange;
        private RoundButton roundBtnAdd;
        private System.Windows.Forms.PictureBox picArrawBack;
        private System.Windows.Forms.PictureBox picExit;
    }
}