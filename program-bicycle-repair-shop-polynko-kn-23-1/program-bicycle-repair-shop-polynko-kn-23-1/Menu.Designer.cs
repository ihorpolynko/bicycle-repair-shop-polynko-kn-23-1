namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиЗМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClients = new System.Windows.Forms.Button();
            this.change_theme = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSignUpRepairs = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_theme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripMenu";
            // 
            // формаToolStripMenuItem
            // 
            this.формаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вийтиЗМенюToolStripMenuItem});
            this.формаToolStripMenuItem.Name = "формаToolStripMenuItem";
            this.формаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.формаToolStripMenuItem.Text = "Форма";
            // 
            // вийтиЗМенюToolStripMenuItem
            // 
            this.вийтиЗМенюToolStripMenuItem.Name = "вийтиЗМенюToolStripMenuItem";
            this.вийтиЗМенюToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.вийтиЗМенюToolStripMenuItem.Text = "Вийти з меню";
            this.вийтиЗМенюToolStripMenuItem.Click += new System.EventHandler(this.вийтиЗМенюToolStripMenuItem_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(330, 30);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(130, 25);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Перейти до форми";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // change_theme
            // 
            this.change_theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.change_theme.Image = global::program_bicycle_repair_shop_polynko_kn_23_1.Properties.Resources.to_dark_theme;
            this.change_theme.Location = new System.Drawing.Point(750, 30);
            this.change_theme.Name = "change_theme";
            this.change_theme.Size = new System.Drawing.Size(40, 40);
            this.change_theme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.change_theme.TabIndex = 0;
            this.change_theme.TabStop = false;
            this.change_theme.Click += new System.EventHandler(this.Change_theme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClients);
            this.groupBox1.Location = new System.Drawing.Point(0, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблиця \"Клієнти\"";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оберіть таблицю";
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(330, 30);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(130, 25);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Перейти до форми";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOrders);
            this.groupBox2.Location = new System.Drawing.Point(0, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблиця \"Замовлення\"";
            // 
            // btnSignUpRepairs
            // 
            this.btnSignUpRepairs.Location = new System.Drawing.Point(330, 30);
            this.btnSignUpRepairs.Name = "btnSignUpRepairs";
            this.btnSignUpRepairs.Size = new System.Drawing.Size(130, 25);
            this.btnSignUpRepairs.TabIndex = 2;
            this.btnSignUpRepairs.Text = "Перейти до форми";
            this.btnSignUpRepairs.UseVisualStyleBackColor = true;
            this.btnSignUpRepairs.Click += new System.EventHandler(this.btnSignUpRepairs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSignUpRepairs);
            this.groupBox3.Location = new System.Drawing.Point(0, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 81);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Таблиця \"Запис на ремонт\"";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(330, 30);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(130, 25);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Перейти до форми";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDetails);
            this.groupBox4.Location = new System.Drawing.Point(0, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 81);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Таблиця \"Товари\"";
            // 
            // btnWorkers
            // 
            this.btnWorkers.Location = new System.Drawing.Point(330, 30);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(130, 25);
            this.btnWorkers.TabIndex = 2;
            this.btnWorkers.Text = "Перейти до форми";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnWorkers);
            this.groupBox5.Location = new System.Drawing.Point(0, 368);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(800, 81);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Таблиця \"Працівники\"";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.change_theme);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Connection_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_theme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox change_theme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиЗМенюToolStripMenuItem;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSignUpRepairs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

