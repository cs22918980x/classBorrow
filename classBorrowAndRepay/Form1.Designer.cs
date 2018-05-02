namespace classBorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.myNameLabel1 = new System.Windows.Forms.Label();
            this.borrowNameLabel1 = new System.Windows.Forms.Label();
            this.myNameTextBox = new System.Windows.Forms.TextBox();
            this.borrowNameTextBox = new System.Windows.Forms.TextBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.myNanmeLabel2 = new System.Windows.Forms.Label();
            this.myNanmeLabel3 = new System.Windows.Forms.Label();
            this.borrowNameLabel3 = new System.Windows.Forms.Label();
            this.myMoneyLabel1 = new System.Windows.Forms.Label();
            this.borrowMoney1 = new System.Windows.Forms.Label();
            this.borrowNameLabel2 = new System.Windows.Forms.Label();
            this.myMoneyLabel2 = new System.Windows.Forms.Label();
            this.borrowMoney2 = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.repayBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myNameLabel1
            // 
            this.myNameLabel1.AutoSize = true;
            this.myNameLabel1.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNameLabel1.Location = new System.Drawing.Point(59, 20);
            this.myNameLabel1.Name = "myNameLabel1";
            this.myNameLabel1.Size = new System.Drawing.Size(113, 30);
            this.myNameLabel1.TabIndex = 0;
            this.myNameLabel1.Text = "my name";
            // 
            // borrowNameLabel1
            // 
            this.borrowNameLabel1.AutoSize = true;
            this.borrowNameLabel1.Font = new System.Drawing.Font("新細明體", 13F);
            this.borrowNameLabel1.Location = new System.Drawing.Point(486, 28);
            this.borrowNameLabel1.Name = "borrowNameLabel1";
            this.borrowNameLabel1.Size = new System.Drawing.Size(123, 22);
            this.borrowNameLabel1.TabIndex = 2;
            this.borrowNameLabel1.Text = "Borrow name";
            // 
            // myNameTextBox
            // 
            this.myNameTextBox.Location = new System.Drawing.Point(192, 25);
            this.myNameTextBox.Name = "myNameTextBox";
            this.myNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.myNameTextBox.TabIndex = 3;
            // 
            // borrowNameTextBox
            // 
            this.borrowNameTextBox.Location = new System.Drawing.Point(629, 25);
            this.borrowNameTextBox.Name = "borrowNameTextBox";
            this.borrowNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.borrowNameTextBox.TabIndex = 4;
            // 
            // nameButton
            // 
            this.nameButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameButton.Location = new System.Drawing.Point(295, 53);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(191, 67);
            this.nameButton.TabIndex = 5;
            this.nameButton.Text = "Enter";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // myNanmeLabel2
            // 
            this.myNanmeLabel2.AutoSize = true;
            this.myNanmeLabel2.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNanmeLabel2.Location = new System.Drawing.Point(59, 122);
            this.myNanmeLabel2.Name = "myNanmeLabel2";
            this.myNanmeLabel2.Size = new System.Drawing.Size(124, 30);
            this.myNanmeLabel2.TabIndex = 6;
            this.myNanmeLabel2.Text = "my name :";
            // 
            // myNanmeLabel3
            // 
            this.myNanmeLabel3.AutoSize = true;
            this.myNanmeLabel3.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNanmeLabel3.Location = new System.Drawing.Point(189, 122);
            this.myNanmeLabel3.Name = "myNanmeLabel3";
            this.myNanmeLabel3.Size = new System.Drawing.Size(137, 30);
            this.myNanmeLabel3.TabIndex = 8;
            this.myNanmeLabel3.Text = "enter name";
            this.myNanmeLabel3.Click += new System.EventHandler(this.label3_Click);
            // 
            // borrowNameLabel3
            // 
            this.borrowNameLabel3.AutoSize = true;
            this.borrowNameLabel3.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowNameLabel3.Location = new System.Drawing.Point(624, 122);
            this.borrowNameLabel3.Name = "borrowNameLabel3";
            this.borrowNameLabel3.Size = new System.Drawing.Size(137, 30);
            this.borrowNameLabel3.TabIndex = 9;
            this.borrowNameLabel3.Text = "enter name";
            // 
            // myMoneyLabel1
            // 
            this.myMoneyLabel1.AutoSize = true;
            this.myMoneyLabel1.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myMoneyLabel1.Location = new System.Drawing.Point(38, 175);
            this.myMoneyLabel1.Name = "myMoneyLabel1";
            this.myMoneyLabel1.Size = new System.Drawing.Size(138, 30);
            this.myMoneyLabel1.TabIndex = 10;
            this.myMoneyLabel1.Text = "my money :";
            this.myMoneyLabel1.Click += new System.EventHandler(this.label5_Click);
            // 
            // borrowMoney1
            // 
            this.borrowMoney1.AutoSize = true;
            this.borrowMoney1.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowMoney1.Location = new System.Drawing.Point(429, 175);
            this.borrowMoney1.Name = "borrowMoney1";
            this.borrowMoney1.Size = new System.Drawing.Size(192, 30);
            this.borrowMoney1.TabIndex = 11;
            this.borrowMoney1.Text = "Borrow momey :";
            this.borrowMoney1.Click += new System.EventHandler(this.label6_Click);
            // 
            // borrowNameLabel2
            // 
            this.borrowNameLabel2.AutoSize = true;
            this.borrowNameLabel2.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowNameLabel2.Location = new System.Drawing.Point(429, 123);
            this.borrowNameLabel2.Name = "borrowNameLabel2";
            this.borrowNameLabel2.Size = new System.Drawing.Size(193, 30);
            this.borrowNameLabel2.TabIndex = 12;
            this.borrowNameLabel2.Text = "Borrower name :";
            // 
            // myMoneyLabel2
            // 
            this.myMoneyLabel2.AutoSize = true;
            this.myMoneyLabel2.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myMoneyLabel2.Location = new System.Drawing.Point(189, 175);
            this.myMoneyLabel2.Name = "myMoneyLabel2";
            this.myMoneyLabel2.Size = new System.Drawing.Size(78, 30);
            this.myMoneyLabel2.TabIndex = 13;
            this.myMoneyLabel2.Text = "10000";
            // 
            // borrowMoney2
            // 
            this.borrowMoney2.AutoSize = true;
            this.borrowMoney2.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowMoney2.Location = new System.Drawing.Point(624, 175);
            this.borrowMoney2.Name = "borrowMoney2";
            this.borrowMoney2.Size = new System.Drawing.Size(26, 30);
            this.borrowMoney2.TabIndex = 14;
            this.borrowMoney2.Text = "0";
            // 
            // borrowButton
            // 
            this.borrowButton.Enabled = false;
            this.borrowButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowButton.Location = new System.Drawing.Point(101, 241);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(643, 67);
            this.borrowButton.TabIndex = 15;
            this.borrowButton.Text = "MyName Borrow 100$";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // repayBotton
            // 
            this.repayBotton.Enabled = false;
            this.repayBotton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.repayBotton.Location = new System.Drawing.Point(101, 355);
            this.repayBotton.Name = "repayBotton";
            this.repayBotton.Size = new System.Drawing.Size(643, 67);
            this.repayBotton.TabIndex = 16;
            this.repayBotton.Text = "BorrowerName Repay 100$";
            this.repayBotton.UseVisualStyleBackColor = true;
            this.repayBotton.Click += new System.EventHandler(this.repayBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.repayBotton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.borrowMoney2);
            this.Controls.Add(this.myMoneyLabel2);
            this.Controls.Add(this.borrowNameLabel2);
            this.Controls.Add(this.borrowMoney1);
            this.Controls.Add(this.myMoneyLabel1);
            this.Controls.Add(this.borrowNameLabel3);
            this.Controls.Add(this.myNanmeLabel3);
            this.Controls.Add(this.myNanmeLabel2);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.borrowNameTextBox);
            this.Controls.Add(this.myNameTextBox);
            this.Controls.Add(this.borrowNameLabel1);
            this.Controls.Add(this.myNameLabel1);
            this.Name = "Form1";
            this.Text = "BorrowAndRepay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myNameLabel1;
        private System.Windows.Forms.Label borrowNameLabel1;
        private System.Windows.Forms.TextBox myNameTextBox;
        private System.Windows.Forms.TextBox borrowNameTextBox;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label myNanmeLabel2;
        private System.Windows.Forms.Label myNanmeLabel3;
        private System.Windows.Forms.Label borrowNameLabel3;
        private System.Windows.Forms.Label myMoneyLabel1;
        private System.Windows.Forms.Label borrowMoney1;
        private System.Windows.Forms.Label borrowNameLabel2;
        private System.Windows.Forms.Label myMoneyLabel2;
        private System.Windows.Forms.Label borrowMoney2;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button repayBotton;
    }
}

