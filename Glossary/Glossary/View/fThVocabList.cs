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
    public partial class FThVocabList : Form
    {
        public FThVocabList()
        {
            InitializeComponent();
        }
        private int cTheme = -1;
        public FThVocabList(int themeID)
        {
            InitializeComponent();
            cTheme = themeID;
        }
        private void ThemeComplete() {
            this.Text += " теме \"" + TermsIO.GetThemeByID(cTheme).Name + "\"";
            int j = 0;
            foreach (var i in TermsIO.GetAllVocabsNamesInTheme(cTheme))
            {
                lVocab.Items.Add(new ListViewItem(i));
                lVocab.Items[j].Name = TermsIO.GetThemeByID(cTheme).Vocabs[j].ToString();
                ++j;
            }
            
        }
        private void Complete()
        {
            this.Text = "Cписок словарей";
            int j = 0;
            var Source = TermsIO.GetAllVocabNames();
            foreach (var i in Source) {
                lVocab.Items.Add(new ListViewItem(i));
                lVocab.Items[j].Name = TermsIO.GetVocabByName(i).ID.ToString(); 
                ++j;
            }
        }
        private void fThVocabList_Load(object sender, EventArgs e)
        {
            if (cTheme >= 0)
            {
                ThemeComplete();
            }
            else {
                Complete(); 
            }
            lVocab.MouseDoubleClick += lVocab_DoubleMouse_Click;
        }
        private void lVocab_DoubleMouse_Click(object sender, EventArgs e) {
            if (lVocab.SelectedItems.Count == 0) return;
            int sVocabId = Convert.ToInt32(lVocab.SelectedItems[0].Name);
            FEditVocab fEV = new FEditVocab(sVocabId);
            this.Hide();
            fEV.ShowDialog();
            this.Close();

        }

        private void lVocab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
