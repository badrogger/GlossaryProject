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

namespace Glossary
{
    public partial class fAddTerm : Form
    {
        public fAddTerm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bAddOK_Click(object sender, EventArgs e)
        {
            TermsIO.Add(tbAddName.Text, cbAddCategory.Text, tbAddDescription.Text);
            
            this.Close();
        }

        private void bAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddTerm_Load(object sender, EventArgs e)
        {
            tbAddName.Clear();
            cbAddCategory.Text = "";
            tbAddDescription.Clear();

        }
    }
}
