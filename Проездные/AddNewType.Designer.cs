namespace Проездные
{
    partial class AddNewType
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
            this.AddType_btn = new System.Windows.Forms.Button();
            this.NewTypeName_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddType_btn
            // 
            this.AddType_btn.Location = new System.Drawing.Point(96, 69);
            this.AddType_btn.Name = "AddType_btn";
            this.AddType_btn.Size = new System.Drawing.Size(82, 23);
            this.AddType_btn.TabIndex = 5;
            this.AddType_btn.Text = "Додати";
            this.AddType_btn.UseVisualStyleBackColor = true;
            this.AddType_btn.Click += new System.EventHandler(this.AddType_btn_Click);
            // 
            // NewTypeName_txtbox
            // 
            this.NewTypeName_txtbox.Location = new System.Drawing.Point(10, 33);
            this.NewTypeName_txtbox.Name = "NewTypeName_txtbox";
            this.NewTypeName_txtbox.Size = new System.Drawing.Size(264, 20);
            this.NewTypeName_txtbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть назву нового типу";
            // 
            // AddNewType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.AddType_btn);
            this.Controls.Add(this.NewTypeName_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewType";
            this.Text = "AddNewType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddType_btn;
        private System.Windows.Forms.TextBox NewTypeName_txtbox;
        private System.Windows.Forms.Label label1;
    }
}