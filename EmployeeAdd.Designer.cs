namespace ClassActivity
{
    partial class EmployeeAdd
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
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnEmployeADD = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblEmployeePassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.lblMesaage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(464, 167);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(81, 13);
            this.lblEmployeeEmail.TabIndex = 13;
            this.lblEmployeeEmail.Text = "Employee Email";
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.AutoSize = true;
            this.lblEmployeeSurname.Location = new System.Drawing.Point(464, 124);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(98, 13);
            this.lblEmployeeSurname.TabIndex = 12;
            this.lblEmployeeSurname.Text = "Employee Surname";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(464, 84);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(78, 13);
            this.lblEmployeeName.TabIndex = 11;
            this.lblEmployeeName.Text = "Employe Name";
            // 
            // btnEmployeADD
            // 
            this.btnEmployeADD.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmployeADD.Location = new System.Drawing.Point(545, 271);
            this.btnEmployeADD.Name = "btnEmployeADD";
            this.btnEmployeADD.Size = new System.Drawing.Size(121, 50);
            this.btnEmployeADD.TabIndex = 10;
            this.btnEmployeADD.Text = "ADD";
            this.btnEmployeADD.UseVisualStyleBackColor = false;
            this.btnEmployeADD.Click += new System.EventHandler(this.btnEmployeADD_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(573, 164);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(222, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(573, 121);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(222, 20);
            this.tbSurname.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(575, 77);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(222, 20);
            this.tbName.TabIndex = 7;
            // 
            // lblEmployeePassword
            // 
            this.lblEmployeePassword.AutoSize = true;
            this.lblEmployeePassword.Location = new System.Drawing.Point(460, 211);
            this.lblEmployeePassword.Name = "lblEmployeePassword";
            this.lblEmployeePassword.Size = new System.Drawing.Size(102, 13);
            this.lblEmployeePassword.TabIndex = 14;
            this.lblEmployeePassword.Text = "Employee Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(573, 208);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(220, 20);
            this.tbPassword.TabIndex = 15;
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeDelete.Location = new System.Drawing.Point(152, 441);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(112, 66);
            this.btnEmployeeDelete.TabIndex = 16;
            this.btnEmployeeDelete.Text = "DELETE";
            this.btnEmployeeDelete.UseVisualStyleBackColor = false;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(697, 271);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(91, 50);
            this.btnEmployeeUpdate.TabIndex = 17;
            this.btnEmployeeUpdate.Text = "UPDATE";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = false;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // lblMesaage
            // 
            this.lblMesaage.AutoSize = true;
            this.lblMesaage.Location = new System.Drawing.Point(12, 27);
            this.lblMesaage.Name = "lblMesaage";
            this.lblMesaage.Size = new System.Drawing.Size(0, 13);
            this.lblMesaage.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "EmployeeID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(573, 27);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(224, 20);
            this.TxtID.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 351);
            this.dataGridView1.TabIndex = 21;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(18, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(285, 20);
            this.tbSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Location = new System.Drawing.Point(333, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkGray;
            this.btnShow.Location = new System.Drawing.Point(33, 441);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(97, 66);
            this.btnShow.TabIndex = 24;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // EmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(823, 537);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMesaage);
            this.Controls.Add(this.btnEmployeeUpdate);
            this.Controls.Add(this.btnEmployeeDelete);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblEmployeePassword);
            this.Controls.Add(this.lblEmployeeEmail);
            this.Controls.Add(this.lblEmployeeSurname);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.btnEmployeADD);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Name = "EmployeeAdd";
            this.Text = "EmployeeAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnEmployeADD;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblEmployeePassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Label lblMesaage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShow;
    }
}