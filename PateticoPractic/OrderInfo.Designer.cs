namespace PateticoPractic
{
    partial class OrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInfo));
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.TableOrders = new System.Windows.Forms.DataGridView();
            this.labelTitleOrders = new System.Windows.Forms.Label();
            this.picArrawBack = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtitle.Font = new System.Drawing.Font("Cormorant Garamond", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSubtitle.Location = new System.Drawing.Point(97, 28);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(79, 23);
            this.labelSubtitle.TabIndex = 151;
            this.labelSubtitle.Text = "sweetshop";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Cormorant Garamond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.labelTitle.Location = new System.Drawing.Point(79, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(83, 29);
            this.labelTitle.TabIndex = 150;
            this.labelTitle.Text = "Patetico";
            // 
            // TableOrders
            // 
            this.TableOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.TableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOrders.Location = new System.Drawing.Point(63, 135);
            this.TableOrders.Margin = new System.Windows.Forms.Padding(2);
            this.TableOrders.Name = "TableOrders";
            this.TableOrders.RowTemplate.Height = 24;
            this.TableOrders.Size = new System.Drawing.Size(880, 300);
            this.TableOrders.TabIndex = 147;
            // 
            // labelTitleOrders
            // 
            this.labelTitleOrders.AutoSize = true;
            this.labelTitleOrders.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleOrders.Font = new System.Drawing.Font("Cormorant Garamond Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleOrders.Location = new System.Drawing.Point(360, 28);
            this.labelTitleOrders.Name = "labelTitleOrders";
            this.labelTitleOrders.Size = new System.Drawing.Size(284, 39);
            this.labelTitleOrders.TabIndex = 146;
            this.labelTitleOrders.Text = "Подробнее о заказе";
            // 
            // picArrawBack
            // 
            this.picArrawBack.BackColor = System.Drawing.Color.Transparent;
            this.picArrawBack.BackgroundImage = global::PateticoPractic.Properties.Resources.back_to_48;
            this.picArrawBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrawBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrawBack.Location = new System.Drawing.Point(890, 9);
            this.picArrawBack.Name = "picArrawBack";
            this.picArrawBack.Size = new System.Drawing.Size(53, 46);
            this.picArrawBack.TabIndex = 152;
            this.picArrawBack.TabStop = false;
            this.picArrawBack.Click += new System.EventHandler(this.picArrawBack_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_double_chocolate_cake_64__1_;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(4, -10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(84, 72);
            this.picLogo.TabIndex = 149;
            this.picLogo.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::PateticoPractic.Properties.Resources.icons8_close_window_48;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(948, 9);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 46);
            this.picExit.TabIndex = 148;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PateticoPractic.Properties.Resources.фон_шире;
            this.ClientSize = new System.Drawing.Size(1007, 509);
            this.ControlBox = false;
            this.Controls.Add(this.picArrawBack);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.TableOrders);
            this.Controls.Add(this.labelTitleOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderInfo";
            this.Load += new System.EventHandler(this.OrderInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrawBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picArrawBack;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.DataGridView TableOrders;
        private System.Windows.Forms.Label labelTitleOrders;
    }
}