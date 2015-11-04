namespace Проездные
{
    partial class DeleteTicket
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
            this.DeleteTicket_btn = new System.Windows.Forms.Button();
            this.DeleteTicketName_cmbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteTicket_btn
            // 
            this.DeleteTicket_btn.Location = new System.Drawing.Point(98, 71);
            this.DeleteTicket_btn.Name = "DeleteTicket_btn";
            this.DeleteTicket_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteTicket_btn.TabIndex = 11;
            this.DeleteTicket_btn.Text = "Видалити";
            this.DeleteTicket_btn.UseVisualStyleBackColor = true;
            this.DeleteTicket_btn.Click += new System.EventHandler(this.DeleteTicket_btn_Click);
            // 
            // DeleteTicketName_cmbbox
            // 
            this.DeleteTicketName_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteTicketName_cmbbox.FormattingEnabled = true;
            this.DeleteTicketName_cmbbox.Location = new System.Drawing.Point(23, 35);
            this.DeleteTicketName_cmbbox.Name = "DeleteTicketName_cmbbox";
            this.DeleteTicketName_cmbbox.Size = new System.Drawing.Size(235, 21);
            this.DeleteTicketName_cmbbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Оберіть квиток для видалення";
            // 
            // DeleteTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.DeleteTicket_btn);
            this.Controls.Add(this.DeleteTicketName_cmbbox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteTicket";
            this.Text = "Видалити квиток";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteTicket_btn;
        private System.Windows.Forms.ComboBox DeleteTicketName_cmbbox;
        private System.Windows.Forms.Label label1;
    }
}