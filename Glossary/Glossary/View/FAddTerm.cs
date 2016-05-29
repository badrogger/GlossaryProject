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


        /// <summary>
        /// Обработчик нажатия на кнопку сохранить.
        /// </summary>
        private void bAddOK_Click(object sender, EventArgs e)
        {
            String newName = tbName.Text.Trim().ToLower(); 

            String newDefinition = tbDefinition.Text.Trim();

            var newVocab = TermsIO.GetVocabByName(cbVocabulary.Text);
            if (newVocab.Terms.Where(tid => TermsIO.GetTermByID(tid).Name.Equals(newName)).Count() > 0)
            {
                MessageBox.Show("Термин с таким именем уже есть");
                return;
            }
            Regex regex = new Regex("^[а-яА-ЯёЁ]+$");
          
            if (regex.IsMatch(newName) && newDefinition != "")
            {
                TermsIO.AddTerm(newName, newDefinition, cbVocabulary.Text, cbParent.Text);
                this.Close();
            }
            else
            {
                if (!regex.IsMatch(newName))
                    MessageBox.Show("Неверное название (Название должно состоять только из русских букв)");
                else if (newDefinition == "")
                    MessageBox.Show("Определение не может быть пустым");
            }
            
            
        }

        

        private void bAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик загрузки формы.
        /// </summary>
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





        /// <summary>
        ///  Обработчик изменения словаря в списке.
        /// </summary>
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
