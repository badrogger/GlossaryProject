namespace Glossary.View
{
    partial class FStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStatistics));
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vocabularyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AllowUserToAddRows = false;
            this.dgvStatistic.AllowUserToDeleteRows = false;
            this.dgvStatistic.AllowUserToOrderColumns = true;
            this.dgvStatistic.AutoGenerateColumns = false;
            this.dgvStatistic.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvStatistic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Theme,
            this.termsNumberDataGridViewTextBoxColumn,
            this.Capacity});
            this.dgvStatistic.DataSource = this.vocabularyBindingSource;
            this.dgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistic.Location = new System.Drawing.Point(0, 0);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.Size = new System.Drawing.Size(793, 313);
            this.dgvStatistic.TabIndex = 0;
            this.dgvStatistic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatistic_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // Theme
            // 
            this.Theme.HeaderText = "Тема";
            this.Theme.MinimumWidth = 10;
            this.Theme.Name = "Theme";
            this.Theme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Theme.Width = 120;
            // 
            // termsNumberDataGridViewTextBoxColumn
            // 
            this.termsNumberDataGridViewTextBoxColumn.DataPropertyName = "TermsNumber";
            this.termsNumberDataGridViewTextBoxColumn.HeaderText = "Количество терминов";
            this.termsNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.termsNumberDataGridViewTextBoxColumn.Name = "termsNumberDataGridViewTextBoxColumn";
            this.termsNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.termsNumberDataGridViewTextBoxColumn.Width = 90;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Количество символов";
            this.Capacity.Name = "Capacity";
            this.Capacity.Width = 90;
            // 
            // vocabularyBindingSource
            // 
            this.vocabularyBindingSource.DataSource = typeof(Glossary.Model.Vocabulary);
            // 
            // FStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(793, 313);
            this.Controls.Add(this.dgvStatistic);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FStatistics";
            this.Text = "Сатистика словарей";
            this.Load += new System.EventHandler(this.fStatistics_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fStatistics_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.BindingSource vocabularyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn termsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}