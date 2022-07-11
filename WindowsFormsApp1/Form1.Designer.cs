namespace RemoteAppLabel
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
            this.programName_textbox = new System.Windows.Forms.TextBox();
            this.createRA_button = new System.Windows.Forms.Button();
            this.programName_label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fileLocation_button = new System.Windows.Forms.Button();
            this.fileLocation_textbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileLocation_label = new System.Windows.Forms.Label();
            this.ip_label = new System.Windows.Forms.Label();
            this.ip1_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ip2_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ip3_text = new System.Windows.Forms.TextBox();
            this.ip4_text = new System.Windows.Forms.TextBox();
            this.isConsultant = new System.Windows.Forms.CheckBox();
            this.RALabel_textbox = new System.Windows.Forms.TextBox();
            this.RALabel_label = new System.Windows.Forms.Label();
            this.RALabel_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.consName_textBox = new System.Windows.Forms.TextBox();
            this.name_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // programName_textbox
            // 
            this.programName_textbox.Location = new System.Drawing.Point(54, 36);
            this.programName_textbox.MaxLength = 30;
            this.programName_textbox.Name = "programName_textbox";
            this.programName_textbox.Size = new System.Drawing.Size(196, 20);
            this.programName_textbox.TabIndex = 0;
            // 
            // createRA_button
            // 
            this.createRA_button.Location = new System.Drawing.Point(85, 340);
            this.createRA_button.Name = "createRA_button";
            this.createRA_button.Size = new System.Drawing.Size(197, 23);
            this.createRA_button.TabIndex = 1;
            this.createRA_button.Text = "Создать ярлык Remote App";
            this.createRA_button.UseVisualStyleBackColor = true;
            this.createRA_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // programName_label
            // 
            this.programName_label.AutoSize = true;
            this.programName_label.Location = new System.Drawing.Point(116, 20);
            this.programName_label.Name = "programName_label";
            this.programName_label.Size = new System.Drawing.Size(91, 13);
            this.programName_label.TabIndex = 2;
            this.programName_label.Text = "Имя программы";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(132, 383);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // fileLocation_button
            // 
            this.fileLocation_button.Location = new System.Drawing.Point(256, 89);
            this.fileLocation_button.Name = "fileLocation_button";
            this.fileLocation_button.Size = new System.Drawing.Size(66, 23);
            this.fileLocation_button.TabIndex = 4;
            this.fileLocation_button.Text = "Обзор...";
            this.fileLocation_button.UseVisualStyleBackColor = true;
            this.fileLocation_button.Click += new System.EventHandler(this.fileLocation_button_Click);
            // 
            // fileLocation_textbox
            // 
            this.fileLocation_textbox.Enabled = false;
            this.fileLocation_textbox.Location = new System.Drawing.Point(54, 91);
            this.fileLocation_textbox.Name = "fileLocation_textbox";
            this.fileLocation_textbox.Size = new System.Drawing.Size(196, 20);
            this.fileLocation_textbox.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileLocation_label
            // 
            this.fileLocation_label.AutoSize = true;
            this.fileLocation_label.Location = new System.Drawing.Point(102, 75);
            this.fileLocation_label.Name = "fileLocation_label";
            this.fileLocation_label.Size = new System.Drawing.Size(117, 13);
            this.fileLocation_label.TabIndex = 6;
            this.fileLocation_label.Text = "Расположение файла";
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(118, 130);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(95, 13);
            this.ip_label.TabIndex = 8;
            this.ip_label.Text = "IP-адрес сервера";
            // 
            // ip1_text
            // 
            this.ip1_text.Location = new System.Drawing.Point(54, 146);
            this.ip1_text.MaxLength = 3;
            this.ip1_text.Name = "ip1_text";
            this.ip1_text.Size = new System.Drawing.Size(35, 20);
            this.ip1_text.TabIndex = 7;
            this.ip1_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = ".";
            // 
            // ip2_text
            // 
            this.ip2_text.Location = new System.Drawing.Point(111, 146);
            this.ip2_text.MaxLength = 3;
            this.ip2_text.Name = "ip2_text";
            this.ip2_text.Size = new System.Drawing.Size(35, 20);
            this.ip2_text.TabIndex = 11;
            this.ip2_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = ".";
            // 
            // ip3_text
            // 
            this.ip3_text.Location = new System.Drawing.Point(168, 146);
            this.ip3_text.MaxLength = 3;
            this.ip3_text.Name = "ip3_text";
            this.ip3_text.Size = new System.Drawing.Size(35, 20);
            this.ip3_text.TabIndex = 13;
            this.ip3_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ip4_text
            // 
            this.ip4_text.Location = new System.Drawing.Point(225, 146);
            this.ip4_text.MaxLength = 3;
            this.ip4_text.Name = "ip4_text";
            this.ip4_text.Size = new System.Drawing.Size(35, 20);
            this.ip4_text.TabIndex = 15;
            this.ip4_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // isConsultant
            // 
            this.isConsultant.AutoSize = true;
            this.isConsultant.Location = new System.Drawing.Point(54, 309);
            this.isConsultant.Name = "isConsultant";
            this.isConsultant.Size = new System.Drawing.Size(212, 17);
            this.isConsultant.TabIndex = 16;
            this.isConsultant.Text = "Создать ярлык Консультанта в ДОР";
            this.isConsultant.UseVisualStyleBackColor = true;
            this.isConsultant.CheckedChanged += new System.EventHandler(this.isConsultant_CheckedChanged);
            // 
            // RALabel_textbox
            // 
            this.RALabel_textbox.Enabled = false;
            this.RALabel_textbox.Location = new System.Drawing.Point(54, 199);
            this.RALabel_textbox.Name = "RALabel_textbox";
            this.RALabel_textbox.Size = new System.Drawing.Size(196, 20);
            this.RALabel_textbox.TabIndex = 20;
            // 
            // RALabel_label
            // 
            this.RALabel_label.AutoSize = true;
            this.RALabel_label.Location = new System.Drawing.Point(51, 183);
            this.RALabel_label.Name = "RALabel_label";
            this.RALabel_label.Size = new System.Drawing.Size(225, 13);
            this.RALabel_label.TabIndex = 21;
            this.RALabel_label.Text = "Папка для сохранения ярлыка Remote App";
            // 
            // RALabel_button
            // 
            this.RALabel_button.Location = new System.Drawing.Point(256, 199);
            this.RALabel_button.Name = "RALabel_button";
            this.RALabel_button.Size = new System.Drawing.Size(66, 23);
            this.RALabel_button.TabIndex = 22;
            this.RALabel_button.Text = "Обзор...";
            this.RALabel_button.UseVisualStyleBackColor = true;
            this.RALabel_button.Click += new System.EventHandler(this.RALabel_button_Click);
            // 
            // consName_textBox
            // 
            this.consName_textBox.Location = new System.Drawing.Point(98, 283);
            this.consName_textBox.MaxLength = 30;
            this.consName_textBox.Name = "consName_textBox";
            this.consName_textBox.Size = new System.Drawing.Size(134, 20);
            this.consName_textBox.TabIndex = 23;
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(116, 267);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(90, 13);
            this.name_Label.TabIndex = 24;
            this.name_Label.Text = "Имя сотрудника";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 418);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.consName_textBox);
            this.Controls.Add(this.RALabel_button);
            this.Controls.Add(this.RALabel_label);
            this.Controls.Add(this.RALabel_textbox);
            this.Controls.Add(this.isConsultant);
            this.Controls.Add(this.ip4_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ip3_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ip2_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.ip1_text);
            this.Controls.Add(this.fileLocation_label);
            this.Controls.Add(this.fileLocation_textbox);
            this.Controls.Add(this.fileLocation_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.programName_label);
            this.Controls.Add(this.createRA_button);
            this.Controls.Add(this.programName_textbox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox programName_textbox;
        private System.Windows.Forms.Button createRA_button;
        private System.Windows.Forms.Label programName_label;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button fileLocation_button;
        private System.Windows.Forms.TextBox fileLocation_textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fileLocation_label;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.TextBox ip1_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ip2_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ip3_text;
        private System.Windows.Forms.TextBox ip4_text;
        private System.Windows.Forms.CheckBox isConsultant;
        private System.Windows.Forms.TextBox RALabel_textbox;
        private System.Windows.Forms.Label RALabel_label;
        private System.Windows.Forms.Button RALabel_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox consName_textBox;
        private System.Windows.Forms.Label name_Label;
    }
}

