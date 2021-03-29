namespace PateticoPractic
{
    partial class ProductsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsAdmin));
            this.TableProducts = new System.Windows.Forms.DataGridView();
            this.labelTitleProd = new System.Windows.Forms.Label();
            this.picArrawBack = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.txtForName = new System.Windows.Forms.TextBox();
            this.roundBtnSearch = new PateticoPractic.RoundButton();
            this.roundBtnAdd = new PateticoPractic.RoundButton();
            this.roundBtnChange = new PateticoPractic.RoundButton();
            this.roundBtnDelete = new PateticoPractic.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // TableProducts
            // 
            this.TableProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TableProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.TableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableProducts.Location = new System.Drawing.Point(62, 158);
            this.TableProducts.Margin = new System.Windows.Forms.Padding(2);
            this.TableProducts.Name = "TableProducts";
            this.TableProducts.RowTemplate.Height = 24;
            this.TableProducts.Size = new System.Drawing.Size(1023, 300);
            this.TableProducts.TabIndex = 103;
            this.TableProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableProducts_CellClick);
            // 
            // labelTitleProd
            // 
            this.labelTitleProd.AutoSize = true;
            this.labelTitleProd.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleProd.Font = new System.Drawing.Font("Cormorant Garamond Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleProd.Location = new System.Drawing.Point(421, 28);
            this.labelTitleProd.Name = "labelTitleProd";
            this.labelTitleProd.Size = new System.Drawing.Size(324, 39);
            this.labelTitleProd.TabIndex = 102;
            this.labelTitleProd.Text = "Кондитерские изделия";
            // 
            // picArrawBack
            // 
            this.picArrawBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrawBack.BackgroundImage = global::PateticoPractic.Properties.Resources.back_to_48;
            this.picArrawBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrawBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrawBack.Location = new System.Drawing.Point(1047, 12);
            this.picArrawBack.Name = "picArrawBack";
            this.picArrawBack.Size = new System.Drawing.Size(53, 46);
            this.picArrawBack.TabIndex = 115;
            this.picArrawBack.TabStop = false;
            this.picArrawBack.Click += new System.EventHandler(this.picArrawBack_Click);
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtitle.Font = new System.Drawing.Font("Cormorant Garamond", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSubtitle.Location = new System.Drawing.Point(101, 33);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(79, 23);
            this.labelSubtitle.TabIndex = 114;
            this.labelSubtitle.Text = "sweetshop";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Cormorant Garamond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.labelTitle.Location = new System.Drawing.Point(83, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(83, 29);
            this.labelTitle.TabIndex = 113;
            this.labelTitle.Text = "Patetico";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_double_chocolate_cake_64__1_;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(8, -5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(84, 72);
            this.picLogo.TabIndex = 112;
            this.picLogo.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_close_window_48;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(1105, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 46);
            this.picExit.TabIndex = 111;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // txtForName
            // 
            this.txtForName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtForName.Font = new System.Drawing.Font("Cormorant Garamond", 13.25F);
            this.txtForName.Location = new System.Drawing.Point(292, 97);
            this.txtForName.Multiline = true;
            this.txtForName.Name = "txtForName";
            this.txtForName.Size = new System.Drawing.Size(416, 30);
            this.txtForName.TabIndex = 117;
            this.txtForName.Text = "Введите название изделия для поиска";
            this.txtForName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtForName.Click += new System.EventHandler(this.txtForName_Click);
            // 
            // roundBtnSearch
            // 
            this.roundBtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.roundBtnSearch.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.roundBtnSearch.ButtonBorderColor = System.Drawing.Color.SlateGray;
            this.roundBtnSearch.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnSearch.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnSearch.ButtonHighlightForeColor = System.Drawing.Color.Maroon;
            this.roundBtnSearch.ButtonPressedColor = System.Drawing.Color.RosyBrown;
            this.roundBtnSearch.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundBtnSearch.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundBtnSearch.ButtonRoundRadius = 30;
            this.roundBtnSearch.Font = new System.Drawing.Font("Cormorant Garamond Light", 12F, System.Drawing.FontStyle.Bold);
            this.roundBtnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.roundBtnSearch.Location = new System.Drawing.Point(718, 94);
            this.roundBtnSearch.Name = "roundBtnSearch";
            this.roundBtnSearch.Size = new System.Drawing.Size(150, 35);
            this.roundBtnSearch.TabIndex = 118;
            this.roundBtnSearch.Text = "Найти товар";
            this.roundBtnSearch.Click += new System.EventHandler(this.roundBtnSearch_Click);
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
            this.roundBtnAdd.Location = new System.Drawing.Point(238, 487);
            this.roundBtnAdd.Name = "roundBtnAdd";
            this.roundBtnAdd.Size = new System.Drawing.Size(215, 40);
            this.roundBtnAdd.TabIndex = 108;
            this.roundBtnAdd.Text = "Добавить товар";
            this.roundBtnAdd.Click += new System.EventHandler(this.roundBtnAdd_Click);
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
            this.roundBtnChange.Location = new System.Drawing.Point(467, 487);
            this.roundBtnChange.Name = "roundBtnChange";
            this.roundBtnChange.Size = new System.Drawing.Size(215, 40);
            this.roundBtnChange.TabIndex = 109;
            this.roundBtnChange.Text = "Изменить товар";
            this.roundBtnChange.Click += new System.EventHandler(this.roundBtnChange_Click);
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
            this.roundBtnDelete.Location = new System.Drawing.Point(696, 487);
            this.roundBtnDelete.Name = "roundBtnDelete";
            this.roundBtnDelete.Size = new System.Drawing.Size(215, 40);
            this.roundBtnDelete.TabIndex = 110;
            this.roundBtnDelete.Text = "Удалить товар";
            this.roundBtnDelete.Click += new System.EventHandler(this.roundBtnDelete_Click);
            // 
            // ProductsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources.фон_шире;
            this.ClientSize = new System.Drawing.Size(1164, 564);
            this.ControlBox = false;
            this.Controls.Add(this.roundBtnSearch);
            this.Controls.Add(this.txtForName);
            this.Controls.Add(this.picArrawBack);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.roundBtnDelete);
            this.Controls.Add(this.roundBtnChange);
            this.Controls.Add(this.roundBtnAdd);
            this.Controls.Add(this.TableProducts);
            this.Controls.Add(this.labelTitleProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsAdmin";
            this.Load += new System.EventHandler(this.ProductsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableProducts;
        private System.Windows.Forms.Label labelTitleProd;
        private System.Windows.Forms.PictureBox picArrawBack;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.TextBox txtForName;
        private RoundButton roundBtnSearch;
        private RoundButton roundBtnAdd;
        private RoundButton roundBtnChange;
        private RoundButton roundBtnDelete;
    }
}