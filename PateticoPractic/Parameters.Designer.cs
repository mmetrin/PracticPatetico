namespace PateticoPractic
{
    partial class Parameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parameters));
            this.TableParameters = new System.Windows.Forms.DataGridView();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.picArrawBack = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.roundBtnAdd = new PateticoPractic.RoundButton();
            this.roundBtnDelete = new PateticoPractic.RoundButton();
            this.roundBtnChange = new PateticoPractic.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // TableParameters
            // 
            this.TableParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableParameters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TableParameters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.TableParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableParameters.Location = new System.Drawing.Point(72, 149);
            this.TableParameters.Name = "TableParameters";
            this.TableParameters.Size = new System.Drawing.Size(330, 245);
            this.TableParameters.TabIndex = 91;
            this.TableParameters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableParameters_CellClick);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Cormorant Garamond Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelWelcome.Location = new System.Drawing.Point(223, 32);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(278, 39);
            this.labelWelcome.TabIndex = 90;
            this.labelWelcome.Text = "Категории товаров";
            // 
            // picArrawBack
            // 
            this.picArrawBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrawBack.BackgroundImage = global::PateticoPractic.Properties.Resources.back_to_48;
            this.picArrawBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrawBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrawBack.Location = new System.Drawing.Point(610, 9);
            this.picArrawBack.Name = "picArrawBack";
            this.picArrawBack.Size = new System.Drawing.Size(53, 46);
            this.picArrawBack.TabIndex = 100;
            this.picArrawBack.TabStop = false;
            this.picArrawBack.Click += new System.EventHandler(this.picArrawBack_Click);
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtitle.Font = new System.Drawing.Font("Cormorant Garamond", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSubtitle.Location = new System.Drawing.Point(101, 32);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(79, 23);
            this.labelSubtitle.TabIndex = 99;
            this.labelSubtitle.Text = "sweetshop";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Cormorant Garamond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.labelTitle.Location = new System.Drawing.Point(83, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(83, 29);
            this.labelTitle.TabIndex = 98;
            this.labelTitle.Text = "Patetico";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_double_chocolate_cake_64__1_;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(8, -6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(84, 72);
            this.picLogo.TabIndex = 97;
            this.picLogo.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_close_window_48;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(668, 9);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 46);
            this.picExit.TabIndex = 96;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
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
            this.roundBtnAdd.Location = new System.Drawing.Point(456, 182);
            this.roundBtnAdd.Name = "roundBtnAdd";
            this.roundBtnAdd.Size = new System.Drawing.Size(230, 40);
            this.roundBtnAdd.TabIndex = 102;
            this.roundBtnAdd.Text = "Добавить категорию";
            this.roundBtnAdd.Click += new System.EventHandler(this.roundBtnAdd_Click);
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
            this.roundBtnDelete.Location = new System.Drawing.Point(456, 309);
            this.roundBtnDelete.Name = "roundBtnDelete";
            this.roundBtnDelete.Size = new System.Drawing.Size(230, 40);
            this.roundBtnDelete.TabIndex = 101;
            this.roundBtnDelete.Text = "Удалить категорию";
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
            this.roundBtnChange.Location = new System.Drawing.Point(456, 246);
            this.roundBtnChange.Name = "roundBtnChange";
            this.roundBtnChange.Size = new System.Drawing.Size(230, 40);
            this.roundBtnChange.TabIndex = 103;
            this.roundBtnChange.Text = "Изменить категорию";
            this.roundBtnChange.Click += new System.EventHandler(this.roundBtnChange_Click);
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources.фон_размыт;
            this.ClientSize = new System.Drawing.Size(744, 460);
            this.ControlBox = false;
            this.Controls.Add(this.roundBtnChange);
            this.Controls.Add(this.roundBtnAdd);
            this.Controls.Add(this.roundBtnDelete);
            this.Controls.Add(this.picArrawBack);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.TableParameters);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Parameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameters";
            this.Load += new System.EventHandler(this.Parameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableParameters;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox picArrawBack;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picExit;
        private RoundButton roundBtnAdd;
        private RoundButton roundBtnDelete;
        private RoundButton roundBtnChange;
    }
}