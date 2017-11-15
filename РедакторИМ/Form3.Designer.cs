namespace ImEditor
{
    partial class Form3
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
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.fldResName = new System.Windows.Forms.TextBox();
            this.butCreateRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип ресурсов";
            // 
            // cmbTypes
            // 
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(274, 24);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbTypes.TabIndex = 1;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(417, 22);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(143, 23);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Выбрать тип ресурсов";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // fldResName
            // 
            this.fldResName.Location = new System.Drawing.Point(274, 73);
            this.fldResName.Name = "fldResName";
            this.fldResName.Size = new System.Drawing.Size(173, 20);
            this.fldResName.TabIndex = 3;
            this.fldResName.Visible = false;
            // 
            // butCreateRes
            // 
            this.butCreateRes.Location = new System.Drawing.Point(686, 63);
            this.butCreateRes.Name = "butCreateRes";
            this.butCreateRes.Size = new System.Drawing.Size(115, 30);
            this.butCreateRes.TabIndex = 4;
            this.butCreateRes.Text = "Создать ресурс";
            this.butCreateRes.UseVisualStyleBackColor = true;
            this.butCreateRes.Visible = false;
            this.butCreateRes.Click += new System.EventHandler(this.butCreateRes_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 349);
            this.Controls.Add(this.butCreateRes);
            this.Controls.Add(this.fldResName);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Создание ресурса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox fldResName;
        private System.Windows.Forms.Button butCreateRes;
    }
}