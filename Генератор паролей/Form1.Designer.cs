namespace Генератор_паролей
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            trackBar1 = new TrackBar();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(286, 30);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Использование цифр в пароле";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 238);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор параметров";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(17, 91);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(377, 30);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Использование прописных букв в пароле";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(17, 136);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(470, 30);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Использование прописных латинских букв в пароле";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(17, 182);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(436, 30);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Использование специальных символов в пароле";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Sitka Subheading", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Indigo;
            groupBox2.Location = new Point(12, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(777, 154);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сгенерированный пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Linen;
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(591, 115);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 7;
            label3.Text = "Сообщение-3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(283, 115);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 6;
            label2.Text = "Сообщение-2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(17, 115);
            label1.Name = "label1";
            label1.Size = new Size(111, 24);
            label1.TabIndex = 5;
            label1.Text = "Сообщение-1";
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(502, 34);
            button1.Name = "button1";
            button1.Size = new Size(242, 55);
            button1.TabIndex = 4;
            button1.Text = "Сгенерировать пароль";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 29);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(29, 531);
            button2.Name = "button2";
            button2.Size = new Size(242, 55);
            button2.TabIndex = 5;
            button2.Text = "Скопировать пароль";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(29, 444);
            button3.Name = "button3";
            button3.Size = new Size(242, 55);
            button3.TabIndex = 6;
            button3.Text = "Очистка поля";
            button3.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(335, 508);
            trackBar1.Maximum = 30;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(454, 56);
            trackBar1.TabIndex = 7;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 485);
            label4.Name = "label4";
            label4.Size = new Size(250, 20);
            label4.TabIndex = 8;
            label4.Text = "Выберите длину пароля от 5 до 30";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(806, 609);
            Controls.Add(label4);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private TrackBar trackBar1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}