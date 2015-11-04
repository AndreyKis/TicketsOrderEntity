namespace Проездные
{
    partial class Client
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteOrder_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchedName_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TicketName_cmbbox = new System.Windows.Forms.ComboBox();
            this.AddOrder = new System.Windows.Forms.Button();
            this.RefreshOrders_btn = new System.Windows.Forms.Button();
            this.DateOfGiving_txtbox = new System.Windows.Forms.TextBox();
            this.EdDate_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Order_dgrv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeletePerson_btn = new System.Windows.Forms.Button();
            this.AddPers_btn = new System.Windows.Forms.Button();
            this.Person_dgrv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteTicket_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AddTicket = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.TickTransport_txtbox = new System.Windows.Forms.TextBox();
            this.TickAmount_txtbox = new System.Windows.Forms.TextBox();
            this.TickPrice_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tickets_dgrv = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DeleteRate_btn = new System.Windows.Forms.Button();
            this.AddNewRate_btn = new System.Windows.Forms.Button();
            this.Rate_dgrv = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DeletePr_btn = new System.Windows.Forms.Button();
            this.AddNewPrice_btn = new System.Windows.Forms.Button();
            this.Price_dgrv = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DeleteType_btn = new System.Windows.Forms.Button();
            this.AddNewType_btn = new System.Windows.Forms.Button();
            this.TransportType_dgrv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dgrv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Person_dgrv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tickets_dgrv)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rate_dgrv)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Price_dgrv)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportType_dgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteOrder_btn);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.SearchedName_txtbox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TicketName_cmbbox);
            this.tabPage1.Controls.Add(this.AddOrder);
            this.tabPage1.Controls.Add(this.RefreshOrders_btn);
            this.tabPage1.Controls.Add(this.DateOfGiving_txtbox);
            this.tabPage1.Controls.Add(this.EdDate_txtbox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Order_dgrv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Загальна інформація";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteOrder_btn
            // 
            this.DeleteOrder_btn.Location = new System.Drawing.Point(594, 24);
            this.DeleteOrder_btn.Name = "DeleteOrder_btn";
            this.DeleteOrder_btn.Size = new System.Drawing.Size(130, 22);
            this.DeleteOrder_btn.TabIndex = 26;
            this.DeleteOrder_btn.Text = "Видалити замовлення";
            this.DeleteOrder_btn.UseVisualStyleBackColor = true;
            this.DeleteOrder_btn.Click += new System.EventHandler(this.DeleteOrder_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "За ім\'ям";
            // 
            // SearchedName_txtbox
            // 
            this.SearchedName_txtbox.Location = new System.Drawing.Point(490, 24);
            this.SearchedName_txtbox.Name = "SearchedName_txtbox";
            this.SearchedName_txtbox.Size = new System.Drawing.Size(98, 20);
            this.SearchedName_txtbox.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Критерії фільтрації:";
            // 
            // TicketName_cmbbox
            // 
            this.TicketName_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketName_cmbbox.FormattingEnabled = true;
            this.TicketName_cmbbox.Location = new System.Drawing.Point(388, 24);
            this.TicketName_cmbbox.Name = "TicketName_cmbbox";
            this.TicketName_cmbbox.Size = new System.Drawing.Size(96, 21);
            this.TicketName_cmbbox.TabIndex = 22;
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(730, 24);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(152, 22);
            this.AddOrder.TabIndex = 21;
            this.AddOrder.Text = "Додати нове замовлення";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // RefreshOrders_btn
            // 
            this.RefreshOrders_btn.Location = new System.Drawing.Point(8, 24);
            this.RefreshOrders_btn.Name = "RefreshOrders_btn";
            this.RefreshOrders_btn.Size = new System.Drawing.Size(104, 20);
            this.RefreshOrders_btn.TabIndex = 14;
            this.RefreshOrders_btn.Text = "Оновити";
            this.RefreshOrders_btn.UseVisualStyleBackColor = true;
            this.RefreshOrders_btn.Click += new System.EventHandler(this.RefreshOrders_btn_Click);
            // 
            // DateOfGiving_txtbox
            // 
            this.DateOfGiving_txtbox.Location = new System.Drawing.Point(263, 24);
            this.DateOfGiving_txtbox.Name = "DateOfGiving_txtbox";
            this.DateOfGiving_txtbox.Size = new System.Drawing.Size(119, 20);
            this.DateOfGiving_txtbox.TabIndex = 19;
            // 
            // EdDate_txtbox
            // 
            this.EdDate_txtbox.Location = new System.Drawing.Point(118, 24);
            this.EdDate_txtbox.Name = "EdDate_txtbox";
            this.EdDate_txtbox.Size = new System.Drawing.Size(139, 20);
            this.EdDate_txtbox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "За назвою квитка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "За датою здачі грошей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Чи навчається ще студент";
            // 
            // Order_dgrv
            // 
            this.Order_dgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_dgrv.Location = new System.Drawing.Point(3, 50);
            this.Order_dgrv.Name = "Order_dgrv";
            this.Order_dgrv.Size = new System.Drawing.Size(879, 287);
            this.Order_dgrv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeletePerson_btn);
            this.tabPage2.Controls.Add(this.AddPers_btn);
            this.tabPage2.Controls.Add(this.Person_dgrv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Люди";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeletePerson_btn
            // 
            this.DeletePerson_btn.Location = new System.Drawing.Point(178, 7);
            this.DeletePerson_btn.Name = "DeletePerson_btn";
            this.DeletePerson_btn.Size = new System.Drawing.Size(169, 23);
            this.DeletePerson_btn.TabIndex = 2;
            this.DeletePerson_btn.Text = "Видалити людину";
            this.DeletePerson_btn.UseVisualStyleBackColor = true;
            this.DeletePerson_btn.Click += new System.EventHandler(this.DeletePerson_btn_Click);
            // 
            // AddPers_btn
            // 
            this.AddPers_btn.Location = new System.Drawing.Point(3, 7);
            this.AddPers_btn.Name = "AddPers_btn";
            this.AddPers_btn.Size = new System.Drawing.Size(169, 23);
            this.AddPers_btn.TabIndex = 1;
            this.AddPers_btn.Text = "Додати людину";
            this.AddPers_btn.UseVisualStyleBackColor = true;
            this.AddPers_btn.Click += new System.EventHandler(this.AddPers_btn_Click);
            // 
            // Person_dgrv
            // 
            this.Person_dgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Person_dgrv.Location = new System.Drawing.Point(3, 36);
            this.Person_dgrv.Name = "Person_dgrv";
            this.Person_dgrv.Size = new System.Drawing.Size(876, 296);
            this.Person_dgrv.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeleteTicket_btn);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.AddTicket);
            this.tabPage3.Controls.Add(this.Refresh);
            this.tabPage3.Controls.Add(this.TickTransport_txtbox);
            this.tabPage3.Controls.Add(this.TickAmount_txtbox);
            this.tabPage3.Controls.Add(this.TickPrice_txtbox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.Tickets_dgrv);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(885, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Квитки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeleteTicket_btn
            // 
            this.DeleteTicket_btn.Location = new System.Drawing.Point(611, 29);
            this.DeleteTicket_btn.Name = "DeleteTicket_btn";
            this.DeleteTicket_btn.Size = new System.Drawing.Size(133, 21);
            this.DeleteTicket_btn.TabIndex = 26;
            this.DeleteTicket_btn.Text = "Видалити квиток";
            this.DeleteTicket_btn.UseVisualStyleBackColor = true;
            this.DeleteTicket_btn.Click += new System.EventHandler(this.DeleteTicket_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Критерії фільтрації:";
            // 
            // AddTicket
            // 
            this.AddTicket.Location = new System.Drawing.Point(750, 29);
            this.AddTicket.Name = "AddTicket";
            this.AddTicket.Size = new System.Drawing.Size(127, 21);
            this.AddTicket.TabIndex = 13;
            this.AddTicket.Text = "Додати новий квиток";
            this.AddTicket.UseVisualStyleBackColor = true;
            this.AddTicket.Click += new System.EventHandler(this.AddTicket_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(6, 29);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(121, 22);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Оновити";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // TickTransport_txtbox
            // 
            this.TickTransport_txtbox.Location = new System.Drawing.Point(442, 30);
            this.TickTransport_txtbox.Name = "TickTransport_txtbox";
            this.TickTransport_txtbox.Size = new System.Drawing.Size(162, 20);
            this.TickTransport_txtbox.TabIndex = 12;
            // 
            // TickAmount_txtbox
            // 
            this.TickAmount_txtbox.Location = new System.Drawing.Point(283, 30);
            this.TickAmount_txtbox.Name = "TickAmount_txtbox";
            this.TickAmount_txtbox.Size = new System.Drawing.Size(153, 20);
            this.TickAmount_txtbox.TabIndex = 11;
            // 
            // TickPrice_txtbox
            // 
            this.TickPrice_txtbox.Location = new System.Drawing.Point(133, 30);
            this.TickPrice_txtbox.Name = "TickPrice_txtbox";
            this.TickPrice_txtbox.Size = new System.Drawing.Size(144, 20);
            this.TickPrice_txtbox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип транспорту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кількість поїздок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ціна";
            // 
            // Tickets_dgrv
            // 
            this.Tickets_dgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tickets_dgrv.Location = new System.Drawing.Point(3, 55);
            this.Tickets_dgrv.Name = "Tickets_dgrv";
            this.Tickets_dgrv.Size = new System.Drawing.Size(886, 292);
            this.Tickets_dgrv.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DeleteRate_btn);
            this.tabPage4.Controls.Add(this.AddNewRate_btn);
            this.tabPage4.Controls.Add(this.Rate_dgrv);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(885, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Кількість поїздок";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DeleteRate_btn
            // 
            this.DeleteRate_btn.Location = new System.Drawing.Point(194, 7);
            this.DeleteRate_btn.Name = "DeleteRate_btn";
            this.DeleteRate_btn.Size = new System.Drawing.Size(169, 23);
            this.DeleteRate_btn.TabIndex = 5;
            this.DeleteRate_btn.Text = "Видалити кількість поїздок";
            this.DeleteRate_btn.UseVisualStyleBackColor = true;
            this.DeleteRate_btn.Click += new System.EventHandler(this.DeleteRate_btn_Click);
            // 
            // AddNewRate_btn
            // 
            this.AddNewRate_btn.Location = new System.Drawing.Point(3, 7);
            this.AddNewRate_btn.Name = "AddNewRate_btn";
            this.AddNewRate_btn.Size = new System.Drawing.Size(169, 23);
            this.AddNewRate_btn.TabIndex = 2;
            this.AddNewRate_btn.Text = "Додати нову кількість";
            this.AddNewRate_btn.UseVisualStyleBackColor = true;
            this.AddNewRate_btn.Click += new System.EventHandler(this.AddNewRate_btn_Click);
            // 
            // Rate_dgrv
            // 
            this.Rate_dgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rate_dgrv.Location = new System.Drawing.Point(3, 36);
            this.Rate_dgrv.Name = "Rate_dgrv";
            this.Rate_dgrv.Size = new System.Drawing.Size(876, 296);
            this.Rate_dgrv.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DeletePr_btn);
            this.tabPage5.Controls.Add(this.AddNewPrice_btn);
            this.tabPage5.Controls.Add(this.Price_dgrv);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(885, 343);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ціни";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DeletePr_btn
            // 
            this.DeletePr_btn.Location = new System.Drawing.Point(194, 7);
            this.DeletePr_btn.Name = "DeletePr_btn";
            this.DeletePr_btn.Size = new System.Drawing.Size(169, 23);
            this.DeletePr_btn.TabIndex = 4;
            this.DeletePr_btn.Text = "Видалити ціну";
            this.DeletePr_btn.UseVisualStyleBackColor = true;
            this.DeletePr_btn.Click += new System.EventHandler(this.DeletePr_btn_Click);
            // 
            // AddNewPrice_btn
            // 
            this.AddNewPrice_btn.Location = new System.Drawing.Point(3, 7);
            this.AddNewPrice_btn.Name = "AddNewPrice_btn";
            this.AddNewPrice_btn.Size = new System.Drawing.Size(169, 23);
            this.AddNewPrice_btn.TabIndex = 3;
            this.AddNewPrice_btn.Text = "Додати нову ціну";
            this.AddNewPrice_btn.UseVisualStyleBackColor = true;
            this.AddNewPrice_btn.Click += new System.EventHandler(this.AddNewPrice_btn_Click);
            // 
            // Price_dgrv
            // 
            this.Price_dgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Price_dgrv.Location = new System.Drawing.Point(3, 36);
            this.Price_dgrv.Name = "Price_dgrv";
            this.Price_dgrv.Size = new System.Drawing.Size(876, 296);
            this.Price_dgrv.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DeleteType_btn);
            this.tabPage6.Controls.Add(this.AddNewType_btn);
            this.tabPage6.Controls.Add(this.TransportType_dgrv);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(885, 343);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Тип транспорту";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DeleteType_btn
            // 
            this.DeleteType_btn.Location = new System.Drawing.Point(194, 7);
            this.DeleteType_btn.Name = "DeleteType_btn";
            this.DeleteType_btn.Size = new System.Drawing.Size(169, 23);
            this.DeleteType_btn.TabIndex = 5;
            this.DeleteType_btn.Text = "Видалити тип транспорту";
            this.DeleteType_btn.UseVisualStyleBackColor = true;
            this.DeleteType_btn.Click += new System.EventHandler(this.DeleteType_btn_Click);
            // 
            // AddNewType_btn
            // 
            this.AddNewType_btn.Location = new System.Drawing.Point(3, 7);
            this.AddNewType_btn.Name = "AddNewType_btn";
            this.AddNewType_btn.Size = new System.Drawing.Size(169, 23);
            this.AddNewType_btn.TabIndex = 3;
            this.AddNewType_btn.Text = "Додати новий тип";
            this.AddNewType_btn.UseVisualStyleBackColor = true;
            this.AddNewType_btn.Click += new System.EventHandler(this.AddNewType_btn_Click);
            // 
            // TransportType_dgrv
            // 
            this.TransportType_dgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportType_dgrv.Location = new System.Drawing.Point(3, 36);
            this.TransportType_dgrv.Name = "TransportType_dgrv";
            this.TransportType_dgrv.Size = new System.Drawing.Size(876, 296);
            this.TransportType_dgrv.TabIndex = 0;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "Client";
            this.Text = "Проїзні";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dgrv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Person_dgrv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tickets_dgrv)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rate_dgrv)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Price_dgrv)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransportType_dgrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView Tickets_dgrv;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView Person_dgrv;
        private System.Windows.Forms.DataGridView Rate_dgrv;
        private System.Windows.Forms.DataGridView Price_dgrv;
        private System.Windows.Forms.DataGridView TransportType_dgrv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TickTransport_txtbox;
        private System.Windows.Forms.TextBox TickAmount_txtbox;
        private System.Windows.Forms.TextBox TickPrice_txtbox;
        private System.Windows.Forms.Button AddTicket;
        private System.Windows.Forms.DataGridView Order_dgrv;
        private System.Windows.Forms.ComboBox TicketName_cmbbox;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button RefreshOrders_btn;
        private System.Windows.Forms.TextBox DateOfGiving_txtbox;
        private System.Windows.Forms.TextBox EdDate_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddPers_btn;
        private System.Windows.Forms.Button AddNewRate_btn;
        private System.Windows.Forms.Button AddNewPrice_btn;
        private System.Windows.Forms.Button AddNewType_btn;
        private System.Windows.Forms.Button DeletePr_btn;
        private System.Windows.Forms.Button DeleteRate_btn;
        private System.Windows.Forms.Button DeleteType_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeletePerson_btn;
        private System.Windows.Forms.TextBox SearchedName_txtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteTicket_btn;
        private System.Windows.Forms.Button DeleteOrder_btn;
    }
}

