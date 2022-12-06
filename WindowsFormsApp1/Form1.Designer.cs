namespace WindowsFormsApp1
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
            this.textBox1_A = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AC = new System.Windows.Forms.Button();
            this.AB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_A
            // 
            this.textBox1_A.Location = new System.Drawing.Point(581, 38);
            this.textBox1_A.Multiline = true;
            this.textBox1_A.Name = "textBox1_A";
            this.textBox1_A.Size = new System.Drawing.Size(193, 101);
            this.textBox1_A.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "создать форму В и С";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(110, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // AC
            // 
            this.AC.Location = new System.Drawing.Point(487, 359);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(75, 39);
            this.AC.TabIndex = 3;
            this.AC.Text = "Привет форме С";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // AB
            // 
            this.AB.Location = new System.Drawing.Point(629, 359);
            this.AB.Name = "AB";
            this.AB.Size = new System.Drawing.Size(75, 39);
            this.AB.TabIndex = 4;
            this.AB.Text = "Привет форме В";
            this.AB.UseVisualStyleBackColor = true;
            this.AB.Click += new System.EventHandler(this.AB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AB);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_A);
            this.Name = "Form1";
            this.Text = "Форма А";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_A;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button AB;
    }
}

