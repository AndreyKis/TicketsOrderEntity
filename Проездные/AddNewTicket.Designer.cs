namespace Проездные
{
    partial class AddNewTicket
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
            this.Create_btn = new System.Windows.Forms.Button();
            this.Type_cmbbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Rate_cmbbx = new System.Windows.Forms.ComboBox();
            this.Price_cmbbx = new System.Windows.Forms.ComboBox();
            this.Name_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(113, 187);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(175, 23);
            this.Create_btn.TabIndex = 25;
            this.Create_btn.Text = "Додати";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Type_cmbbx
            // 
            this.Type_cmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_cmbbx.FormattingEnabled = true;
            this.Type_cmbbx.Location = new System.Drawing.Point(113, 151);
            this.Type_cmbbx.Name = "Type_cmbbx";
            this.Type_cmbbx.Size = new System.Drawing.Size(175, 21);
            this.Type_cmbbx.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Тип транспорту";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Кількість поїздок";
            // 
            // Rate_cmbbx
            // 
            this.Rate_cmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rate_cmbbx.FormattingEnabled = true;
            this.Rate_cmbbx.Location = new System.Drawing.Point(113, 105);
            this.Rate_cmbbx.Name = "Rate_cmbbx";
            this.Rate_cmbbx.Size = new System.Drawing.Size(175, 21);
            this.Rate_cmbbx.TabIndex = 21;
            // 
            // Price_cmbbx
            // 
            this.Price_cmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Price_cmbbx.FormattingEnabled = true;
            this.Price_cmbbx.Location = new System.Drawing.Point(113, 58);
            this.Price_cmbbx.Name = "Price_cmbbx";
            this.Price_cmbbx.Size = new System.Drawing.Size(175, 21);
            this.Price_cmbbx.TabIndex = 20;
            // 
            // Name_txtbox
            // 
            this.Name_txtbox.Location = new System.Drawing.Point(113, 14);
            this.Name_txtbox.Name = "Name_txtbox";
            this.Name_txtbox.Size = new System.Drawing.Size(175, 20);
            this.Name_txtbox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Назва квитка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ціна";
            // 
            // AddNewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.Type_cmbbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Rate_cmbbx);
            this.Controls.Add(this.Price_cmbbx);
            this.Controls.Add(this.Name_txtbox);
            this.Controls.Add(this.label8);
            this.Name = "AddNewTicket";
            this.Text = "Додати новий квиток";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.ComboBox Type_cmbbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Rate_cmbbx;
        private System.Windows.Forms.ComboBox Price_cmbbx;
        private System.Windows.Forms.TextBox Name_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}