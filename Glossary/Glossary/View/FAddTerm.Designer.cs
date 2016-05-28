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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddTerm));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDefinition = new System.Windows.Forms.TextBox();
            this.cbParent = new System.Windows.Forms.ComboBox();
            this.bsParent = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lParent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bAddOK = new System.Windows.Forms.Button();
            this.bAddCancel = new System.Windows.Forms.Button();
            this.cbVocabulary = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsParent)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(153, 30);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(229, 24);
            this.tbName.TabIndex = 0;
            // 
            // tbDefinition
            // 
            this.tbDefinition.Location = new System.Drawing.Point(153, 209);
            this.tbDefinition.Margin = new System.Windows.Forms.Padding(4);
            this.tbDefinition.Multiline = true;
            this.tbDefinition.Name = "tbDefinition";
            this.tbDefinition.Size = new System.Drawing.Size(503, 167);
            this.tbDefinition.TabIndex = 1;
            // 
            // cbParent
            // 
            this.cbParent.DataSource = this.bsParent;
            this.cbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParent.FormattingEnabled = true;
            this.cbParent.Location = new System.Drawing.Point(153, 141);
            this.cbParent.Margin = new System.Windows.Forms.Padding(4);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(229, 25);
            this.cbParent.TabIndex = 2;
            this.cbParent.Visible = false;
            
            // 
            // bsParent
            // 
            this.bsParent.DataSource = typeof(Glossary.Model.Vocabulary);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            
            // 
            // lParent
            // 
            this.lParent.AutoSize = true;
            this.lParent.BackColor = System.Drawing.Color.Transparent;
            this.lParent.Location = new System.Drawing.Point(16, 141);
            this.lParent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lParent.Name = "lParent";
            this.lParent.Size = new System.Drawing.Size(118, 17);
            this.lParent.TabIndex = 4;
            this.lParent.Text = "Термин-родитель";
            this.lParent.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Определение";
            
            // 
            // bAddOK
            // 
            this.bAddOK.Location = new System.Drawing.Point(449, 401);
            this.bAddOK.Margin = new System.Windows.Forms.Padding(4);
            this.bAddOK.Name = "bAddOK";
            this.bAddOK.Size = new System.Drawing.Size(100, 30);
            this.bAddOK.TabIndex = 6;
            this.bAddOK.Text = "Добавить";
            this.bAddOK.UseVisualStyleBackColor = true;
            this.bAddOK.Click += new System.EventHandler(this.bAddOK_Click);
            // 
            // bAddCancel
            // 
            this.bAddCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAddCancel.Location = new System.Drawing.Point(557, 401);
            this.bAddCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bAddCancel.Name = "bAddCancel";
            this.bAddCancel.Size = new System.Drawing.Size(100, 30);
            this.bAddCancel.TabIndex = 7;
            this.bAddCancel.Text = "Отмена";
            this.bAddCancel.UseVisualStyleBackColor = true;
            this.bAddCancel.Click += new System.EventHandler(this.bAddCancel_Click);
            // 
            // cbVocabulary
            // 
            this.cbVocabulary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVocabulary.FormattingEnabled = true;
            this.cbVocabulary.Location = new System.Drawing.Point(153, 86);
            this.cbVocabulary.Margin = new System.Windows.Forms.Padding(4);
            this.cbVocabulary.Name = "cbVocabulary";
            this.cbVocabulary.Size = new System.Drawing.Size(229, 25);
            this.cbVocabulary.TabIndex = 8;
            
            this.cbVocabulary.TextChanged += new System.EventHandler(this.cbVocabulary_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Словарь";
            // 
            // fAddTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bAddCancel;
            this.ClientSize = new System.Drawing.Size(727, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVocabulary);
            this.Controls.Add(this.bAddCancel);
            this.Controls.Add(this.bAddOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbParent);
            this.Controls.Add(this.tbDefinition);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fAddTerm";
            this.Text = "Добавить термин";
            this.Load += new System.EventHandler(this.fAddTerm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDefinition;
        private System.Windows.Forms.ComboBox cbParent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lParent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAddOK;
        private System.Windows.Forms.Button bAddCancel;
        private System.Windows.Forms.ComboBox cbVocabulary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsParent;
    }
}