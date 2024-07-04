namespace PR_3
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
        #region Код, автоматически созданный конструктором форм Windows
        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtRows = new TextBox();
            txtCols = new TextBox();
            btnCreateMatrix = new Button();
            dataGridView1 = new DataGridView();
            btnAnalyze = new Button();
            lblResult = new Label();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            мояПрограммаToolStripMenuItem = new ToolStripMenuItem();
            Exit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRows
            // 
            txtRows.Location = new Point(10, 88);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(100, 23);
            txtRows.TabIndex = 0;
            // 
            // txtCols
            // 
            txtCols.Location = new Point(141, 88);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(100, 23);
            txtCols.TabIndex = 1;
            // 
            // btnCreateMatrix
            // 
            btnCreateMatrix.BackColor = Color.Linen;
            btnCreateMatrix.Location = new Point(272, 88);
            btnCreateMatrix.Name = "btnCreateMatrix";
            btnCreateMatrix.Size = new Size(161, 23);
            btnCreateMatrix.TabIndex = 2;
            btnCreateMatrix.Text = "Создать матрицу ☑";
            btnCreateMatrix.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(360, 200);
            dataGridView1.TabIndex = 3;
            // 
            // btnAnalyze
            // 
            btnAnalyze.BackColor = Color.Linen;
            btnAnalyze.Location = new Point(10, 326);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(117, 23);
            btnAnalyze.TabIndex = 4;
            btnAnalyze.Text = "Анализировать 🔍";
            btnAnalyze.UseVisualStyleBackColor = false;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(130, 330);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(515, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { очиститьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(126, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(126, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { мояПрограммаToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // мояПрограммаToolStripMenuItem
            // 
            мояПрограммаToolStripMenuItem.Name = "мояПрограммаToolStripMenuItem";
            мояПрограммаToolStripMenuItem.Size = new Size(180, 22);
            мояПрограммаToolStripMenuItem.Text = "Моя программа";
            мояПрограммаToolStripMenuItem.Click += мояПрограммаToolStripMenuItem_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Linen;
            Exit.Location = new Point(10, 355);
            Exit.Name = "Exit";
            Exit.Size = new Size(100, 23);
            Exit.TabIndex = 7;
            Exit.Text = "Выход ✈";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-26, 24);
            label1.Name = "label1";
            label1.Size = new Size(543, 51);
            label1.TabIndex = 8;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(515, 381);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(lblResult);
            Controls.Add(btnAnalyze);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreateMatrix);
            Controls.Add(txtCols);
            Controls.Add(txtRows);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Анализ матрицы";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Button btnCreateMatrix;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem мояПрограммаToolStripMenuItem;
        private Button Exit;
        private Label label1;
    }
        #endregion    
}
