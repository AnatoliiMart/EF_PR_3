namespace EF_PR_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_AuthorName = new System.Windows.Forms.TextBox();
            this.txtBox_AuthorSurname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddAuthor = new System.Windows.Forms.Button();
            this.lstBox_AllAuthors = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_UpdateAuthor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_AuthorSurnameUpd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_AuthorNameUpd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_SearchValue = new System.Windows.Forms.TextBox();
            this.lstBox_SearchedAuthors = new System.Windows.Forms.ListBox();
            this.cmbBox_SearchType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBox_AuthorBooks = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // txtBox_AuthorName
            // 
            this.txtBox_AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_AuthorName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_AuthorName.Location = new System.Drawing.Point(9, 49);
            this.txtBox_AuthorName.Name = "txtBox_AuthorName";
            this.txtBox_AuthorName.Size = new System.Drawing.Size(186, 23);
            this.txtBox_AuthorName.TabIndex = 2;
            // 
            // txtBox_AuthorSurname
            // 
            this.txtBox_AuthorSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_AuthorSurname.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_AuthorSurname.Location = new System.Drawing.Point(9, 95);
            this.txtBox_AuthorSurname.Name = "txtBox_AuthorSurname";
            this.txtBox_AuthorSurname.Size = new System.Drawing.Size(186, 23);
            this.txtBox_AuthorSurname.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddAuthor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_AuthorSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_AuthorName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление автора ";
            // 
            // btn_AddAuthor
            // 
            this.btn_AddAuthor.Location = new System.Drawing.Point(47, 125);
            this.btn_AddAuthor.Name = "btn_AddAuthor";
            this.btn_AddAuthor.Size = new System.Drawing.Size(102, 32);
            this.btn_AddAuthor.TabIndex = 4;
            this.btn_AddAuthor.Text = "Добавить";
            this.btn_AddAuthor.UseVisualStyleBackColor = true;
            this.btn_AddAuthor.Click += new System.EventHandler(this.btn_AddAuthor_Click);
            // 
            // lstBox_AllAuthors
            // 
            this.lstBox_AllAuthors.FormattingEnabled = true;
            this.lstBox_AllAuthors.Location = new System.Drawing.Point(220, 33);
            this.lstBox_AllAuthors.Name = "lstBox_AllAuthors";
            this.lstBox_AllAuthors.Size = new System.Drawing.Size(250, 199);
            this.lstBox_AllAuthors.TabIndex = 5;
            this.lstBox_AllAuthors.SelectedIndexChanged += new System.EventHandler(this.lstBox_AllAuthors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(220, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Все авторы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_UpdateAuthor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBox_AuthorSurnameUpd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBox_AuthorNameUpd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 189);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Измение автора ";
            // 
            // btn_UpdateAuthor
            // 
            this.btn_UpdateAuthor.Location = new System.Drawing.Point(47, 125);
            this.btn_UpdateAuthor.Name = "btn_UpdateAuthor";
            this.btn_UpdateAuthor.Size = new System.Drawing.Size(102, 32);
            this.btn_UpdateAuthor.TabIndex = 4;
            this.btn_UpdateAuthor.Text = "Изменить";
            this.btn_UpdateAuthor.UseVisualStyleBackColor = true;
            this.btn_UpdateAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Имя";
            // 
            // txtBox_AuthorSurnameUpd
            // 
            this.txtBox_AuthorSurnameUpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_AuthorSurnameUpd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_AuthorSurnameUpd.Location = new System.Drawing.Point(9, 95);
            this.txtBox_AuthorSurnameUpd.Name = "txtBox_AuthorSurnameUpd";
            this.txtBox_AuthorSurnameUpd.Size = new System.Drawing.Size(186, 23);
            this.txtBox_AuthorSurnameUpd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Фамилия";
            // 
            // txtBox_AuthorNameUpd
            // 
            this.txtBox_AuthorNameUpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_AuthorNameUpd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_AuthorNameUpd.Location = new System.Drawing.Point(9, 49);
            this.txtBox_AuthorNameUpd.Name = "txtBox_AuthorNameUpd";
            this.txtBox_AuthorNameUpd.Size = new System.Drawing.Size(186, 23);
            this.txtBox_AuthorNameUpd.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Search);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBox_SearchValue);
            this.groupBox3.Controls.Add(this.lstBox_SearchedAuthors);
            this.groupBox3.Controls.Add(this.cmbBox_SearchType);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(220, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 153);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(7, 104);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 35);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Найти";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Значение для поиска";
            // 
            // txtBox_SearchValue
            // 
            this.txtBox_SearchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_SearchValue.Location = new System.Drawing.Point(7, 75);
            this.txtBox_SearchValue.Name = "txtBox_SearchValue";
            this.txtBox_SearchValue.Size = new System.Drawing.Size(173, 23);
            this.txtBox_SearchValue.TabIndex = 2;
            // 
            // lstBox_SearchedAuthors
            // 
            this.lstBox_SearchedAuthors.FormattingEnabled = true;
            this.lstBox_SearchedAuthors.ItemHeight = 17;
            this.lstBox_SearchedAuthors.Location = new System.Drawing.Point(218, 23);
            this.lstBox_SearchedAuthors.Name = "lstBox_SearchedAuthors";
            this.lstBox_SearchedAuthors.Size = new System.Drawing.Size(320, 123);
            this.lstBox_SearchedAuthors.TabIndex = 1;
            // 
            // cmbBox_SearchType
            // 
            this.cmbBox_SearchType.FormattingEnabled = true;
            this.cmbBox_SearchType.Items.AddRange(new object[] {
            "Поиск по ID",
            "Поиск по фамилии"});
            this.cmbBox_SearchType.Location = new System.Drawing.Point(7, 23);
            this.cmbBox_SearchType.Name = "cmbBox_SearchType";
            this.cmbBox_SearchType.Size = new System.Drawing.Size(173, 25);
            this.cmbBox_SearchType.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(476, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Книги выбранного автора";
            // 
            // lstBox_AuthorBooks
            // 
            this.lstBox_AuthorBooks.FormattingEnabled = true;
            this.lstBox_AuthorBooks.Location = new System.Drawing.Point(476, 33);
            this.lstBox_AuthorBooks.Name = "lstBox_AuthorBooks";
            this.lstBox_AuthorBooks.Size = new System.Drawing.Size(250, 199);
            this.lstBox_AuthorBooks.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstBox_AuthorBooks);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBox_AllAuthors);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Authors admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_AuthorName;
        private System.Windows.Forms.TextBox txtBox_AuthorSurname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddAuthor;
        private System.Windows.Forms.ListBox lstBox_AllAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_UpdateAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_AuthorSurnameUpd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_AuthorNameUpd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbBox_SearchType;
        private System.Windows.Forms.ListBox lstBox_SearchedAuthors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstBox_AuthorBooks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_SearchValue;
        private System.Windows.Forms.Button btn_Search;
    }
}

