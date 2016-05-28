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

namespace Glossary.View
{
    public partial class FAddVocab : Form
    {
        public FAddVocab()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bAddOK_Click(object sender, EventArgs e)
        {
            try {
                TermsIO.GetVocabByName(tbName.Text);
            }
            catch (KeyNotFoundException) {
                TermsIO.AddVocab(tbName.Text, cbTheme.Text, tbDescription.Text);
                this.Close();
                return; 
            }
            MessageBox.Show("Словарь с таким именем уже существует");

        }
        private void bAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddVocab_Load(object sender, EventArgs e)
        {
            cbTheme.DataSource = TermsIO.GetAllThemeNames(); 
        }
    }
}
