namespace Проездные
{
    partial class DeleteType
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
            this.DeleteType_btn = new System.Windows.Forms.Button();
            this.DeleteTypeName_cmbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteType_btn
            // 
            this.DeleteType_btn.Location = new System.Drawing.Point(101, 79);
            this.DeleteType_btn.Name = "DeleteType_btn";
            this.DeleteType_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteType_btn.TabIndex = 5;
            this.DeleteType_btn.Text = "Видалити";
            this.DeleteType_btn.UseVisualStyleBackColor = true;
            this.DeleteType_btn.Click += new System.EventHandler(this.DeleteType_btn_Click);
            // 
            // DeleteTypeName_cmbbox
            // 
            this.DeleteTypeName_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteTypeName_cmbbox.FormattingEnabled = true;
            this.DeleteTypeName_cmbbox.Location = new System.Drawing.Point(24, 42);
            this.DeleteTypeName_cmbbox.Name = "DeleteTypeName_cmbbox";
            this.DeleteTypeName_cmbbox.Size = new System.Drawing.Size(235, 21);
            this.DeleteTypeName_cmbbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть тип для видалення";
            // 
            // DeleteType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.DeleteType_btn);
            this.Controls.Add(this.DeleteTypeName_cmbbox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteType";
            this.Text = "Видалити тип транспорту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteType_btn;
        private System.Windows.Forms.ComboBox DeleteTypeName_cmbbox;
        private System.Windows.Forms.Label label1;
    }
}