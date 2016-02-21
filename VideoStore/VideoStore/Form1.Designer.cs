namespace VideoStore
{
    partial class Form1
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
            this.gbxCustomers = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNextCust = new System.Windows.Forms.Button();
            this.btnPrevCust = new System.Windows.Forms.Button();
            this.txtNumRented = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblVideos = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxVideos = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNextVideo = new System.Windows.Forms.Button();
            this.btnPrevVideo = new System.Windows.Forms.Button();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxCustomers.SuspendLayout();
            this.gbxVideos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCustomers
            // 
            this.gbxCustomers.Controls.Add(this.btnClear);
            this.gbxCustomers.Controls.Add(this.txtTotalFee);
            this.gbxCustomers.Controls.Add(this.lblTotal);
            this.gbxCustomers.Controls.Add(this.btnNextCust);
            this.gbxCustomers.Controls.Add(this.btnPrevCust);
            this.gbxCustomers.Controls.Add(this.txtNumRented);
            this.gbxCustomers.Controls.Add(this.txtPhone);
            this.gbxCustomers.Controls.Add(this.txtAddress);
            this.gbxCustomers.Controls.Add(this.txtName);
            this.gbxCustomers.Controls.Add(this.lblVideos);
            this.gbxCustomers.Controls.Add(this.lblPhone);
            this.gbxCustomers.Controls.Add(this.label6);
            this.gbxCustomers.Controls.Add(this.lblName);
            this.gbxCustomers.Location = new System.Drawing.Point(14, 12);
            this.gbxCustomers.Name = "gbxCustomers";
            this.gbxCustomers.Size = new System.Drawing.Size(246, 185);
            this.gbxCustomers.TabIndex = 0;
            this.gbxCustomers.TabStop = false;
            this.gbxCustomers.Text = "Customers";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(86, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTotalFee
            // 
            this.txtTotalFee.Location = new System.Drawing.Point(157, 97);
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.ReadOnly = true;
            this.txtTotalFee.Size = new System.Drawing.Size(83, 20);
            this.txtTotalFee.TabIndex = 11;
            this.txtTotalFee.TabStop = false;
            this.txtTotalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(99, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Fee";
            // 
            // btnNextCust
            // 
            this.btnNextCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextCust.Location = new System.Drawing.Point(157, 125);
            this.btnNextCust.Name = "btnNextCust";
            this.btnNextCust.Size = new System.Drawing.Size(40, 23);
            this.btnNextCust.TabIndex = 9;
            this.btnNextCust.Text = ">";
            this.btnNextCust.UseVisualStyleBackColor = true;
            this.btnNextCust.Click += new System.EventHandler(this.btnNextCust_Click);
            // 
            // btnPrevCust
            // 
            this.btnPrevCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevCust.Location = new System.Drawing.Point(53, 125);
            this.btnPrevCust.Name = "btnPrevCust";
            this.btnPrevCust.Size = new System.Drawing.Size(40, 23);
            this.btnPrevCust.TabIndex = 8;
            this.btnPrevCust.Text = "<";
            this.btnPrevCust.UseVisualStyleBackColor = true;
            this.btnPrevCust.Click += new System.EventHandler(this.btnPrevCust_Click);
            // 
            // txtNumRented
            // 
            this.txtNumRented.Location = new System.Drawing.Point(53, 97);
            this.txtNumRented.Name = "txtNumRented";
            this.txtNumRented.ReadOnly = true;
            this.txtNumRented.Size = new System.Drawing.Size(40, 20);
            this.txtNumRented.TabIndex = 7;
            this.txtNumRented.TabStop = false;
            this.txtNumRented.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(53, 71);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(187, 20);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(53, 45);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(187, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 19);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TabStop = false;
            // 
            // lblVideos
            // 
            this.lblVideos.AutoSize = true;
            this.lblVideos.Location = new System.Drawing.Point(6, 100);
            this.lblVideos.Name = "lblVideos";
            this.lblVideos.Size = new System.Drawing.Size(39, 13);
            this.lblVideos.TabIndex = 3;
            this.lblVideos.Text = "Videos";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 74);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // gbxVideos
            // 
            this.gbxVideos.Controls.Add(this.btnAdd);
            this.gbxVideos.Controls.Add(this.btnNextVideo);
            this.gbxVideos.Controls.Add(this.btnPrevVideo);
            this.gbxVideos.Controls.Add(this.txtFee);
            this.gbxVideos.Controls.Add(this.txtCopies);
            this.gbxVideos.Controls.Add(this.txtType);
            this.gbxVideos.Controls.Add(this.txtTitle);
            this.gbxVideos.Controls.Add(this.lblFee);
            this.gbxVideos.Controls.Add(this.lblCopies);
            this.gbxVideos.Controls.Add(this.lblType);
            this.gbxVideos.Controls.Add(this.lblTitle);
            this.gbxVideos.Location = new System.Drawing.Point(266, 12);
            this.gbxVideos.Name = "gbxVideos";
            this.gbxVideos.Size = new System.Drawing.Size(246, 185);
            this.gbxVideos.TabIndex = 1;
            this.gbxVideos.TabStop = false;
            this.gbxVideos.Text = "Videos";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(86, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNextVideo
            // 
            this.btnNextVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextVideo.Location = new System.Drawing.Point(153, 125);
            this.btnNextVideo.Name = "btnNextVideo";
            this.btnNextVideo.Size = new System.Drawing.Size(40, 23);
            this.btnNextVideo.TabIndex = 9;
            this.btnNextVideo.Text = ">";
            this.btnNextVideo.UseVisualStyleBackColor = true;
            this.btnNextVideo.Click += new System.EventHandler(this.btnNextVideo_Click);
            // 
            // btnPrevVideo
            // 
            this.btnPrevVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevVideo.Location = new System.Drawing.Point(54, 125);
            this.btnPrevVideo.Name = "btnPrevVideo";
            this.btnPrevVideo.Size = new System.Drawing.Size(40, 23);
            this.btnPrevVideo.TabIndex = 8;
            this.btnPrevVideo.Text = "<";
            this.btnPrevVideo.UseVisualStyleBackColor = true;
            this.btnPrevVideo.Click += new System.EventHandler(this.btnPrevVideo_Click);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(47, 97);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 7;
            this.txtFee.TabStop = false;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(47, 71);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.ReadOnly = true;
            this.txtCopies.Size = new System.Drawing.Size(100, 20);
            this.txtCopies.TabIndex = 6;
            this.txtCopies.TabStop = false;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(47, 45);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 5;
            this.txtType.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(47, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(191, 20);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TabStop = false;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(6, 100);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(25, 13);
            this.lblFee.TabIndex = 3;
            this.lblFee.Text = "Fee";
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(6, 74);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(39, 13);
            this.lblCopies.TabIndex = 2;
            this.lblCopies.Text = "Copies";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 209);
            this.Controls.Add(this.gbxVideos);
            this.Controls.Add(this.gbxCustomers);
            this.Name = "Form1";
            this.Text = "Video Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCustomers.ResumeLayout(false);
            this.gbxCustomers.PerformLayout();
            this.gbxVideos.ResumeLayout(false);
            this.gbxVideos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomers;
        private System.Windows.Forms.Button btnNextCust;
        private System.Windows.Forms.Button btnPrevCust;
        private System.Windows.Forms.TextBox txtNumRented;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblVideos;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxVideos;
        private System.Windows.Forms.Button btnNextVideo;
        private System.Windows.Forms.Button btnPrevVideo;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
    }
}

