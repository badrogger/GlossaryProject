namespace Glossary
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТемамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvParent = new System.Windows.Forms.TreeView();
            this.pResult = new System.Windows.Forms.Panel();
            this.cbSearchWay = new System.Windows.Forms.ComboBox();
            this.cbAllItems = new System.Windows.Forms.ComboBox();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.chSearchType = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(26, 74);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(239, 24);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Введите слово";
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(279, 69);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(82, 32);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Поиск";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(669, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.словарьToolStripMenuItem,
            this.словарьToolStripMenuItem1});
            this.поискToolStripMenuItem.Image = global::Glossary.Properties.Resources.add_68121;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.поискToolStripMenuItem.Text = "Добавить";
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.Image = global::Glossary.Properties.Resources.font_type1_6638;
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.словарьToolStripMenuItem.Text = "Термин";
            this.словарьToolStripMenuItem.Click += new System.EventHandler(this.терминToolStripMenuItem_Click);
            // 
            // словарьToolStripMenuItem1
            // 
            this.словарьToolStripMenuItem1.Image = global::Glossary.Properties.Resources.contents_6677;
            this.словарьToolStripMenuItem1.Name = "словарьToolStripMenuItem1";
            this.словарьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.словарьToolStripMenuItem1.Text = "Словарь";
            this.словарьToolStripMenuItem1.Click += new System.EventHandler(this.словарьToolStripMenuItem1_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поТемамToolStripMenuItem,
            this.списокToolStripMenuItem1,
            this.статистикаToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.правкаToolStripMenuItem.Text = "Словари";
            // 
            // поТемамToolStripMenuItem
            // 
            this.поТемамToolStripMenuItem.Image = global::Glossary.Properties.Resources.gnome_settings_theme_3050;
            this.поТемамToolStripMenuItem.Name = "поТемамToolStripMenuItem";
            this.поТемамToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.поТемамToolStripMenuItem.Text = "По темам";
            this.поТемамToolStripMenuItem.Click += new System.EventHandler(this.поТемамToolStripMenuItem_Click);
            // 
            // списокToolStripMenuItem1
            // 
            this.списокToolStripMenuItem1.Image = global::Glossary.Properties.Resources.to_do_list_checked3_7581;
            this.списокToolStripMenuItem1.Name = "списокToolStripMenuItem1";
            this.списокToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.списокToolStripMenuItem1.Text = "Список";
            this.списокToolStripMenuItem1.Click += new System.EventHandler(this.списокToolStripMenuItem1_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Image = global::Glossary.Properties.Resources.gnome_power_statistics_65211;
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Image = global::Glossary.Properties.Resources.gnome_help_45581;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Glossary.Properties.Resources.text_x_authors_84741;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tvParent);
            this.groupBox1.Controls.Add(this.pResult);
            this.groupBox1.Location = new System.Drawing.Point(20, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tvParent
            // 
            this.tvParent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tvParent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tvParent.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvParent.Indent = 19;
            this.tvParent.Location = new System.Drawing.Point(386, 18);
            this.tvParent.Name = "tvParent";
            this.tvParent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tvParent.Size = new System.Drawing.Size(231, 246);
            this.tvParent.TabIndex = 6;
            this.tvParent.Visible = false;
            // 
            // pResult
            // 
            this.pResult.AutoScroll = true;
            this.pResult.BackColor = System.Drawing.Color.Transparent;
            this.pResult.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pResult.Location = new System.Drawing.Point(6, 18);
            this.pResult.Name = "pResult";
            this.pResult.Size = new System.Drawing.Size(374, 245);
            this.pResult.TabIndex = 5;
            // 
            // cbSearchWay
            // 
            this.cbSearchWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchWay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSearchWay.Items.AddRange(new object[] {
            "Искать везде",
            "Искать в словаре",
            "Искать по теме"});
            this.cbSearchWay.Location = new System.Drawing.Point(405, 72);
            this.cbSearchWay.Name = "cbSearchWay";
            this.cbSearchWay.Size = new System.Drawing.Size(188, 25);
            this.cbSearchWay.TabIndex = 5;
            // 
            // cbAllItems
            // 
            this.cbAllItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllItems.FormattingEnabled = true;
            this.cbAllItems.Location = new System.Drawing.Point(405, 104);
            this.cbAllItems.Name = "cbAllItems";
            this.cbAllItems.Size = new System.Drawing.Size(188, 25);
            this.cbAllItems.TabIndex = 6;
            this.cbAllItems.Visible = false;
            // 
            // cmsEdit
            // 
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmItemEdit});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(155, 26);
            // 
            // tmItemEdit
            // 
            this.tmItemEdit.Name = "tmItemEdit";
            this.tmItemEdit.Size = new System.Drawing.Size(154, 22);
            this.tmItemEdit.Text = "Редактировать";
            this.tmItemEdit.Click += new System.EventHandler(this.tmItemEdit_Click);
            // 
            // chSearchType
            // 
            this.chSearchType.AutoSize = true;
            this.chSearchType.BackColor = System.Drawing.Color.Transparent;
            this.chSearchType.Location = new System.Drawing.Point(26, 111);
            this.chSearchType.Name = "chSearchType";
            this.chSearchType.Size = new System.Drawing.Size(163, 21);
            this.chSearchType.TabIndex = 8;
            this.chSearchType.Text = "Искать в определении";
            this.chSearchType.UseVisualStyleBackColor = false;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.chSearchType);
            this.Controls.Add(this.cbAllItems);
            this.Controls.Add(this.cbSearchWay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Text = "  Словарь терминов";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.cmsEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pResult;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem1;
        private System.Windows.Forms.TreeView tvParent;
        private System.Windows.Forms.ToolStripMenuItem поТемамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbAllItems;
        private System.Windows.Forms.ComboBox cbSearchWay;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem tmItemEdit;
        private System.Windows.Forms.CheckBox chSearchType;
    }
}

