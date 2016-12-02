namespace Laba_1
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
            this.Plain = new System.Windows.Forms.Button();
            this.pictureOne = new System.Windows.Forms.PictureBox();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.pictureTwo = new System.Windows.Forms.PictureBox();
            this.Brez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadCircle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTwo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Plain
            // 
            this.Plain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plain.Location = new System.Drawing.Point(191, 557);
            this.Plain.Name = "Plain";
            this.Plain.Size = new System.Drawing.Size(97, 27);
            this.Plain.TabIndex = 0;
            this.Plain.Text = "Нарисовать";
            this.Plain.UseVisualStyleBackColor = true;
            this.Plain.Visible = false;
            this.Plain.Click += new System.EventHandler(this.Plain_Click);
            // 
            // pictureOne
            // 
            this.pictureOne.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOne.Location = new System.Drawing.Point(132, 312);
            this.pictureOne.Name = "pictureOne";
            this.pictureOne.Size = new System.Drawing.Size(227, 239);
            this.pictureOne.TabIndex = 1;
            this.pictureOne.TabStop = false;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line.Location = new System.Drawing.Point(6, 58);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(68, 21);
            this.Line.TabIndex = 2;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Circle.Location = new System.Drawing.Point(6, 31);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(105, 21);
            this.Circle.TabIndex = 3;
            this.Circle.TabStop = true;
            this.Circle.Text = "Окружность";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.CheckedChanged += new System.EventHandler(this.Circle_CheckedChanged);
            // 
            // pictureTwo
            // 
            this.pictureTwo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTwo.Location = new System.Drawing.Point(489, 312);
            this.pictureTwo.Name = "pictureTwo";
            this.pictureTwo.Size = new System.Drawing.Size(227, 239);
            this.pictureTwo.TabIndex = 4;
            this.pictureTwo.TabStop = false;
            // 
            // Brez
            // 
            this.Brez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brez.Location = new System.Drawing.Point(561, 557);
            this.Brez.Name = "Brez";
            this.Brez.Size = new System.Drawing.Size(97, 27);
            this.Brez.TabIndex = 5;
            this.Brez.Text = "Нарисовать";
            this.Brez.UseVisualStyleBackColor = true;
            this.Brez.Visible = false;
            this.Brez.Click += new System.EventHandler(this.Brez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Простой алгоритм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(530, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Алгоритм Брезенхема";
            // 
            // RadCircle
            // 
            this.RadCircle.Location = new System.Drawing.Point(309, 251);
            this.RadCircle.Name = "RadCircle";
            this.RadCircle.Size = new System.Drawing.Size(38, 20);
            this.RadCircle.TabIndex = 11;
            this.RadCircle.Text = "R";
            this.RadCircle.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(105, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите радиус окружности:";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(129, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Введите координаты:";
            this.label6.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(249, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "Y";
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(205, 214);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(38, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "X";
            this.textBox5.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.Circle);
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(153, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 101);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что нарисовать?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(846, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RadCircle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brez);
            this.Controls.Add(this.pictureTwo);
            this.Controls.Add(this.pictureOne);
            this.Controls.Add(this.Plain);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTwo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plain;
        private System.Windows.Forms.PictureBox pictureOne;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.PictureBox pictureTwo;
        private System.Windows.Forms.Button Brez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RadCircle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

