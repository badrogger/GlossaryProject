using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glossary.Model;
using System.IO;
using Glossary.Control;

namespace Glossary
{
    public partial class fMain : Form
    {
        
        fAddTerm fAT = new fAddTerm();

        public fMain()
        {
            TermsIO.dict = new Dictionary<string, Term>(); 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TermsIO.Func();
            //TermsIO.ReadF();
            TermsIO.Load();
            //tBName.Text = TermsIO.dict["Football"].Name;
            //tBDescription.Text = TermsIO.dict["Football"].Description;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            String cterm = tbSearch.Text.Trim();
            if (TermsIO.dict.ContainsKey(cterm))
            {
                tbSearchResult.Text = TermsIO.dict[cterm].Description;
                List<String> backet = TermsIO.GetParentTree(TermsIO.dict[cterm]);

                lbCategory.DataSource = backet;

                
            }
            else tbSearchResult.Text = "Не найдено.";
        }

        /*private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьТерминToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAT.ShowDialog();
        }  

        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbSearchResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCategory_DoubleClick(object sender, EventArgs e)
        {
            tbSearch.Text = lbCategory.Text;
            String cterm = tbSearch.Text.Trim();
            if (TermsIO.dict.ContainsKey(cterm))
            {
                tbSearchResult.Text = TermsIO.dict[cterm].Description;
                List<String> backet = TermsIO.GetParentTree(TermsIO.dict[cterm]);

                lbCategory.DataSource = backet;


            }
            else tbSearchResult.Text = "Не найдено.";

        }
    }
}
