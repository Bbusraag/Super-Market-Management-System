namespace ClassActivity
{
    partial class OrderAdd
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
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.tbCreationDate = new System.Windows.Forms.TextBox();
            this.tbPaymentDate = new System.Windows.Forms.TextBox();
            this.tbDeliveryDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(602, 32);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(218, 20);
            this.tbOrderID.TabIndex = 0;
            // 
            // tbCreationDate
            // 
            this.tbCreationDate.Location = new System.Drawing.Point(602, 84);
            this.tbCreationDate.Name = "tbCreationDate";
            this.tbCreationDate.Size = new System.Drawing.Size(218, 20);
            this.tbCreationDate.TabIndex = 1;
            // 
            // tbPaymentDate
            // 
            this.tbPaymentDate.Location = new System.Drawing.Point(602, 204);
            this.tbPaymentDate.Name = "tbPaymentDate";
            this.tbPaymentDate.Size = new System.Drawing.Size(218, 20);
            this.tbPaymentDate.TabIndex = 2;
            // 
            // tbDeliveryDate
            // 
            this.tbDeliveryDate.Location = new System.Drawing.Point(602, 134);
            this.tbDeliveryDate.Name = "tbDeliveryDate";
            this.tbDeliveryDate.Size = new System.Drawing.Size(218, 20);
            this.tbDeliveryDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice Creation Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delivery Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payment Due Date";
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnOrderAdd.Location = new System.Drawing.Point(602, 288);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(75, 47);
            this.btnOrderAdd.TabIndex = 8;
            this.btnOrderAdd.Text = "ADD";
            this.btnOrderAdd.UseVisualStyleBackColor = false;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnOrderDelete.Location = new System.Drawing.Point(138, 406);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(75, 47);
            this.btnOrderDelete.TabIndex = 9;
            this.btnOrderDelete.Text = "DELETE";
            this.btnOrderDelete.UseVisualStyleBackColor = false;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click_1);
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnOrderUpdate.Location = new System.Drawing.Point(754, 287);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(75, 48);
            this.btnOrderUpdate.TabIndex = 10;
            this.btnOrderUpdate.Text = "UPDATE";
            this.btnOrderUpdate.UseVisualStyleBackColor = false;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(432, 39);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(10, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 284);
            this.dataGridView1.TabIndex = 12;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(264, 20);
            this.tbSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Location = new System.Drawing.Point(297, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(12, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "SHOW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(878, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOrderUpdate);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDeliveryDate);
            this.Controls.Add(this.tbPaymentDate);
            this.Controls.Add(this.tbCreationDate);
            this.Controls.Add(this.tbOrderID);
            this.Name = "OrderAdd";
            this.Text = "OrderAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.TextBox tbCreationDate;
        private System.Windows.Forms.TextBox tbPaymentDate;
        private System.Windows.Forms.TextBox tbDeliveryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderUpdate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
    }
}