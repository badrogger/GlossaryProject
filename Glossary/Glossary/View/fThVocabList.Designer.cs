namespace Glossary.View
{
    partial class FThVocabList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FThVocabList));
            this.lVocab = new System.Windows.Forms.ListView();
            this.vocabularyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lVocab
            // 
            this.lVocab.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lVocab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lVocab.BackgroundImage = global::Glossary.Properties.Resources._0_c76a4_430f29de_XL;
            this.lVocab.Location = new System.Drawing.Point(54, 56);
            this.lVocab.Name = "lVocab";
            this.lVocab.Size = new System.Drawing.Size(266, 233);
            this.lVocab.TabIndex = 0;
            this.lVocab.UseCompatibleStateImageBehavior = false;
            this.lVocab.View = System.Windows.Forms.View.List;
            this.lVocab.SelectedIndexChanged += new System.EventHandler(this.lVocab_SelectedIndexChanged);
            // 
            // vocabularyBindingSource
            // 
            this.vocabularyBindingSource.DataSource = typeof(Glossary.Model.Vocabulary);
            // 
            // FThVocabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(379, 341);
            this.Controls.Add(this.lVocab);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FThVocabList";
            this.Text = "Список словарей в";
            this.Load += new System.EventHandler(this.fThVocabList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vocabularyBindingSource;
        private System.Windows.Forms.ListView lVocab;
    }
}