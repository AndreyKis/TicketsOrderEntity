namespace Проездные
{
    partial class DeletePerson
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
            this.DeletePerson_btn = new System.Windows.Forms.Button();
            this.DeletePersonName_cmbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeletePerson_btn
            // 
            this.DeletePerson_btn.Location = new System.Drawing.Point(98, 71);
            this.DeletePerson_btn.Name = "DeletePerson_btn";
            this.DeletePerson_btn.Size = new System.Drawing.Size(75, 23);
            this.DeletePerson_btn.TabIndex = 8;
            this.DeletePerson_btn.Text = "Видалити";
            this.DeletePerson_btn.UseVisualStyleBackColor = true;
            this.DeletePerson_btn.Click += new System.EventHandler(this.DeletePerson_btn_Click);
            // 
            // DeletePersonName_cmbbox
            // 
            this.DeletePersonName_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeletePersonName_cmbbox.FormattingEnabled = true;
            this.DeletePersonName_cmbbox.Location = new System.Drawing.Point(23, 35);
            this.DeletePersonName_cmbbox.Name = "DeletePersonName_cmbbox";
            this.DeletePersonName_cmbbox.Size = new System.Drawing.Size(235, 21);
            this.DeletePersonName_cmbbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оберіть людину для видалення";
            // 
            // DeletePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.DeletePerson_btn);
            this.Controls.Add(this.DeletePersonName_cmbbox);
            this.Controls.Add(this.label1);
            this.Name = "DeletePerson";
            this.Text = "Видалити людину";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeletePerson_btn;
        private System.Windows.Forms.ComboBox DeletePersonName_cmbbox;
        private System.Windows.Forms.Label label1;
    }
}