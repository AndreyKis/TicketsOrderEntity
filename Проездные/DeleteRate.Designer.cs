namespace Проездные
{
    partial class DeleteRate
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
            this.DeleteRate_btn = new System.Windows.Forms.Button();
            this.DeleteRateName_cmbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteRate_btn
            // 
            this.DeleteRate_btn.Location = new System.Drawing.Point(99, 72);
            this.DeleteRate_btn.Name = "DeleteRate_btn";
            this.DeleteRate_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteRate_btn.TabIndex = 5;
            this.DeleteRate_btn.Text = "Видалити";
            this.DeleteRate_btn.UseVisualStyleBackColor = true;
            this.DeleteRate_btn.Click += new System.EventHandler(this.DeleteRate_btn_Click);
            // 
            // DeleteRateName_cmbbox
            // 
            this.DeleteRateName_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteRateName_cmbbox.FormattingEnabled = true;
            this.DeleteRateName_cmbbox.Location = new System.Drawing.Point(22, 37);
            this.DeleteRateName_cmbbox.Name = "DeleteRateName_cmbbox";
            this.DeleteRateName_cmbbox.Size = new System.Drawing.Size(235, 21);
            this.DeleteRateName_cmbbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть кількість для видалення";
            // 
            // DeleteRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.Controls.Add(this.DeleteRate_btn);
            this.Controls.Add(this.DeleteRateName_cmbbox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteRate";
            this.Text = "Видалити кількість";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteRate_btn;
        private System.Windows.Forms.ComboBox DeleteRateName_cmbbox;
        private System.Windows.Forms.Label label1;
    }
}