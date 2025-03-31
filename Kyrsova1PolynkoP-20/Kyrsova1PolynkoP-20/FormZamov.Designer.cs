namespace Kyrsova1PolynkoP_20
{
    partial class FormZamov
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
            label7 = new Label();
            формаToolStripMenuItem = new ToolStripMenuItem();
            очиститиToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            запитиToolStripMenuItem = new ToolStripMenuItem();
            загальніВідомостіПроКлієнтівToolStripMenuItem = new ToolStripMenuItem();
            відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(845, 322);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 77;
            label7.Text = "Дата замовлення";
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
            // очиститиToolStripMenuItem
            // 
            очиститиToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            очиститиToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            очиститиToolStripMenuItem.Size = new Size(127, 22);
            очиститиToolStripMenuItem.Text = "Очистити";
            очиститиToolStripMenuItem.Click += очиститиToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            вихідToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(127, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Black;
            textBox5.ForeColor = Color.FromArgb(255, 128, 0);
            textBox5.Location = new Point(949, 273);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 23);
            textBox5.TabIndex = 74;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(861, 228);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 73;
            label5.Text = "Номер товару";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Black;
            textBox4.ForeColor = Color.FromArgb(255, 128, 0);
            textBox4.Location = new Point(949, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 23);
            textBox4.TabIndex = 72;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Enabled = false;
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(1001, 414);
            button4.Name = "button4";
            button4.Size = new Size(93, 38);
            button4.TabIndex = 71;
            button4.Text = "Оновити поле";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(19, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 340);
            dataGridView1.TabIndex = 59;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Items.AddRange(new ToolStripItem[] { формаToolStripMenuItem, запитиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1172, 24);
            menuStrip1.TabIndex = 61;
            menuStrip1.Text = "menuStrip1";
            // 
            // запитиToolStripMenuItem
            // 
            запитиToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            запитиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загальніВідомостіПроКлієнтівToolStripMenuItem, відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem });
            запитиToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            запитиToolStripMenuItem.Name = "запитиToolStripMenuItem";
            запитиToolStripMenuItem.Size = new Size(58, 20);
            запитиToolStripMenuItem.Text = "Запити";
            // 
            // загальніВідомостіПроКлієнтівToolStripMenuItem
            // 
            загальніВідомостіПроКлієнтівToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            загальніВідомостіПроКлієнтівToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            загальніВідомостіПроКлієнтівToolStripMenuItem.Name = "загальніВідомостіПроКлієнтівToolStripMenuItem";
            загальніВідомостіПроКлієнтівToolStripMenuItem.Size = new Size(515, 22);
            загальніВідомостіПроКлієнтівToolStripMenuItem.Text = "Більш детальна інформація щодо замовлення клієнтів";
            загальніВідомостіПроКлієнтівToolStripMenuItem.Click += загальніВідомостіПроКлієнтівToolStripMenuItem_Click;
            // 
            // відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem
            // 
            відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem.Name = "відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem";
            відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem.Size = new Size(515, 22);
            відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem.Text = "Відомості про суму усіх замовлень, враховуючи кількість замовляємого товару";
            відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem.Click += відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(843, 178);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 70;
            label4.Text = "Номер робітника";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.ForeColor = Color.FromArgb(255, 128, 0);
            textBox3.Location = new Point(949, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 23);
            textBox3.TabIndex = 69;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(1001, 469);
            button1.Name = "button1";
            button1.Size = new Size(93, 38);
            button1.TabIndex = 60;
            button1.Text = "Завантажити дані";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(257, 33);
            label3.Name = "label3";
            label3.Size = new Size(183, 21);
            label3.TabIndex = 68;
            label3.Text = "Таблиця \"Замовлення\"";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Enabled = false;
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(949, 363);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 66;
            button2.Text = "Додати поле";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(858, 122);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 65;
            label2.Text = "Номер клієнта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(832, 66);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 64;
            label1.Text = "Номер замовлення";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(949, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 63;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(949, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 62;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Enabled = false;
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(1075, 363);
            button3.Name = "button3";
            button3.Size = new Size(75, 39);
            button3.TabIndex = 67;
            button3.Text = "Видалити поле";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(850, 277);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 78;
            label8.Text = "Кількість товару";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(949, 318);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 23);
            dateTimePicker1.TabIndex = 79;
            // 
            // FormZamov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1172, 527);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormZamov";
            Text = "FormZamov";
            Load += FormZamov_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ToolStripMenuItem формаToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Button button4;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Label label8;
        private ToolStripMenuItem запитиToolStripMenuItem;
        private ToolStripMenuItem загальніВідомостіПроКлієнтівToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem;
        private ToolStripMenuItem очиститиToolStripMenuItem;
    }
}