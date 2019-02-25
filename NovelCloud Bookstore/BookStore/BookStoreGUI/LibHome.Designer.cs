namespace BookStoreGUI
{
    partial class LibHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkout_Cart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.view_Review = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksAgile6DB17DataSet1 = new BookStoreGUI.BooksAgile6DB17DataSet1();
            this.addToCart = new System.Windows.Forms.Button();
            this.add_to_Cart = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new BookStoreGUI.BooksAgile6DB17DataSet1TableAdapters.CategoryTableAdapter();
            this.Checkout = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksAgile6DB17DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkout_Cart, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.add_to_Cart, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.addToCart, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.view_Review, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.search_Box, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Checkout, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.339028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.086492F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.87934F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01708F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 1129);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Raleway Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Raleway Medium", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 251);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1378, 692);
            this.dataGridView1.TabIndex = 1;
            // 
            // checkout_Cart
            // 
            this.checkout_Cart.BackColor = System.Drawing.SystemColors.Control;
            this.checkout_Cart.BackgroundImage = global::BookStoreGUI.Properties.Resources.cart;
            this.checkout_Cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkout_Cart.FlatAppearance.BorderSize = 0;
            this.checkout_Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout_Cart.Location = new System.Drawing.Point(1187, 20);
            this.checkout_Cart.Margin = new System.Windows.Forms.Padding(220, 20, 3, 3);
            this.checkout_Cart.Name = "checkout_Cart";
            this.checkout_Cart.Size = new System.Drawing.Size(103, 88);
            this.checkout_Cart.TabIndex = 2;
            this.checkout_Cart.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(778, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(18, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categories:";
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(279, 200);
            this.search_Box.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(478, 38);
            this.search_Box.TabIndex = 5;
            this.search_Box.TextChanged += new System.EventHandler(this.search_Box_TextChanged);
            // 
            // view_Review
            // 
            this.view_Review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_Review.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_Review.Location = new System.Drawing.Point(1087, 976);
            this.view_Review.Margin = new System.Windows.Forms.Padding(120, 30, 3, 3);
            this.view_Review.Name = "view_Review";
            this.view_Review.Size = new System.Drawing.Size(262, 78);
            this.view_Review.TabIndex = 8;
            this.view_Review.Text = "View Reviews";
            this.view_Review.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(18, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by Title:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoryBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(970, 200);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(411, 39);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.booksAgile6DB17DataSet1;
            // 
            // booksAgile6DB17DataSet1
            // 
            this.booksAgile6DB17DataSet1.DataSetName = "BooksAgile6DB17DataSet1";
            this.booksAgile6DB17DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addToCart
            // 
            this.addToCart.BackColor = System.Drawing.SystemColors.Control;
            this.addToCart.BackgroundImage = global::BookStoreGUI.Properties.Resources.addfinal1;
            this.addToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addToCart.FlatAppearance.BorderSize = 0;
            this.addToCart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCart.Location = new System.Drawing.Point(180, 966);
            this.addToCart.Margin = new System.Windows.Forms.Padding(180, 20, 3, 3);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(93, 85);
            this.addToCart.TabIndex = 7;
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // add_to_Cart
            // 
            this.add_to_Cart.AutoSize = true;
            this.add_to_Cart.Font = new System.Drawing.Font("Verdana", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_to_Cart.Location = new System.Drawing.Point(279, 986);
            this.add_to_Cart.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.add_to_Cart.Name = "add_to_Cart";
            this.add_to_Cart.Size = new System.Drawing.Size(217, 41);
            this.add_to_Cart.TabIndex = 9;
            this.add_to_Cart.Text = "Add To Cart";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // Checkout
            // 
            this.Checkout.AutoSize = true;
            this.Checkout.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkout.Location = new System.Drawing.Point(1167, 123);
            this.Checkout.Margin = new System.Windows.Forms.Padding(200, 3, 3, 0);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(148, 34);
            this.Checkout.TabIndex = 10;
            this.Checkout.Text = "Checkout";
            // 
            // LibHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 1153);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LibHome";
            this.Text = "LibHome";
            this.Load += new System.EventHandler(this.LibHome_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksAgile6DB17DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button checkout_Cart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private BooksAgile6DB17DataSet1 booksAgile6DB17DataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private BooksAgile6DB17DataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button view_Review;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label add_to_Cart;
        private System.Windows.Forms.Label Checkout;
    }
}