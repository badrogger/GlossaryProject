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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStatistics));
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chTerms = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chCapacity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vocabularyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AllowUserToAddRows = false;
            this.dgvStatistic.AllowUserToDeleteRows = false;
            this.dgvStatistic.AllowUserToOrderColumns = true;
            this.dgvStatistic.AutoGenerateColumns = false;
            this.dgvStatistic.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvStatistic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Theme,
            this.descriptionDataGridViewTextBoxColumn,
            this.termsNumberDataGridViewTextBoxColumn,
            this.Capacity});
            this.dgvStatistic.DataSource = this.vocabularyBindingSource;
            this.dgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistic.Location = new System.Drawing.Point(0, 0);
            this.dgvStatistic.MaximumSize = new System.Drawing.Size(0, 160);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.Size = new System.Drawing.Size(742, 160);
            this.dgvStatistic.TabIndex = 0;
            // 
            // Theme
            // 
            this.Theme.HeaderText = "Тема";
            this.Theme.MinimumWidth = 10;
            this.Theme.Name = "Theme";
            this.Theme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Theme.Width = 130;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Количество символов";
            this.Capacity.Name = "Capacity";
            this.Capacity.Width = 90;
            // 
            // chTerms
            // 
            this.chTerms.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            chartArea1.Name = "ChartArea1";
            this.chTerms.ChartAreas.Add(chartArea1);
            this.chTerms.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chTerms.Legends.Add(legend1);
            this.chTerms.Location = new System.Drawing.Point(35, 174);
            this.chTerms.Name = "chTerms";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chTerms.Series.Add(series1);
            this.chTerms.Size = new System.Drawing.Size(299, 178);
            this.chTerms.TabIndex = 1;
            this.chTerms.Text = "Количество терминов";
            // 
            // chCapacity
            // 
            this.chCapacity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            chartArea2.Name = "ChartArea1";
            this.chCapacity.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chCapacity.Legends.Add(legend2);
            this.chCapacity.Location = new System.Drawing.Point(409, 174);
            this.chCapacity.Name = "chCapacity";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chCapacity.Series.Add(series2);
            this.chCapacity.Size = new System.Drawing.Size(299, 178);
            this.chCapacity.TabIndex = 2;
            this.chCapacity.Text = "Количество символов";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 59;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // termsNumberDataGridViewTextBoxColumn
            // 
            this.termsNumberDataGridViewTextBoxColumn.DataPropertyName = "TermsNumber";
            this.termsNumberDataGridViewTextBoxColumn.HeaderText = "Количество терминов";
            this.termsNumberDataGridViewTextBoxColumn.Name = "termsNumberDataGridViewTextBoxColumn";
            this.termsNumberDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(742, 364);
            this.Controls.Add(this.chCapacity);
            this.Controls.Add(this.chTerms);
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
            ((System.ComponentModel.ISupportInitialize)(this.chTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTerms;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCapacity;
        private System.Windows.Forms.BindingSource vocabularyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn termsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}