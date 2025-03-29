namespace Kyrsova1PolynkoP_20
{
    partial class FormMaster
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            формаToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button4 = new Button();
            очиститиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(633, 293);
            button1.Name = "button1";
            button1.Size = new Size(93, 38);
            button1.TabIndex = 11;
            button1.Text = "Завантажити дані";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(26, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(399, 265);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Items.AddRange(new ToolStripItem[] { формаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // формаToolStripMenuItem
            // 
            формаToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            формаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { очиститиToolStripMenuItem, вихідToolStripMenuItem });
            формаToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            формаToolStripMenuItem.Name = "формаToolStripMenuItem";
            формаToolStripMenuItem.Size = new Size(57, 20);
            формаToolStripMenuItem.Text = "Форма";
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            вихідToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(180, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(132, 37);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 19;
            label3.Text = "Таблиця \"Майстер\"";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Enabled = false;
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(708, 182);
            button3.Name = "button3";
            button3.Size = new Size(75, 39);
            button3.TabIndex = 18;
            button3.Text = "Видалити поле";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Enabled = false;
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(582, 182);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 17;
            button2.Text = "Додати поле";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(504, 129);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 16;
            label2.Text = "ПІБ майстра";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(485, 73);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 15;
            label1.Text = "Номер майстра";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(582, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(582, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Enabled = false;
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(633, 236);
            button4.Name = "button4";
            button4.Size = new Size(93, 38);
            button4.TabIndex = 20;
            button4.Text = "Оновити поле";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // очиститиToolStripMenuItem
            // 
            очиститиToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            очиститиToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            очиститиToolStripMenuItem.Size = new Size(180, 22);
            очиститиToolStripMenuItem.Text = "Очистити";
            очиститиToolStripMenuItem.Click += очиститиToolStripMenuItem_Click;
            // 
            // FormMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMaster";
            Text = "FormMaster";
            Load += FormMaster_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem формаToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private Label label3;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button4;
        private ToolStripMenuItem очиститиToolStripMenuItem;
    }
}