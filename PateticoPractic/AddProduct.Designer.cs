namespace PateticoPractic
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.roundBtnChange = new PateticoPractic.RoundButton();
            this.labelWeight = new System.Windows.Forms.Label();
            this.txtForWeight = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picArrawBack = new System.Windows.Forms.PictureBox();
            this.txtForDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.comboBoxParameters = new System.Windows.Forms.ComboBox();
            this.parametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pateticoPracticDataSet = new PateticoPractic.PateticoPracticDataSet();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtForPrice = new System.Windows.Forms.TextBox();
            this.labelNameProd = new System.Windows.Forms.Label();
            this.txtForProductName = new System.Windows.Forms.TextBox();
            this.labelTitleChangeProd = new System.Windows.Forms.Label();
            this.parametersTableAdapter = new PateticoPractic.PateticoPracticDataSetTableAdapters.ParametersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateticoPracticDataSet)).BeginInit();
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
            this.roundBtnChange.Location = new System.Drawing.Point(97, 355);
            this.roundBtnChange.Name = "roundBtnChange";
            this.roundBtnChange.Size = new System.Drawing.Size(250, 40);
            this.roundBtnChange.TabIndex = 147;
            this.roundBtnChange.Text = "Добавить товар";
            this.roundBtnChange.Click += new System.EventHandler(this.roundBtnChange_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.labelWeight.Font = new System.Drawing.Font("Cormorant Garamond", 14F, System.Drawing.FontStyle.Bold);
            this.labelWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.labelWeight.Location = new System.Drawing.Point(98, 275);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(93, 23);
            this.labelWeight.TabIndex = 146;
            this.labelWeight.Text = "Вес товара";
            // 
            // txtForWeight
            // 
            this.txtForWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtForWeight.Font = new System.Drawing.Font("Cormorant Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtForWeight.Location = new System.Drawing.Point(97, 298);
            this.txtForWeight.Multiline = true;
            this.txtForWeight.Name = "txtForWeight";
            this.txtForWeight.Size = new System.Drawing.Size(250, 30);
            this.txtForWeight.TabIndex = 145;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_double_chocolate_cake_64__1_;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(10, -3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(84, 72);
            this.picLogo.TabIndex = 144;
            this.picLogo.TabStop = false;
            // 
            // picArrawBack
            // 
            this.picArrawBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrawBack.BackgroundImage = global::PateticoPractic.Properties.Resources.back_to_48;
            this.picArrawBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrawBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrawBack.Location = new System.Drawing.Point(735, 13);
            this.picArrawBack.Name = "picArrawBack";
            this.picArrawBack.Size = new System.Drawing.Size(53, 46);
            this.picArrawBack.TabIndex = 143;
            this.picArrawBack.TabStop = false;
            this.picArrawBack.Click += new System.EventHandler(this.picArrawBack_Click);
            // 
            // txtForDescription
            // 
            this.txtForDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtForDescription.Font = new System.Drawing.Font("Cormorant Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtForDescription.Location = new System.Drawing.Point(442, 153);
            this.txtForDescription.Multiline = true;
            this.txtForDescription.Name = "txtForDescription";
            this.txtForDescription.Size = new System.Drawing.Size(250, 169);
            this.txtForDescription.TabIndex = 142;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Cormorant Garamond", 14F, System.Drawing.FontStyle.Bold);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.labelDescription.Location = new System.Drawing.Point(443, 129);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(145, 23);
            this.labelDescription.TabIndex = 141;
            this.labelDescription.Text = "Описание товара";
            // 
            // comboBoxParameters
            // 
            this.comboBoxParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.comboBoxParameters.DataSource = this.parametersBindingSource;
            this.comboBoxParameters.DisplayMember = "parameter";
            this.comboBoxParameters.FormattingEnabled = true;
            this.comboBoxParameters.Location = new System.Drawing.Point(442, 374);
            this.comboBoxParameters.MinimumSize = new System.Drawing.Size(234, 0);
            this.comboBoxParameters.Name = "comboBoxParameters";
            this.comboBoxParameters.Size = new System.Drawing.Size(250, 21);
            this.comboBoxParameters.TabIndex = 140;
            this.comboBoxParameters.ValueMember = "id_parameter";
            // 
            // parametersBindingSource
            // 
            this.parametersBindingSource.DataMember = "Parameters";
            this.parametersBindingSource.DataSource = this.pateticoPracticDataSet;
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
            this.labelCategory.Location = new System.Drawing.Point(443, 348);
            this.labelCategory.MinimumSize = new System.Drawing.Size(250, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(250, 23);
            this.labelCategory.TabIndex = 139;
            this.labelCategory.Text = "Выберите категорию изделия";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.labelPrice.Font = new System.Drawing.Font("Cormorant Garamond", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.labelPrice.Location = new System.Drawing.Point(98, 202);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(106, 23);
            this.labelPrice.TabIndex = 138;
            this.labelPrice.Text = "Цена товара";
            // 
            // txtForPrice
            // 
            this.txtForPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtForPrice.Font = new System.Drawing.Font("Cormorant Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtForPrice.Location = new System.Drawing.Point(97, 225);
            this.txtForPrice.Multiline = true;
            this.txtForPrice.Name = "txtForPrice";
            this.txtForPrice.Size = new System.Drawing.Size(250, 30);
            this.txtForPrice.TabIndex = 137;
            // 
            // labelNameProd
            // 
            this.labelNameProd.AutoSize = true;
            this.labelNameProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.labelNameProd.Font = new System.Drawing.Font("Cormorant Garamond", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.labelNameProd.Location = new System.Drawing.Point(97, 130);
            this.labelNameProd.Name = "labelNameProd";
            this.labelNameProd.Size = new System.Drawing.Size(182, 23);
            this.labelNameProd.TabIndex = 136;
            this.labelNameProd.Text = "Наименование товара";
            // 
            // txtForProductName
            // 
            this.txtForProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtForProductName.Font = new System.Drawing.Font("Cormorant Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtForProductName.Location = new System.Drawing.Point(97, 153);
            this.txtForProductName.Multiline = true;
            this.txtForProductName.Name = "txtForProductName";
            this.txtForProductName.Size = new System.Drawing.Size(250, 30);
            this.txtForProductName.TabIndex = 135;
            // 
            // labelTitleChangeProd
            // 
            this.labelTitleChangeProd.AutoSize = true;
            this.labelTitleChangeProd.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleChangeProd.Font = new System.Drawing.Font("Cormorant Garamond Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleChangeProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleChangeProd.Location = new System.Drawing.Point(281, 47);
            this.labelTitleChangeProd.Name = "labelTitleChangeProd";
            this.labelTitleChangeProd.Size = new System.Drawing.Size(228, 39);
            this.labelTitleChangeProd.TabIndex = 134;
            this.labelTitleChangeProd.Text = "Добавьте товар";
            // 
            // parametersTableAdapter
            // 
            this.parametersTableAdapter.ClearBeforeFill = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources.фон_размыт;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.roundBtnChange);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.txtForWeight);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picArrawBack);
            this.Controls.Add(this.txtForDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.comboBoxParameters);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.txtForPrice);
            this.Controls.Add(this.labelNameProd);
            this.Controls.Add(this.txtForProductName);
            this.Controls.Add(this.labelTitleChangeProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateticoPracticDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundBtnChange;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox txtForWeight;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picArrawBack;
        private System.Windows.Forms.TextBox txtForDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ComboBox comboBoxParameters;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtForPrice;
        private System.Windows.Forms.Label labelNameProd;
        private System.Windows.Forms.TextBox txtForProductName;
        private System.Windows.Forms.Label labelTitleChangeProd;
        private PateticoPracticDataSet pateticoPracticDataSet;
        private System.Windows.Forms.BindingSource parametersBindingSource;
        private PateticoPracticDataSetTableAdapters.ParametersTableAdapter parametersTableAdapter;
    }
}