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
    public partial class FThemes : Form
    {
        
        public FThemes()
        {
            InitializeComponent();
            
        }
        private void VocabListCall(int id) {
            FThVocabList fTVL = new FThVocabList(id);
            if (TermsIO.GetAllVocabsNamesInTheme(id).Count == 0) {
                MessageBox.Show("Словарей нет. Добавьте новый");
                return; 
            }
            this.Hide();
            fTVL.ShowDialog();
            this.Close();
        }

        private void pB0_Click(object sender, EventArgs e)
        {
            VocabListCall(0);
        }

        private void pB1_Click(object sender, EventArgs e)
        {
            VocabListCall(1);
        }

        private void pB2_Click(object sender, EventArgs e)
        {
            VocabListCall(2);
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            VocabListCall(3);
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            VocabListCall(4);
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            VocabListCall(5);
        }

        private void pB6_Click(object sender, EventArgs e)
        {
            VocabListCall(6);
        }

        private void pB7_Click(object sender, EventArgs e)
        {
            VocabListCall(7);
        }

        private void pB8_Click(object sender, EventArgs e)
        {
            VocabListCall(8);
        }
    }
}
