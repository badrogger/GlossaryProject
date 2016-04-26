namespace Glossary
{
    partial class fAddTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddTerm));
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.tbAddDescription = new System.Windows.Forms.TextBox();
            this.cbAddCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bAddOK = new System.Windows.Forms.Button();
            this.bAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(115, 23);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(100, 20);
            this.tbAddName.TabIndex = 0;
            // 
            // tbAddDescription
            // 
            this.tbAddDescription.Location = new System.Drawing.Point(115, 125);
            this.tbAddDescription.Multiline = true;
            this.tbAddDescription.Name = "tbAddDescription";
            this.tbAddDescription.Size = new System.Drawing.Size(227, 116);
            this.tbAddDescription.TabIndex = 1;
            // 
            // cbAddCategory
            // 
            this.cbAddCategory.FormattingEnabled = true;
            this.cbAddCategory.Location = new System.Drawing.Point(115, 72);
            this.cbAddCategory.Name = "cbAddCategory";
            this.cbAddCategory.Size = new System.Drawing.Size(121, 21);
            this.cbAddCategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание";
            // 
            // bAddOK
            // 
            this.bAddOK.Location = new System.Drawing.Point(276, 263);
            this.bAddOK.Name = "bAddOK";
            this.bAddOK.Size = new System.Drawing.Size(75, 23);
            this.bAddOK.TabIndex = 6;
            this.bAddOK.Text = "OK";
            this.bAddOK.UseVisualStyleBackColor = true;
            this.bAddOK.Click += new System.EventHandler(this.bAddOK_Click);
            // 
            // bAddCancel
            // 
            this.bAddCancel.Location = new System.Drawing.Point(357, 263);
            this.bAddCancel.Name = "bAddCancel";
            this.bAddCancel.Size = new System.Drawing.Size(75, 23);
            this.bAddCancel.TabIndex = 7;
            this.bAddCancel.Text = "Cancel";
            this.bAddCancel.UseVisualStyleBackColor = true;
            this.bAddCancel.Click += new System.EventHandler(this.bAddCancel_Click);
            // 
            // fAddTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 302);
            this.Controls.Add(this.bAddCancel);
            this.Controls.Add(this.bAddOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAddCategory);
            this.Controls.Add(this.tbAddDescription);
            this.Controls.Add(this.tbAddName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAddTerm";
            this.Text = "Добавить термин";
            this.Load += new System.EventHandler(this.fAddTerm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.TextBox tbAddDescription;
        private System.Windows.Forms.ComboBox cbAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAddOK;
        private System.Windows.Forms.Button bAddCancel;
    }
}