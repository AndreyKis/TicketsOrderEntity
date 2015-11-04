namespace Проездные
{
    partial class AddNewRate
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
            this.AddRate_btn = new System.Windows.Forms.Button();
            this.NewRateValue_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddRate_btn
            // 
            this.AddRate_btn.Location = new System.Drawing.Point(94, 76);
            this.AddRate_btn.Name = "AddRate_btn";
            this.AddRate_btn.Size = new System.Drawing.Size(82, 23);
            this.AddRate_btn.TabIndex = 5;
            this.AddRate_btn.Text = "Додати";
            this.AddRate_btn.UseVisualStyleBackColor = true;
            this.AddRate_btn.Click += new System.EventHandler(this.AddRate_btn_Click);
            // 
            // NewRateValue_txtbox
            // 
            this.NewRateValue_txtbox.Location = new System.Drawing.Point(8, 40);
            this.NewRateValue_txtbox.Name = "NewRateValue_txtbox";
            this.NewRateValue_txtbox.Size = new System.Drawing.Size(264, 20);
            this.NewRateValue_txtbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть нову кількість";
            // 
            // AddNewRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 114);
            this.Controls.Add(this.AddRate_btn);
            this.Controls.Add(this.NewRateValue_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewRate";
            this.Text = "AddNewRate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRate_btn;
        private System.Windows.Forms.TextBox NewRateValue_txtbox;
        private System.Windows.Forms.Label label1;
    }
}