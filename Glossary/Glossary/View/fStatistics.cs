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
    public partial class FStatistics : Form
    {
        public FStatistics()
        {
            InitializeComponent();
            
            //dgvStatistic.DataSource = TermsIO.GetAllVocabs();
            
            //dgvStatistic.Columns[4].ValueType = typeof(Int32);
            

            
        }
        public void Complete() {
            
        }
        

        private void dgvStatistic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fStatistics_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void fStatistics_Load(object sender, EventArgs e)
        {
            List<Vocabulary> lstVocab = TermsIO.GetAllVocabs();
            dgvStatistic.DataSource = lstVocab;
            int i = 0;
            foreach (DataGridViewRow r in dgvStatistic.Rows)
            {
                r.Cells["Capacity"].ValueType = typeof(Int32);
                r.Cells["Capacity"].Value = TermsIO.GetAllCharsInVocab(lstVocab[i].ID);
                r.Cells["Theme"].Value = TermsIO.GetThemeByID(lstVocab[i].MTheme).Name;
                ++i;
            }
        }
    }
}
