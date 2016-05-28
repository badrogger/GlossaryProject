using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Glossary.View;
using Glossary.Model;
using Glossary.Control;

namespace Glossary.View
{
    public partial class FEditTerm : Form
    {
        int cTermID; 
        public FEditTerm(int tID)
        {
            cTermID = tID; 
            InitializeComponent();
        }
        public FEditTerm()
        {
            InitializeComponent();
        }
        private void fEditTerm_Load(object sender, EventArgs e)
        {
            Term t = TermsIO.GetTermByID(cTermID);
            tbName.Text = t.Name;
            cbVocabulary.DataSource = TermsIO.GetAllVocabNames();
            Vocabulary cv = TermsIO.GetVocabByID(t.Vocab);
            cbVocabulary.Text = cv.Name;
            cbParent.DataSource = cv.AllTermsNames(); 
            cbParent.Text = t.Parent == -1 ? "\"Отсутствует\"":TermsIO.GetTermByID(t.Parent).Name;
            tbDefinition.Text = t.Definition;
        }

        private void bEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbVocabulary_TextChanged(object sender, EventArgs e)
        {
            List<String> toDS = TermsIO.GetVocabByName(cbVocabulary.Text).AllTermsNames();
            toDS.Insert(0, "\"Отсутствует\"");
            bsParent.DataSource = toDS;
            cbParent.DataSource = toDS;
        }

        private void bEditSave_Click(object sender, EventArgs e)
        {
            String newName = tbName.Text.Trim();
            Regex regex = new Regex("[^А - Яа - я]");
            if (!regex.IsMatch(newName))
            {
                TermsIO.EditTerm(cTermID, tbName.Text, tbDefinition.Text, cbVocabulary.Text, cbParent.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное название (Название должно состоять только из русских букв)");
            }
            
            
            
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить термин?", "Messege", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                TermsIO.DeleteTerm(cTermID);
                this.Close(); 
            }
            
        }
    }
}
