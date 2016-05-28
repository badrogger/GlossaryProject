namespace Glossary.View
{
    partial class FEditVocab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditVocab));
            this.label4 = new System.Windows.Forms.Label();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.bAddCancel = new System.Windows.Forms.Button();
            this.bAddOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Тематика";
            // 
            // cbTheme
            // 
            this.cbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(141, 108);
            this.cbTheme.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(245, 25);
            this.cbTheme.TabIndex = 36;
            // 
            // bAddCancel
            // 
            this.bAddCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAddCancel.Font = new System.Drawing.Font("Garamond", 10.25F);
            this.bAddCancel.Location = new System.Drawing.Point(533, 397);
            this.bAddCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bAddCancel.Name = "bAddCancel";
            this.bAddCancel.Size = new System.Drawing.Size(100, 30);
            this.bAddCancel.TabIndex = 35;
            this.bAddCancel.Text = "Отмена";
            this.bAddCancel.UseVisualStyleBackColor = true;
            // 
            // bAddOK
            // 
            this.bAddOK.Location = new System.Drawing.Point(317, 396);
            this.bAddOK.Margin = new System.Windows.Forms.Padding(4);
            this.bAddOK.Name = "bAddOK";
            this.bAddOK.Size = new System.Drawing.Size(100, 30);
            this.bAddOK.TabIndex = 34;
            this.bAddOK.Text = "Сохранить";
            this.bAddOK.UseVisualStyleBackColor = true;
            this.bAddOK.Click += new System.EventHandler(this.bAddOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(20, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Описание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Название";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(141, 192);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(503, 167);
            this.tbDescription.TabIndex = 31;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 53);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(209, 24);
            this.tbName.TabIndex = 30;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(425, 397);
            this.bDelete.Margin = new System.Windows.Forms.Padding(4);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(100, 30);
            this.bDelete.TabIndex = 38;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // FEditVocab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bAddCancel;
            this.ClientSize = new System.Drawing.Size(665, 481);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.bAddCancel);
            this.Controls.Add(this.bAddOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FEditVocab";
            this.Text = "Редактировать словарь";
            this.Load += new System.EventHandler(this.fEditVocab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAddOK;
        private System.Windows.Forms.Button bAddCancel;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDelete;
    }
}