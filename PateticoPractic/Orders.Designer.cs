namespace PateticoPractic
{
    partial class Orders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.roundBtnSearch = new PateticoPractic.RoundButton();
            this.picArrawBack = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.TableOrders = new System.Windows.Forms.DataGridView();
            this.labelTitleOrders = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pateticoPracticDataSet = new PateticoPractic.PateticoPracticDataSet();
            this.labelStatus = new System.Windows.Forms.Label();
            this.roundBtnDelete = new PateticoPractic.RoundButton();
            this.roundBtnInfo = new PateticoPractic.RoundButton();
            this.roundBtnChange = new PateticoPractic.RoundButton();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new PateticoPractic.PateticoPracticDataSetTableAdapters.OrdersTableAdapter();
            this.statusTableAdapter = new PateticoPractic.PateticoPracticDataSetTableAdapters.StatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateticoPracticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.roundBtnSearch.Location = new System.Drawing.Point(628, 98);
            this.roundBtnSearch.Name = "roundBtnSearch";
            this.roundBtnSearch.Size = new System.Drawing.Size(180, 35);
            this.roundBtnSearch.TabIndex = 130;
            this.roundBtnSearch.Text = "Найти заказы";
            this.roundBtnSearch.Click += new System.EventHandler(this.roundBtnSearch_Click);
            // 
            // picArrawBack
            // 
            this.picArrawBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrawBack.BackgroundImage = global::PateticoPractic.Properties.Resources.back_to_48;
            this.picArrawBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrawBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrawBack.Location = new System.Drawing.Point(894, 12);
            this.picArrawBack.Name = "picArrawBack";
            this.picArrawBack.Size = new System.Drawing.Size(53, 46);
            this.picArrawBack.TabIndex = 128;
            this.picArrawBack.TabStop = false;
            this.picArrawBack.Click += new System.EventHandler(this.picArrawBack_Click);
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtitle.Font = new System.Drawing.Font("Cormorant Garamond", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSubtitle.Location = new System.Drawing.Point(101, 31);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(79, 23);
            this.labelSubtitle.TabIndex = 127;
            this.labelSubtitle.Text = "sweetshop";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Cormorant Garamond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.labelTitle.Location = new System.Drawing.Point(83, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(83, 29);
            this.labelTitle.TabIndex = 126;
            this.labelTitle.Text = "Patetico";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_double_chocolate_cake_64__1_;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(8, -7);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(84, 72);
            this.picLogo.TabIndex = 125;
            this.picLogo.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_close_window_48;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(952, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 46);
            this.picExit.TabIndex = 124;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // TableOrders
            // 
            this.TableOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TableOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.TableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOrders.Location = new System.Drawing.Point(62, 156);
            this.TableOrders.Margin = new System.Windows.Forms.Padding(2);
            this.TableOrders.Name = "TableOrders";
            this.TableOrders.RowTemplate.Height = 24;
            this.TableOrders.Size = new System.Drawing.Size(880, 300);
            this.TableOrders.TabIndex = 120;
            this.TableOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableOrders_CellClick);
            // 
            // labelTitleOrders
            // 
            this.labelTitleOrders.AutoSize = true;
            this.labelTitleOrders.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleOrders.Font = new System.Drawing.Font("Cormorant Garamond Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleOrders.Location = new System.Drawing.Point(364, 31);
            this.labelTitleOrders.Name = "labelTitleOrders";
            this.labelTitleOrders.Size = new System.Drawing.Size(278, 39);
            this.labelTitleOrders.TabIndex = 119;
            this.labelTitleOrders.Text = "Клиентские заказы";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.comboBoxStatus.DataSource = this.statusBindingSource;
            this.comboBoxStatus.DisplayMember = "status";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(410, 106);
            this.comboBoxStatus.MinimumSize = new System.Drawing.Size(20, 0);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStatus.TabIndex = 141;
            this.comboBoxStatus.ValueMember = "status";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.pateticoPracticDataSet;
            // 
            // pateticoPracticDataSet
            // 
            this.pateticoPracticDataSet.DataSetName = "PateticoPracticDataSet";
            this.pateticoPracticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.labelStatus.Font = new System.Drawing.Font("Cormorant Garamond", 14F, System.Drawing.FontStyle.Bold);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.labelStatus.Location = new System.Drawing.Point(201, 105);
            this.labelStatus.MinimumSize = new System.Drawing.Size(200, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(200, 23);
            this.labelStatus.TabIndex = 142;
            this.labelStatus.Text = "Выберите статус заказа";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.roundBtnDelete.Location = new System.Drawing.Point(665, 479);
            this.roundBtnDelete.Name = "roundBtnDelete";
            this.roundBtnDelete.Size = new System.Drawing.Size(235, 40);
            this.roundBtnDelete.TabIndex = 145;
            this.roundBtnDelete.Text = "Удалить данный заказ";
            this.roundBtnDelete.Click += new System.EventHandler(this.roundBtnDelete_Click);
            // 
            // roundBtnInfo
            // 
            this.roundBtnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.roundBtnInfo.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.roundBtnInfo.ButtonBorderColor = System.Drawing.Color.SlateGray;
            this.roundBtnInfo.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnInfo.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.roundBtnInfo.ButtonHighlightForeColor = System.Drawing.Color.Maroon;
            this.roundBtnInfo.ButtonPressedColor = System.Drawing.Color.RosyBrown;
            this.roundBtnInfo.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundBtnInfo.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundBtnInfo.ButtonRoundRadius = 30;
            this.roundBtnInfo.Font = new System.Drawing.Font("Cormorant Garamond Medium", 15F, System.Drawing.FontStyle.Bold);
            this.roundBtnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.roundBtnInfo.Location = new System.Drawing.Point(384, 479);
            this.roundBtnInfo.Name = "roundBtnInfo";
            this.roundBtnInfo.Size = new System.Drawing.Size(235, 40);
            this.roundBtnInfo.TabIndex = 144;
            this.roundBtnInfo.Text = "Подробнее о заказе";
            this.roundBtnInfo.Click += new System.EventHandler(this.roundBtnInfo_Click);
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
            this.roundBtnChange.Location = new System.Drawing.Point(105, 479);
            this.roundBtnChange.Name = "roundBtnChange";
            this.roundBtnChange.Size = new System.Drawing.Size(235, 40);
            this.roundBtnChange.TabIndex = 143;
            this.roundBtnChange.Text = "Изменить статус заказа";
            this.roundBtnChange.Click += new System.EventHandler(this.roundBtnChange_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.pateticoPracticDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources.фон_шире;
            this.ClientSize = new System.Drawing.Size(1007, 564);
            this.ControlBox = false;
            this.Controls.Add(this.roundBtnDelete);
            this.Controls.Add(this.roundBtnInfo);
            this.Controls.Add(this.roundBtnChange);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.roundBtnSearch);
            this.Controls.Add(this.picArrawBack);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.TableOrders);
            this.Controls.Add(this.labelTitleOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateticoPracticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundBtnSearch;
        private System.Windows.Forms.PictureBox picArrawBack;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.DataGridView TableOrders;
        private System.Windows.Forms.Label labelTitleOrders;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private RoundButton roundBtnDelete;
        private RoundButton roundBtnInfo;
        private RoundButton roundBtnChange;
        private PateticoPracticDataSet pateticoPracticDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private PateticoPracticDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private PateticoPracticDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
    }
}