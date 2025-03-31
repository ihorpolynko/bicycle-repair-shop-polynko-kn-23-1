namespace Kyrsova1PolynkoP_20
{
    partial class FormZapus_na_remont
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
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button4 = new Button();
            label3 = new Label();
            button3 = new Button();
            формаToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            очиститиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(709, 213);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 50;
            label5.Text = "Причина ремонту";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Black;
            textBox4.ForeColor = Color.FromArgb(255, 128, 0);
            textBox4.Location = new Point(819, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 23);
            textBox4.TabIndex = 49;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(721, 166);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 48;
            label4.Text = "Номер майстра";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.ForeColor = Color.FromArgb(255, 128, 0);
            textBox3.Location = new Point(819, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 23);
            textBox3.TabIndex = 47;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(870, 457);
            button1.Name = "button1";
            button1.Size = new Size(93, 38);
            button1.TabIndex = 37;
            button1.Text = "Завантажити дані";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Enabled = false;
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(870, 400);
            button4.Name = "button4";
            button4.Size = new Size(93, 38);
            button4.TabIndex = 46;
            button4.Text = "Оновити поле";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(239, 31);
            label3.Name = "label3";
            label3.Size = new Size(216, 21);
            label3.TabIndex = 45;
            label3.Text = "Таблиця \"Запис на ремонт\"";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Enabled = false;
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(945, 346);
            button3.Name = "button3";
            button3.Size = new Size(75, 39);
            button3.TabIndex = 44;
            button3.Text = "Видалити поле";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(26, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(639, 217);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Items.AddRange(new ToolStripItem[] { формаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1032, 24);
            menuStrip1.TabIndex = 38;
            menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(728, 115);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 42;
            label2.Text = "Номер клієнта";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(671, 64);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 41;
            label1.Text = "Номер запису на ремонт";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(819, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 40;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(819, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 39;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Enabled = false;
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(819, 346);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 43;
            button2.Text = "Додати поле";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(734, 259);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 52;
            label6.Text = "Дата ремонту";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Black;
            textBox5.ForeColor = Color.FromArgb(255, 128, 0);
            textBox5.Location = new Point(819, 303);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 23);
            textBox5.TabIndex = 51;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(769, 307);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 54;
            label7.Text = "Оплата";
            label7.Click += label7_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Black;
            dateTimePicker1.Location = new Point(819, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 55;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
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
            // FormZapus_na_remont
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1032, 516);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormZapus_na_remont";
            Text = "FormZapus_na_remont";
            Load += FormZapus_na_remont_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private Button button4;
        private Label label3;
        private Button button3;
        private ToolStripMenuItem формаToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem очиститиToolStripMenuItem;
    }
}