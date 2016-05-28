namespace Glossary.View
{
    partial class FAddVocab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddVocab));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lParent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.bAddCancel = new System.Windows.Forms.Button();
            this.bAddOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-116, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Словарь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-131, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Определение";
            // 
            // lParent
            // 
            this.lParent.AutoSize = true;
            this.lParent.Location = new System.Drawing.Point(-131, 81);
            this.lParent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lParent.Name = "lParent";
            this.lParent.Size = new System.Drawing.Size(118, 17);
            this.lParent.TabIndex = 14;
            this.lParent.Text = "Термин-родитель";
            this.lParent.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-116, -26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(7, -30);
            this.tbAddName.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(132, 24);
            this.tbAddName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Тематика";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbTheme
            // 
            this.cbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(150, 116);
            this.cbTheme.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(245, 25);
            this.cbTheme.TabIndex = 28;
            // 
            // bAddCancel
            // 
            this.bAddCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAddCancel.Font = new System.Drawing.Font("Garamond", 10.25F);
            this.bAddCancel.Location = new System.Drawing.Point(542, 405);
            this.bAddCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bAddCancel.Name = "bAddCancel";
            this.bAddCancel.Size = new System.Drawing.Size(100, 30);
            this.bAddCancel.TabIndex = 27;
            this.bAddCancel.Text = "Отмена";
            this.bAddCancel.UseVisualStyleBackColor = true;
            this.bAddCancel.Click += new System.EventHandler(this.bAddCancel_Click);
            // 
            // bAddOK
            // 
            this.bAddOK.Location = new System.Drawing.Point(434, 405);
            this.bAddOK.Margin = new System.Windows.Forms.Padding(4);
            this.bAddOK.Name = "bAddOK";
            this.bAddOK.Size = new System.Drawing.Size(100, 30);
            this.bAddOK.TabIndex = 26;
            this.bAddOK.Text = "Добавить";
            this.bAddOK.UseVisualStyleBackColor = true;
            this.bAddOK.Click += new System.EventHandler(this.bAddOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(29, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Описание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(29, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Название";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(150, 200);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(503, 167);
            this.tbDescription.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(150, 61);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(209, 24);
            this.tbName.TabIndex = 20;
            // 
            // FAddVocab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bAddCancel;
            this.ClientSize = new System.Drawing.Size(682, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.bAddCancel);
            this.Controls.Add(this.bAddOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddName);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FAddVocab";
            this.Text = "Добавить словарь";
            this.Load += new System.EventHandler(this.fAddVocab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lParent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button bAddOK;
        private System.Windows.Forms.Button bAddCancel;
        private System.Windows.Forms.ComboBox cbTheme;
    }
}