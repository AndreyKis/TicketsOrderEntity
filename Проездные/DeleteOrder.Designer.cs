namespace Проездные
{
    partial class DeleteOrder
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
            this.DeleteOrder_btn = new System.Windows.Forms.Button();
            this.DeleteTOrderPrsnName_cmbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteOrdrTickName_cmbbox = new System.Windows.Forms.ComboBox();
            this.DeleteOrdrDate_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteOrder_btn
            // 
            this.DeleteOrder_btn.Location = new System.Drawing.Point(115, 182);
            this.DeleteOrder_btn.Name = "DeleteOrder_btn";
            this.DeleteOrder_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrder_btn.TabIndex = 14;
            this.DeleteOrder_btn.Text = "Видалити";
            this.DeleteOrder_btn.UseVisualStyleBackColor = true;
            this.DeleteOrder_btn.Click += new System.EventHandler(this.DeleteOrder_btn_Click);
            // 
            // DeleteTOrderPrsnName_cmbbox
            // 
            this.DeleteTOrderPrsnName_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteTOrderPrsnName_cmbbox.FormattingEnabled = true;
            this.DeleteTOrderPrsnName_cmbbox.Location = new System.Drawing.Point(115, 34);
            this.DeleteTOrderPrsnName_cmbbox.Name = "DeleteTOrderPrsnName_cmbbox";
            this.DeleteTOrderPrsnName_cmbbox.Size = new System.Drawing.Size(183, 21);
            this.DeleteTOrderPrsnName_cmbbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Оберіть основні дані замовлення для видалення";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ім\'я людини";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Назва квитка";
            // 
            // DeleteOrdrTickName_cmbbox
            // 
            this.DeleteOrdrTickName_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteOrdrTickName_cmbbox.FormattingEnabled = true;
            this.DeleteOrdrTickName_cmbbox.Location = new System.Drawing.Point(115, 87);
            this.DeleteOrdrTickName_cmbbox.Name = "DeleteOrdrTickName_cmbbox";
            this.DeleteOrdrTickName_cmbbox.Size = new System.Drawing.Size(183, 21);
            this.DeleteOrdrTickName_cmbbox.TabIndex = 17;
            // 
            // DeleteOrdrDate_txtbox
            // 
            this.DeleteOrdrDate_txtbox.Location = new System.Drawing.Point(115, 139);
            this.DeleteOrdrDate_txtbox.Name = "DeleteOrdrDate_txtbox";
            this.DeleteOrdrDate_txtbox.Size = new System.Drawing.Size(183, 20);
            this.DeleteOrdrDate_txtbox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата замовлення";
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 214);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteOrdrDate_txtbox);
            this.Controls.Add(this.DeleteOrdrTickName_cmbbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteOrder_btn);
            this.Controls.Add(this.DeleteTOrderPrsnName_cmbbox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteOrder";
            this.Text = "Видалити Замовлення";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteOrder_btn;
        private System.Windows.Forms.ComboBox DeleteTOrderPrsnName_cmbbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeleteOrdrTickName_cmbbox;
        private System.Windows.Forms.TextBox DeleteOrdrDate_txtbox;
        private System.Windows.Forms.Label label4;
    }
}