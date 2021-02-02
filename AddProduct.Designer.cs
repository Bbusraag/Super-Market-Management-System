namespace ClassActivity
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
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnProductAdd.Location = new System.Drawing.Point(600, 284);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 40);
            this.btnProductAdd.TabIndex = 0;
            this.btnProductAdd.Text = "ADD";
            this.btnProductAdd.UseVisualStyleBackColor = false;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnProductDelete.Location = new System.Drawing.Point(159, 410);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 40);
            this.btnProductDelete.TabIndex = 1;
            this.btnProductDelete.Text = "DELETE";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnProductUpdate.Location = new System.Drawing.Point(711, 284);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnProductUpdate.TabIndex = 2;
            this.btnProductUpdate.Text = "UPDATE";
            this.btnProductUpdate.UseVisualStyleBackColor = false;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(588, 23);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(198, 20);
            this.tbProductId.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(588, 149);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(198, 20);
            this.tbPrice.TabIndex = 4;
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Location = new System.Drawing.Point(588, 216);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(198, 20);
            this.tbProductQuantity.TabIndex = 5;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(588, 74);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(198, 20);
            this.tbProductName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ProductID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(504, 81);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(35, 13);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "Name";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(504, 149);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(31, 13);
            this.lblProductPrice.TabIndex = 11;
            this.lblProductPrice.Text = "Price";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(504, 219);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblProductQuantity.TabIndex = 12;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(453, 52);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 326);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkGray;
            this.btnShow.Location = new System.Drawing.Point(18, 410);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 39);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(18, 23);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(316, 20);
            this.tbSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Location = new System.Drawing.Point(340, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(814, 481);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbProductQuantity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductAdd);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}