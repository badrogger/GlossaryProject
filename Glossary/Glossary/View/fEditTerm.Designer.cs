namespace Glossary.View
{
    partial class FEditTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditTerm));
            this.bEditCancel = new System.Windows.Forms.Button();
            this.bEditSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParent = new System.Windows.Forms.ComboBox();
            this.tbDefinition = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVocabulary = new System.Windows.Forms.ComboBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bsParent = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsParent)).BeginInit();
            this.SuspendLayout();
            // 
            // bEditCancel
            // 
            this.bEditCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bEditCancel.Location = new System.Drawing.Point(455, 361);
            this.bEditCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bEditCancel.Name = "bEditCancel";
            this.bEditCancel.Size = new System.Drawing.Size(100, 30);
            this.bEditCancel.TabIndex = 15;
            this.bEditCancel.Text = "Отмена";
            this.bEditCancel.UseVisualStyleBackColor = true;
            this.bEditCancel.Click += new System.EventHandler(this.bEditCancel_Click);
            // 
            // bEditSave
            // 
            this.bEditSave.Location = new System.Drawing.Point(239, 361);
            this.bEditSave.Margin = new System.Windows.Forms.Padding(4);
            this.bEditSave.Name = "bEditSave";
            this.bEditSave.Size = new System.Drawing.Size(100, 30);
            this.bEditSave.TabIndex = 14;
            this.bEditSave.Text = "Сохранить";
            this.bEditSave.UseVisualStyleBackColor = true;
            this.bEditSave.Click += new System.EventHandler(this.bEditSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Термин-родитель";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // cbParent
            // 
            this.cbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParent.FormattingEnabled = true;
            this.cbParent.Location = new System.Drawing.Point(165, 136);
            this.cbParent.Margin = new System.Windows.Forms.Padding(4);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(229, 25);
            this.cbParent.TabIndex = 10;
            // 
            // tbDefinition
            // 
            this.tbDefinition.Location = new System.Drawing.Point(165, 191);
            this.tbDefinition.Margin = new System.Windows.Forms.Padding(4);
            this.tbDefinition.Multiline = true;
            this.tbDefinition.Name = "tbDefinition";
            this.tbDefinition.Size = new System.Drawing.Size(390, 150);
            this.tbDefinition.TabIndex = 9;
            
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(165, 35);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(132, 24);
            this.tbName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(39, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Словарь";
            // 
            // cbVocabulary
            // 
            this.cbVocabulary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVocabulary.Location = new System.Drawing.Point(165, 92);
            this.cbVocabulary.Margin = new System.Windows.Forms.Padding(4);
            this.cbVocabulary.Name = "cbVocabulary";
            this.cbVocabulary.Size = new System.Drawing.Size(229, 25);
            this.cbVocabulary.TabIndex = 16;
            this.cbVocabulary.TextChanged += new System.EventHandler(this.cbVocabulary_TextChanged);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(347, 361);
            this.bDelete.Margin = new System.Windows.Forms.Padding(4);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(100, 30);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bsParent
            // 
            this.bsParent.DataSource = typeof(Glossary.Model.Vocabulary);
            // 
            // FEditTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.bEditCancel;
            this.ClientSize = new System.Drawing.Size(629, 415);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVocabulary);
            this.Controls.Add(this.bEditCancel);
            this.Controls.Add(this.bEditSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbParent);
            this.Controls.Add(this.tbDefinition);
            this.Controls.Add(this.tbName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FEditTerm";
            this.Text = "Редактировать термин";
            this.Load += new System.EventHandler(this.fEditTerm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEditCancel;
        private System.Windows.Forms.Button bEditSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbParent;
        private System.Windows.Forms.TextBox tbDefinition;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVocabulary;
        private System.Windows.Forms.BindingSource bsParent;
        private System.Windows.Forms.Button bDelete;
    }
}