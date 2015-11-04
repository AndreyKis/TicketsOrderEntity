namespace Проездные
{
    partial class AddNewPerson
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
            this.AddPerson_btn = new System.Windows.Forms.Button();
            this.NewPersonName_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPersonEntDate_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPersonEndDate_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPerson_btn
            // 
            this.AddPerson_btn.Location = new System.Drawing.Point(108, 151);
            this.AddPerson_btn.Name = "AddPerson_btn";
            this.AddPerson_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddPerson_btn.Size = new System.Drawing.Size(82, 23);
            this.AddPerson_btn.TabIndex = 8;
            this.AddPerson_btn.Text = "Додати";
            this.AddPerson_btn.UseVisualStyleBackColor = true;
            this.AddPerson_btn.Click += new System.EventHandler(this.AddPerson_btn_Click);
            // 
            // NewPersonName_txtbox
            // 
            this.NewPersonName_txtbox.Location = new System.Drawing.Point(93, 25);
            this.NewPersonName_txtbox.Name = "NewPersonName_txtbox";
            this.NewPersonName_txtbox.Size = new System.Drawing.Size(189, 20);
            this.NewPersonName_txtbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ім\'я людини";
            // 
            // NewPersonEntDate_txtbox
            // 
            this.NewPersonEntDate_txtbox.Location = new System.Drawing.Point(93, 69);
            this.NewPersonEntDate_txtbox.Name = "NewPersonEntDate_txtbox";
            this.NewPersonEntDate_txtbox.Size = new System.Drawing.Size(189, 20);
            this.NewPersonEntDate_txtbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата Вступу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата Випуску";
            // 
            // NewPersonEndDate_txtbox
            // 
            this.NewPersonEndDate_txtbox.Location = new System.Drawing.Point(93, 110);
            this.NewPersonEndDate_txtbox.Name = "NewPersonEndDate_txtbox";
            this.NewPersonEndDate_txtbox.Size = new System.Drawing.Size(189, 20);
            this.NewPersonEndDate_txtbox.TabIndex = 11;
            // 
            // AddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPersonEndDate_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewPersonEntDate_txtbox);
            this.Controls.Add(this.AddPerson_btn);
            this.Controls.Add(this.NewPersonName_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewPerson";
            this.Text = "AddNewPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPerson_btn;
        private System.Windows.Forms.TextBox NewPersonName_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPersonEntDate_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPersonEndDate_txtbox;
    }
}