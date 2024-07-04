namespace PR_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 23);
            label1.TabIndex = 0;
            label1.Text = "Моя программа \"Анализ матрицы\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(483, 21);
            label3.TabIndex = 2;
            label3.Text = "Специальность: Информационные системы и программирование";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 66);
            label4.Name = "label4";
            label4.Size = new Size(191, 21);
            label4.TabIndex = 3;
            label4.Text = "Разработал: Зацепин Р.Д.";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.LightCyan;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.Location = new Point(75, 138);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(209, 21);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "roma.zatsepin.2006@mail.ru";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 248);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 246);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}