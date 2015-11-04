namespace Проездные
{
    partial class DeletePrice
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
            this.label1 = new System.Windows.Forms.Label();
            this.DeletePriceName_cmbbox = new System.Windows.Forms.ComboBox();
            this.DeletePrice_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть ціну для видалення";
            // 
            // DeletePriceName_cmbbox
            // 
            this.DeletePriceName_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeletePriceName_cmbbox.FormattingEnabled = true;
            this.DeletePriceName_cmbbox.Location = new System.Drawing.Point(24, 35);
            this.DeletePriceName_cmbbox.Name = "DeletePriceName_cmbbox";
            this.DeletePriceName_cmbbox.Size = new System.Drawing.Size(235, 21);
            this.DeletePriceName_cmbbox.TabIndex = 1;
            // 
            // DeletePrice_btn
            // 
            this.DeletePrice_btn.Location = new System.Drawing.Point(101, 72);
            this.DeletePrice_btn.Name = "DeletePrice_btn";
            this.DeletePrice_btn.Size = new System.Drawing.Size(75, 23);
            this.DeletePrice_btn.TabIndex = 2;
            this.DeletePrice_btn.Text = "Видалити";
            this.DeletePrice_btn.UseVisualStyleBackColor = true;
            this.DeletePrice_btn.Click += new System.EventHandler(this.DeletePrice_btn_Click);
            // 
            // DeletePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.DeletePrice_btn);
            this.Controls.Add(this.DeletePriceName_cmbbox);
            this.Controls.Add(this.label1);
            this.Name = "DeletePrice";
            this.Text = "Видалити ціну";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeletePriceName_cmbbox;
        private System.Windows.Forms.Button DeletePrice_btn;
    }
}