namespace ImEditor
{
    partial class Form2
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
            this.fldTypeName = new System.Windows.Forms.TextBox();
            this.fldParam1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTrase = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbParam1 = new System.Windows.Forms.ComboBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.fldDefault1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fldVariants1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fldTypeName
            // 
            this.fldTypeName.Location = new System.Drawing.Point(387, 15);
            this.fldTypeName.Name = "fldTypeName";
            this.fldTypeName.Size = new System.Drawing.Size(100, 20);
            this.fldTypeName.TabIndex = 0;
            // 
            // fldParam1
            // 
            this.fldParam1.Location = new System.Drawing.Point(12, 187);
            this.fldParam1.Multiline = true;
            this.fldParam1.Name = "fldParam1";
            this.fldParam1.Size = new System.Drawing.Size(100, 21);
            this.fldParam1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить параметр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Создать тип ресурсов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя типа ресурсов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя параметра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тип параметра";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Трассировка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Статус";
            // 
            // cmbTrase
            // 
            this.cmbTrase.FormattingEnabled = true;
            this.cmbTrase.Location = new System.Drawing.Point(418, 55);
            this.cmbTrase.Name = "cmbTrase";
            this.cmbTrase.Size = new System.Drawing.Size(69, 21);
            this.cmbTrase.TabIndex = 10;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(395, 96);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(92, 21);
            this.cmbTime.TabIndex = 11;
            // 
            // cmbParam1
            // 
            this.cmbParam1.FormattingEnabled = true;
            this.cmbParam1.Location = new System.Drawing.Point(131, 186);
            this.cmbParam1.Name = "cmbParam1";
            this.cmbParam1.Size = new System.Drawing.Size(121, 21);
            this.cmbParam1.TabIndex = 12;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(650, 202);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(125, 23);
            this.butDelete.TabIndex = 13;
            this.butDelete.Text = "Удалить параметр";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // fldDefault1
            // 
            this.fldDefault1.Location = new System.Drawing.Point(519, 187);
            this.fldDefault1.Multiline = true;
            this.fldDefault1.Name = "fldDefault1";
            this.fldDefault1.Size = new System.Drawing.Size(100, 21);
            this.fldDefault1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Значение по умолчанию";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Возможные значения (для типа Enum)";
            // 
            // fldVariants1
            // 
            this.fldVariants1.Location = new System.Drawing.Point(275, 187);
            this.fldVariants1.Multiline = true;
            this.fldVariants1.Name = "fldVariants1";
            this.fldVariants1.Size = new System.Drawing.Size(222, 21);
            this.fldVariants1.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 330);
            this.Controls.Add(this.fldVariants1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fldDefault1);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.cmbParam1);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.cmbTrase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fldParam1);
            this.Controls.Add(this.fldTypeName);
            this.Name = "Form2";
            this.Text = "Создание типа ресурсов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fldTypeName;
        private System.Windows.Forms.TextBox fldParam1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTrase;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbParam1;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TextBox fldDefault1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fldVariants1;
    }
}