namespace Проездные
{
    partial class AddNewPrice
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
            this.NewPriceValue_txtbox = new System.Windows.Forms.TextBox();
            this.AddPrice_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ціну";
            // 
            // NewPriceValue_txtbox
            // 
            this.NewPriceValue_txtbox.Location = new System.Drawing.Point(12, 33);
            this.NewPriceValue_txtbox.Name = "NewPriceValue_txtbox";
            this.NewPriceValue_txtbox.Size = new System.Drawing.Size(264, 20);
            this.NewPriceValue_txtbox.TabIndex = 1;
            // 
            // AddPrice_btn
            // 
            this.AddPrice_btn.Location = new System.Drawing.Point(98, 69);
            this.AddPrice_btn.Name = "AddPrice_btn";
            this.AddPrice_btn.Size = new System.Drawing.Size(82, 23);
            this.AddPrice_btn.TabIndex = 2;
            this.AddPrice_btn.Text = "Додати";
            this.AddPrice_btn.UseVisualStyleBackColor = true;
            this.AddPrice_btn.Click += new System.EventHandler(this.AddPrice_btn_Click);
            // 
            // AddNewPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 104);
            this.Controls.Add(this.AddPrice_btn);
            this.Controls.Add(this.NewPriceValue_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewPrice";
            this.Text = "Додати нову ціну";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPriceValue_txtbox;
        private System.Windows.Forms.Button AddPrice_btn;
    }
}