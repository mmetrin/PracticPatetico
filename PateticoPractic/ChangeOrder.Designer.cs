namespace PateticoPractic
{
    partial class ChangeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeOrder));
            this.roundBtnChange = new PateticoPractic.RoundButton();
            this.labelTitleChangeCategory = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.picArrawBack = new System.Windows.Forms.PictureBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pateticoPracticDataSet = new PateticoPractic.PateticoPracticDataSet();
            this.labelCategory = new System.Windows.Forms.Label();
            this.statusTableAdapter = new PateticoPractic.PateticoPracticDataSetTableAdapters.StatusTableAdapter();
            this.fKOrdersStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new PateticoPractic.PateticoPracticDataSetTableAdapters.OrdersTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateticoPracticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.roundBtnChange.Location = new System.Drawing.Point(133, 215);
            this.roundBtnChange.Name = "roundBtnChange";
            this.roundBtnChange.Size = new System.Drawing.Size(230, 40);
            this.roundBtnChange.TabIndex = 119;
            this.roundBtnChange.Text = "Изменить статус";
            this.roundBtnChange.Click += new System.EventHandler(this.roundBtnChange_Click);
            // 
            // labelTitleChangeCategory
            // 
            this.labelTitleChangeCategory.AutoSize = true;
            this.labelTitleChangeCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleChangeCategory.Font = new System.Drawing.Font("Cormorant Garamond Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleChangeCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleChangeCategory.Location = new System.Drawing.Point(94, 58);
            this.labelTitleChangeCategory.Name = "labelTitleChangeCategory";
            this.labelTitleChangeCategory.Size = new System.Drawing.Size(340, 39);
            this.labelTitleChangeCategory.TabIndex = 114;
            this.labelTitleChangeCategory.Text = "Измените статус заказа";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_double_chocolate_cake_64__1_;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogo.Location = new System.Drawing.Point(5, -2);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(84, 72);
            this.pictureLogo.TabIndex = 118;
            this.pictureLogo.TabStop = false;
            // 
            // picArrawBack
            // 
            this.picArrawBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrawBack.BackgroundImage = global::PateticoPractic.Properties.Resources.back_to_48;
            this.picArrawBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrawBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrawBack.Location = new System.Drawing.Point(439, 9);
            this.picArrawBack.Name = "picArrawBack";
            this.picArrawBack.Size = new System.Drawing.Size(53, 46);
            this.picArrawBack.TabIndex = 117;
            this.picArrawBack.TabStop = false;
            this.picArrawBack.Click += new System.EventHandler(this.picArrawBack_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.comboBoxStatus.DataSource = this.statusBindingSource;
            this.comboBoxStatus.DisplayMember = "status";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(128, 165);
            this.comboBoxStatus.MinimumSize = new System.Drawing.Size(234, 0);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(250, 21);
            this.comboBoxStatus.TabIndex = 142;
            this.comboBoxStatus.ValueMember = "id_status";
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
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.labelCategory.Font = new System.Drawing.Font("Cormorant Garamond", 14F, System.Drawing.FontStyle.Bold);
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.labelCategory.Location = new System.Drawing.Point(129, 139);
            this.labelCategory.MinimumSize = new System.Drawing.Size(250, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(250, 23);
            this.labelCategory.TabIndex = 141;
            this.labelCategory.Text = "Выберите статус";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // fKOrdersStatusBindingSource
            // 
            this.fKOrdersStatusBindingSource.DataMember = "FK_Orders_Status";
            this.fKOrdersStatusBindingSource.DataSource = this.statusBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.pateticoPracticDataSet;
            // 
            // ChangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources.фон_размыт;
            this.ClientSize = new System.Drawing.Size(504, 301);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.roundBtnChange);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.picArrawBack);
            this.Controls.Add(this.labelTitleChangeCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeOrder";
            this.Load += new System.EventHandler(this.ChangeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateticoPracticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundBtnChange;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.PictureBox picArrawBack;
        private System.Windows.Forms.Label labelTitleChangeCategory;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelCategory;
        private PateticoPracticDataSet pateticoPracticDataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private PateticoPracticDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource fKOrdersStatusBindingSource;
        private PateticoPracticDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
    }
}