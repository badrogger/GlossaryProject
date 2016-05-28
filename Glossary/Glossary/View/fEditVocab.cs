using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glossary.Control;
using Glossary.Model;

namespace Glossary.View
{
    public partial class FEditVocab : Form
    {
        private int cVocabID = -1;
        public FEditVocab()
        {
            InitializeComponent();
        }
        public FEditVocab(int id)
        {
            cVocabID = id;
            InitializeComponent();
        }

        private void fEditVocab_Load(object sender, EventArgs e)
        {
            Vocabulary cVocab = TermsIO.GetVocabByID(cVocabID);
            tbName.Text = cVocab.Name;
            tbDescription.Text = cVocab.Description;
            cbTheme.DataSource = TermsIO.GetAllThemeNames();
            cbTheme.Text = TermsIO.GetThemeByID(cVocab.MTheme).Name;
        }

        private void bAddOK_Click(object sender, EventArgs e)
        {
            TermsIO.EditVocab(cVocabID, tbName.Text, tbDescription.Text, cbTheme.Text);
            this.Close();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить словарь?", "Messege", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TermsIO.DeleteVocab(cVocabID);
                this.Close();
            }
        }
    }
}
