namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    partial class FormExpandedSignUpRepairsView
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
            this.change_theme = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSearchByClientPIB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchByWorkerPIB = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtWorkerPIB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.txtClientPIB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.повернутисяНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripConnection = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.change_theme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStripConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // change_theme
            // 
            this.change_theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.change_theme.Image = global::program_bicycle_repair_shop_polynko_kn_23_1.Properties.Resources.to_dark_theme;
            this.change_theme.Location = new System.Drawing.Point(931, 25);
            this.change_theme.Name = "change_theme";
            this.change_theme.Size = new System.Drawing.Size(40, 40);
            this.change_theme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.change_theme.TabIndex = 60;
            this.change_theme.TabStop = false;
            this.change_theme.Click += new System.EventHandler(this.change_theme_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(515, 49);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(88, 48);
            this.btnShow.TabIndex = 59;
            this.btnShow.Text = "Відобразити дані";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSearchByClientPIB
            // 
            this.btnSearchByClientPIB.Location = new System.Drawing.Point(343, 88);
            this.btnSearchByClientPIB.Name = "btnSearchByClientPIB";
            this.btnSearchByClientPIB.Size = new System.Drawing.Size(166, 23);
            this.btnSearchByClientPIB.TabIndex = 58;
            this.btnSearchByClientPIB.Text = "Пошук за ПІБ клієнта";
            this.btnSearchByClientPIB.UseVisualStyleBackColor = true;
            this.btnSearchByClientPIB.Click += new System.EventHandler(this.btnSearchByClientPIB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.btnSearchByClientPIB);
            this.groupBox1.Controls.Add(this.btnSearchByWorkerPIB);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtWorkerPIB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSearchByID);
            this.groupBox1.Controls.Add(this.txtClientPIB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(-11, 256);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1004, 154);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1004, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 154);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // btnSearchByWorkerPIB
            // 
            this.btnSearchByWorkerPIB.Location = new System.Drawing.Point(343, 62);
            this.btnSearchByWorkerPIB.Name = "btnSearchByWorkerPIB";
            this.btnSearchByWorkerPIB.Size = new System.Drawing.Size(166, 23);
            this.btnSearchByWorkerPIB.TabIndex = 56;
            this.btnSearchByWorkerPIB.Text = "Пошук за ПІБ робітника";
            this.btnSearchByWorkerPIB.UseVisualStyleBackColor = true;
            this.btnSearchByWorkerPIB.Click += new System.EventHandler(this.btnSearchByWorkerPIB_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(36, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(94, 13);
            this.txtPassword.TabIndex = 35;
            this.txtPassword.Text = "ПІБ робітника:";
            this.txtPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtWorkerPIB
            // 
            this.txtWorkerPIB.Location = new System.Drawing.Point(132, 64);
            this.txtWorkerPIB.Name = "txtWorkerPIB";
            this.txtWorkerPIB.Size = new System.Drawing.Size(205, 20);
            this.txtWorkerPIB.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "ID замовлення:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(343, 36);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(166, 23);
            this.btnSearchByID.TabIndex = 23;
            this.btnSearchByID.Text = "Пошук за ID замовлення";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // txtClientPIB
            // 
            this.txtClientPIB.Location = new System.Drawing.Point(132, 90);
            this.txtClientPIB.Name = "txtClientPIB";
            this.txtClientPIB.Size = new System.Drawing.Size(205, 20);
            this.txtClientPIB.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ПІБ клієнта:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(132, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 20);
            this.txtID.TabIndex = 56;
            // 
            // повернутисяНазадToolStripMenuItem
            // 
            this.повернутисяНазадToolStripMenuItem.Name = "повернутисяНазадToolStripMenuItem";
            this.повернутисяНазадToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.повернутисяНазадToolStripMenuItem.Text = "Повернутися назад";
            this.повернутисяНазадToolStripMenuItem.Click += new System.EventHandler(this.повернутисяНазадToolStripMenuItem_Click);
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            this.очиститиToolStripMenuItem.Click += new System.EventHandler(this.очиститиToolStripMenuItem_Click);
            // 
            // формаToolStripMenuItem
            // 
            this.формаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститиToolStripMenuItem,
            this.повернутисяНазадToolStripMenuItem});
            this.формаToolStripMenuItem.Name = "формаToolStripMenuItem";
            this.формаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.формаToolStripMenuItem.Text = "Форма";
            // 
            // menuStripConnection
            // 
            this.menuStripConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формаToolStripMenuItem});
            this.menuStripConnection.Location = new System.Drawing.Point(0, 0);
            this.menuStripConnection.Name = "menuStripConnection";
            this.menuStripConnection.Size = new System.Drawing.Size(983, 24);
            this.menuStripConnection.TabIndex = 59;
            this.menuStripConnection.Text = "menuStripConnection";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(959, 179);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(320, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Представлення \"Детальні відомості про записи на ремонт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormExpandedSignUpRepairsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 405);
            this.Controls.Add(this.change_theme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripConnection);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(999, 444);
            this.MinimumSize = new System.Drawing.Size(999, 444);
            this.Name = "FormExpandedSignUpRepairsView";
            this.Text = "FormExpandedSignUpRepairsView";
            this.Load += new System.EventHandler(this.FormExpandedSignUpRepairsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.change_theme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStripConnection.ResumeLayout(false);
            this.menuStripConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox change_theme;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSearchByClientPIB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchByWorkerPIB;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox txtWorkerPIB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.TextBox txtClientPIB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripMenuItem повернутисяНазадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripConnection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}