namespace Kyrsova1PolynkoP_20
{
    partial class FormClient
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
            очиститиToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            запитиToolStripMenuItem = new ToolStripMenuItem();
            загальніВідомостіПроКлієнтівToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(637, 324);
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
            dataGridView1.Location = new Point(29, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(451, 301);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Items.AddRange(new ToolStripItem[] { формаToolStripMenuItem, запитиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(820, 24);
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
            // запитиToolStripMenuItem
            // 
            запитиToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            запитиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загальніВідомостіПроКлієнтівToolStripMenuItem });
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
            загальніВідомостіПроКлієнтівToolStripMenuItem.Size = new Size(246, 22);
            загальніВідомостіПроКлієнтівToolStripMenuItem.Text = "Загальні відомості про клієнтів";
            загальніВідомостіПроКлієнтівToolStripMenuItem.Click += загальніВідомостіПроКлієнтівToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(176, 32);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 19;
            label3.Text = "Таблиця \"Клієнт\"";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Enabled = false;
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(711, 218);
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
            button2.Location = new Point(585, 218);
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
            label2.Location = new Point(513, 124);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 16;
            label2.Text = "ПІБ клієнта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(494, 68);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 15;
            label1.Text = "Номер клієнта";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(585, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(585, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(486, 180);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 21;
            label4.Text = "Тип замовлення";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.ForeColor = Color.FromArgb(255, 128, 0);
            textBox3.Location = new Point(585, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 23);
            textBox3.TabIndex = 20;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Enabled = false;
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(637, 269);
            button4.Name = "button4";
            button4.Size = new Size(93, 38);
            button4.TabIndex = 22;
            button4.Text = "Оновити поле";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(820, 438);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox3);
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
            Name = "FormClient";
            Text = "Client";
            Load += FormClient_Load;
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
        private Label label4;
        private TextBox textBox3;
        private ToolStripMenuItem запитиToolStripMenuItem;
        private ToolStripMenuItem загальніВідомостіПроКлієнтівToolStripMenuItem;
        private Button button4;
        private ToolStripMenuItem очиститиToolStripMenuItem;
    }
}