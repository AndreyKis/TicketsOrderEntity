namespace Проездные
{
    partial class AddNewOrder
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
            this.label4 = new System.Windows.Forms.Label();
            this.Pledge_txtbox = new System.Windows.Forms.TextBox();
            this.TickAmount_txtbox = new System.Windows.Forms.TextBox();
            this.GivingDate_txtbox = new System.Windows.Forms.TextBox();
            this.PersonNames_cmbbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddOrder_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TicketNames_cmbbox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Тип транспорту";
            // 
            // Pledge_txtbox
            // 
            this.Pledge_txtbox.Location = new System.Drawing.Point(109, 193);
            this.Pledge_txtbox.Name = "Pledge_txtbox";
            this.Pledge_txtbox.Size = new System.Drawing.Size(175, 20);
            this.Pledge_txtbox.TabIndex = 28;
            // 
            // TickAmount_txtbox
            // 
            this.TickAmount_txtbox.Location = new System.Drawing.Point(109, 149);
            this.TickAmount_txtbox.Name = "TickAmount_txtbox";
            this.TickAmount_txtbox.Size = new System.Drawing.Size(175, 20);
            this.TickAmount_txtbox.TabIndex = 27;
            // 
            // GivingDate_txtbox
            // 
            this.GivingDate_txtbox.Location = new System.Drawing.Point(109, 103);
            this.GivingDate_txtbox.Name = "GivingDate_txtbox";
            this.GivingDate_txtbox.Size = new System.Drawing.Size(175, 20);
            this.GivingDate_txtbox.TabIndex = 26;
            // 
            // PersonNames_cmbbox
            // 
            this.PersonNames_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonNames_cmbbox.FormattingEnabled = true;
            this.PersonNames_cmbbox.Location = new System.Drawing.Point(108, 11);
            this.PersonNames_cmbbox.Name = "PersonNames_cmbbox";
            this.PersonNames_cmbbox.Size = new System.Drawing.Size(175, 21);
            this.PersonNames_cmbbox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Борг";
            // 
            // AddOrder_btn
            // 
            this.AddOrder_btn.Location = new System.Drawing.Point(109, 227);
            this.AddOrder_btn.Name = "AddOrder_btn";
            this.AddOrder_btn.Size = new System.Drawing.Size(175, 23);
            this.AddOrder_btn.TabIndex = 23;
            this.AddOrder_btn.Text = "Додати";
            this.AddOrder_btn.UseVisualStyleBackColor = true;
            this.AddOrder_btn.Click += new System.EventHandler(this.AddOrder_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Кількість квитків";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Дата сдачі";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Назва квитка";
            // 
            // TicketNames_cmbbox
            // 
            this.TicketNames_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketNames_cmbbox.FormattingEnabled = true;
            this.TicketNames_cmbbox.Location = new System.Drawing.Point(109, 55);
            this.TicketNames_cmbbox.Name = "TicketNames_cmbbox";
            this.TicketNames_cmbbox.Size = new System.Drawing.Size(175, 21);
            this.TicketNames_cmbbox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ім\'я замовника";
            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.Pledge_txtbox);
            this.Controls.Add(this.TickAmount_txtbox);
            this.Controls.Add(this.GivingDate_txtbox);
            this.Controls.Add(this.PersonNames_cmbbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddOrder_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TicketNames_cmbbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Name = "AddNewOrder";
            this.Text = "Додати нове замовлення";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pledge_txtbox;
        private System.Windows.Forms.TextBox TickAmount_txtbox;
        private System.Windows.Forms.TextBox GivingDate_txtbox;
        private System.Windows.Forms.ComboBox PersonNames_cmbbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddOrder_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TicketNames_cmbbox;
        private System.Windows.Forms.Label label9;
    }
}