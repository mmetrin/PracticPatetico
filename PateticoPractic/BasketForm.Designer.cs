namespace PateticoPractic
{
    partial class BasketForm
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
            this.tableForProduct = new System.Windows.Forms.DataGridView();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            this.labForPrice = new System.Windows.Forms.Label();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pateticoPracticDataSet1 = new PateticoPractic.PateticoPracticDataSet1();
            this.labelShop = new System.Windows.Forms.Label();
            this.shopsTableAdapter = new PateticoPractic.PateticoPracticDataSet1TableAdapters.ShopsTableAdapter();
            this.labelBack = new System.Windows.Forms.Label();
            this.picArrowBack = new System.Windows.Forms.PictureBox();
            this.roundBtnDelete = new PateticoPractic.RoundButton();
            this.roundBtnPlace = new PateticoPractic.RoundButton();
            this.labelValute = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labTimeOfWork = new System.Windows.Forms.Label();
            this.labelForTimeOfWork = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableForProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateticoPracticDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tableForProduct
            // 
            this.tableForProduct.AllowUserToAddRows = false;
            this.tableForProduct.AllowUserToDeleteRows = false;
            this.tableForProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableForProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.tableForProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableForProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForProduct.Location = new System.Drawing.Point(369, 96);
            this.tableForProduct.Name = "tableForProduct";
            this.tableForProduct.ReadOnly = true;
            this.tableForProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableForProduct.Size = new System.Drawing.Size(593, 264);
            this.tableForProduct.TabIndex = 0;
            this.tableForProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableForProduct_CellClick);
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelFinalPrice.Font = new System.Drawing.Font("Cormorant Infant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.labelFinalPrice.Location = new System.Drawing.Point(369, 434);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(215, 26);
            this.labelFinalPrice.TabIndex = 160;
            this.labelFinalPrice.Text = "Общая сумма к оплате";
            // 
            // labForPrice
            // 
            this.labForPrice.AutoSize = true;
            this.labForPrice.Font = new System.Drawing.Font("Cormorant Infant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labForPrice.Location = new System.Drawing.Point(586, 434);
            this.labForPrice.Name = "labForPrice";
            this.labForPrice.Size = new System.Drawing.Size(0, 26);
            this.labForPrice.TabIndex = 161;
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.comboBoxShop.DataSource = this.shopsBindingSource;
            this.comboBoxShop.DisplayMember = "address";
            this.comboBoxShop.Font = new System.Drawing.Font("Cormorant Infant", 13.75F);
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(461, 480);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(240, 30);
            this.comboBoxShop.TabIndex = 162;
            this.comboBoxShop.ValueMember = "id_shop";
            this.comboBoxShop.SelectionChangeCommitted += new System.EventHandler(this.comboBoxShop_SelectionChangeCommitted);
            // 
            // shopsBindingSource
            // 
            this.shopsBindingSource.DataMember = "Shops";
            this.shopsBindingSource.DataSource = this.pateticoPracticDataSet1;
            // 
            // pateticoPracticDataSet1
            // 
            this.pateticoPracticDataSet1.DataSetName = "PateticoPracticDataSet1";
            this.pateticoPracticDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.BackColor = System.Drawing.Color.Transparent;
            this.labelShop.Font = new System.Drawing.Font("Cormorant Infant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.labelShop.Location = new System.Drawing.Point(372, 481);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(86, 26);
            this.labelShop.TabIndex = 163;
            this.labelShop.Text = "Магазин";
            // 
            // shopsTableAdapter
            // 
            this.shopsTableAdapter.ClearBeforeFill = true;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Cormorant Unicase", 13.25F);
            this.labelBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.labelBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBack.Location = new System.Drawing.Point(63, 27);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(140, 22);
            this.labelBack.TabIndex = 188;
            this.labelBack.Text = "В главное меню";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // picArrowBack
            // 
            this.picArrowBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrowBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrowBack.Image = global::PateticoPractic.Properties.Resources.arrow;
            this.picArrowBack.Location = new System.Drawing.Point(24, 19);
            this.picArrowBack.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowBack.Name = "picArrowBack";
            this.picArrowBack.Size = new System.Drawing.Size(38, 41);
            this.picArrowBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowBack.TabIndex = 187;
            this.picArrowBack.TabStop = false;
            this.picArrowBack.Click += new System.EventHandler(this.picArrowBack_Click);
            // 
            // roundBtnDelete
            // 
            this.roundBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.roundBtnDelete.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.roundBtnDelete.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.roundBtnDelete.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.roundBtnDelete.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.roundBtnDelete.ButtonHighlightForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundBtnDelete.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.roundBtnDelete.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            this.roundBtnDelete.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundBtnDelete.ButtonRoundRadius = 30;
            this.roundBtnDelete.Font = new System.Drawing.Font("Cormorant Garamond Medium", 15F, System.Drawing.FontStyle.Bold);
            this.roundBtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.roundBtnDelete.Location = new System.Drawing.Point(718, 432);
            this.roundBtnDelete.Name = "roundBtnDelete";
            this.roundBtnDelete.Size = new System.Drawing.Size(244, 60);
            this.roundBtnDelete.TabIndex = 189;
            this.roundBtnDelete.Text = "Удалить товар";
            this.roundBtnDelete.Click += new System.EventHandler(this.roundBtnDelete_Click);
            // 
            // roundBtnPlace
            // 
            this.roundBtnPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.roundBtnPlace.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.roundBtnPlace.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.roundBtnPlace.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.roundBtnPlace.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.roundBtnPlace.ButtonHighlightForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundBtnPlace.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.roundBtnPlace.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            this.roundBtnPlace.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundBtnPlace.ButtonRoundRadius = 30;
            this.roundBtnPlace.Font = new System.Drawing.Font("Cormorant Garamond Medium", 15F, System.Drawing.FontStyle.Bold);
            this.roundBtnPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.roundBtnPlace.Location = new System.Drawing.Point(718, 515);
            this.roundBtnPlace.Name = "roundBtnPlace";
            this.roundBtnPlace.Size = new System.Drawing.Size(244, 60);
            this.roundBtnPlace.TabIndex = 190;
            this.roundBtnPlace.Text = "Оформить заказ";
            this.roundBtnPlace.Click += new System.EventHandler(this.roundBtnPlace_Click);
            // 
            // labelValute
            // 
            this.labelValute.AutoSize = true;
            this.labelValute.BackColor = System.Drawing.Color.Transparent;
            this.labelValute.Font = new System.Drawing.Font("Cormorant Infant", 12.75F);
            this.labelValute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.labelValute.Location = new System.Drawing.Point(662, 439);
            this.labelValute.Name = "labelValute";
            this.labelValute.Size = new System.Drawing.Size(47, 21);
            this.labelValute.TabIndex = 192;
            this.labelValute.Text = "(руб.)";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.BackColor = System.Drawing.Color.Transparent;
            this.labelOrder.Font = new System.Drawing.Font("Cormorant Infant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(42)))), ((int)(((byte)(37)))));
            this.labelOrder.Location = new System.Drawing.Point(371, 386);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(577, 29);
            this.labelOrder.TabIndex = 193;
            this.labelOrder.Text = "Выбирайте магазин и оформляйте заказ прямо сейчас!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cormorant Unicase SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(72)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(565, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 35);
            this.label1.TabIndex = 194;
            this.label1.Text = "Ваша корзина";
            // 
            // labTimeOfWork
            // 
            this.labTimeOfWork.AutoSize = true;
            this.labTimeOfWork.Font = new System.Drawing.Font("Cormorant Infant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTimeOfWork.Location = new System.Drawing.Point(597, 532);
            this.labTimeOfWork.Name = "labTimeOfWork";
            this.labTimeOfWork.Size = new System.Drawing.Size(0, 26);
            this.labTimeOfWork.TabIndex = 196;
            // 
            // labelForTimeOfWork
            // 
            this.labelForTimeOfWork.AutoSize = true;
            this.labelForTimeOfWork.BackColor = System.Drawing.Color.Transparent;
            this.labelForTimeOfWork.Font = new System.Drawing.Font("Cormorant Infant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForTimeOfWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.labelForTimeOfWork.Location = new System.Drawing.Point(372, 532);
            this.labelForTimeOfWork.Name = "labelForTimeOfWork";
            this.labelForTimeOfWork.Size = new System.Drawing.Size(223, 26);
            this.labelForTimeOfWork.TabIndex = 195;
            this.labelForTimeOfWork.Text = "Время работы магазина";
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources._233;
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.labTimeOfWork);
            this.Controls.Add(this.labelForTimeOfWork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelValute);
            this.Controls.Add(this.roundBtnPlace);
            this.Controls.Add(this.roundBtnDelete);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.picArrowBack);
            this.Controls.Add(this.labelShop);
            this.Controls.Add(this.comboBoxShop);
            this.Controls.Add(this.labForPrice);
            this.Controls.Add(this.labelFinalPrice);
            this.Controls.Add(this.tableForProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasketForm";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableForProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateticoPracticDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableForProduct;
        private System.Windows.Forms.Label labelFinalPrice;
        private System.Windows.Forms.Label labForPrice;
        private System.Windows.Forms.ComboBox comboBoxShop;
        private System.Windows.Forms.Label labelShop;
        private PateticoPracticDataSet1 pateticoPracticDataSet1;
        private System.Windows.Forms.BindingSource shopsBindingSource;
        private PateticoPracticDataSet1TableAdapters.ShopsTableAdapter shopsTableAdapter;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.PictureBox picArrowBack;
        private RoundButton roundBtnDelete;
        private RoundButton roundBtnPlace;
        private System.Windows.Forms.Label labelValute;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTimeOfWork;
        private System.Windows.Forms.Label labelForTimeOfWork;
    }
}