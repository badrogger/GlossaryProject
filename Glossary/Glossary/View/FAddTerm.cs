using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


using System.Windows.Forms;
using Glossary.Control;

namespace Glossary
{
    public partial class fAddTerm : Form
    {
        
        public fAddTerm()
        {
            InitializeComponent();
        }

        

        private void bAddOK_Click(object sender, EventArgs e)
        {
            String newName = tbName.Text.Trim();
            Regex regex = new Regex("[^А - Яа - я]");
            if (!regex.IsMatch(newName))
            {
                TermsIO.AddTerm(tbName.Text, tbDefinition.Text, cbVocabulary.Text, cbParent.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное название (Название должно состоять только из русских букв)");
            }
            this.Close();
            
        }

        

        private void bAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddTerm_Load(object sender, EventArgs e)
        {
            tbName.Clear();
            cbVocabulary.DataSource = TermsIO.GetAllVocabNames();
            if (cbVocabulary.Text != null && cbVocabulary.Text != "") {
                cbParent.Visible = true;
                lParent.Visible = true;
            }
            
            tbDefinition.Clear();

        }
        
        

       
        

        private void cbVocabulary_TextChanged(object sender, EventArgs e)
        {
            List<String> toDS = TermsIO.GetVocabByName(cbVocabulary.Text).AllTermsNames();
            toDS.Insert(0, "\"Отсутствует\"");

            bsParent.DataSource = toDS;
            cbParent.DataSource = toDS;
            if (cbVocabulary.Text != null && cbVocabulary.Text != "")
            {
                cbParent.Visible = true;
                lParent.Visible = true;
            }
        }

        
    }
}
