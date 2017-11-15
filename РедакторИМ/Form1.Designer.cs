namespace ImEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типРесурсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ресурсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.образецОперацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTypeResources = new System.Windows.Forms.ComboBox();
            this.cmbResources = new System.Windows.Forms.ComboBox();
            this.cmbPatternOperations = new System.Windows.Forms.ComboBox();
            this.cmbOperations = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.сгенерироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типРесурсовToolStripMenuItem,
            this.ресурсToolStripMenuItem,
            this.образецОперацииToolStripMenuItem,
            this.операциюToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // типРесурсовToolStripMenuItem
            // 
            this.типРесурсовToolStripMenuItem.Name = "типРесурсовToolStripMenuItem";
            this.типРесурсовToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.типРесурсовToolStripMenuItem.Text = "Тип ресурсов";
            this.типРесурсовToolStripMenuItem.Click += new System.EventHandler(this.типРесурсовToolStripMenuItem_Click);
            // 
            // ресурсToolStripMenuItem
            // 
            this.ресурсToolStripMenuItem.Name = "ресурсToolStripMenuItem";
            this.ресурсToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ресурсToolStripMenuItem.Text = "Ресурс";
            this.ресурсToolStripMenuItem.Click += new System.EventHandler(this.ресурсToolStripMenuItem_Click);
            // 
            // образецОперацииToolStripMenuItem
            // 
            this.образецОперацииToolStripMenuItem.Name = "образецОперацииToolStripMenuItem";
            this.образецОперацииToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.образецОперацииToolStripMenuItem.Text = "Образец операции";
            this.образецОперацииToolStripMenuItem.Click += new System.EventHandler(this.образецОперацииToolStripMenuItem_Click);
            // 
            // операциюToolStripMenuItem
            // 
            this.операциюToolStripMenuItem.Name = "операциюToolStripMenuItem";
            this.операциюToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.операциюToolStripMenuItem.Text = "Операцию";
            this.операциюToolStripMenuItem.Click += new System.EventHandler(this.операциюToolStripMenuItem_Click);
            // 
            // сгенерироватьToolStripMenuItem
            // 
            this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
            this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать ИМ";
            this.сгенерироватьToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Типы ресурсов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ресурсы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Образцы операций:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Операции:";
            // 
            // cmbTypeResources
            // 
            this.cmbTypeResources.FormattingEnabled = true;
            this.cmbTypeResources.Location = new System.Drawing.Point(207, 74);
            this.cmbTypeResources.Name = "cmbTypeResources";
            this.cmbTypeResources.Size = new System.Drawing.Size(178, 21);
            this.cmbTypeResources.TabIndex = 5;
            // 
            // cmbResources
            // 
            this.cmbResources.FormattingEnabled = true;
            this.cmbResources.Location = new System.Drawing.Point(207, 134);
            this.cmbResources.Name = "cmbResources";
            this.cmbResources.Size = new System.Drawing.Size(178, 21);
            this.cmbResources.TabIndex = 6;
            // 
            // cmbPatternOperations
            // 
            this.cmbPatternOperations.FormattingEnabled = true;
            this.cmbPatternOperations.Location = new System.Drawing.Point(207, 197);
            this.cmbPatternOperations.Name = "cmbPatternOperations";
            this.cmbPatternOperations.Size = new System.Drawing.Size(178, 21);
            this.cmbPatternOperations.TabIndex = 7;
            // 
            // cmbOperations
            // 
            this.cmbOperations.FormattingEnabled = true;
            this.cmbOperations.Location = new System.Drawing.Point(207, 264);
            this.cmbOperations.Name = "cmbOperations";
            this.cmbOperations.Size = new System.Drawing.Size(178, 21);
            this.cmbOperations.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Посмотреть/изменить/удалить тип ресурсов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Посмотреть/изменить/удалить ресурс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(411, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Посмотреть/изменить/удалить образец операций";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 36);
            this.button4.TabIndex = 12;
            this.button4.Text = "Посмотреть/изменить/удалить операцию";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(696, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 26);
            this.button5.TabIndex = 13;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(848, 374);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbOperations);
            this.Controls.Add(this.cmbPatternOperations);
            this.Controls.Add(this.cmbResources);
            this.Controls.Add(this.cmbTypeResources);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Редактор визуальных объектов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типРесурсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ресурсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem образецОперацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTypeResources;
        private System.Windows.Forms.ComboBox cmbResources;
        private System.Windows.Forms.ComboBox cmbPatternOperations;
        private System.Windows.Forms.ComboBox cmbOperations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

