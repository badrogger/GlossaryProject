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
using Glossary.View;

namespace Glossary
{
    /// <summary>
    /// Главная форма программы.
    /// </summary>
    public partial class fMain : Form
    {
        List<Label> labels = new List<Label>(); // список меток для вывода результатов поиска
        int searchWay = 0; // тип поиска
        bool isFromEdit = false;  // вернулись ли из формы редактирования
        public fMain()

        {
            InitializeComponent();
        }

        /// <summary>
        /// Запуск формы.
        /// </summary>
        private void fMain_Load(object sender, EventArgs e)
        {
            
            TermsIO.Read();
            cbSearchWay.SelectedIndex = 0;
            cbSearchWay.SelectedIndexChanged += cbSearchWay_SelectedIndexChanged;
        }


        
        /// <summary>
        /// Метод обворачивания списка результатов поиска.
        /// </summary>
        private String Wrap(int id) {
            Term i = null;
            try
            {
                i = TermsIO.GetTermByID(id);
            }
            catch (KeyNotFoundException) {
               
            }
            String curVName = "";
            try
            {
                curVName = TermsIO.GetVocabByID(i.Vocab).Name;
            }
            catch (NullReferenceException) {
               
            }
            String wName = i.Name.Substring(0, 1).ToUpper() + i.Name.Substring(1, i.Name.Length - 1);
            return wName + ": " + i.Definition + Environment.NewLine;
            
        }

        /// <summary>
        /// Обработка изменения способа поиска
        /// </summary>
        private void cbSearchWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            String curT = cbSearchWay.Text;
            if (curT == "Искать везде")
            {
                cbAllItems.Visible = false; searchWay = 0;
            }
            if (curT == "Искать в словаре")
            {
                cbAllItems.Visible = true;
                searchWay = 1;
                cbAllItems.DataSource = TermsIO.GetAllVocabNames();
            }
            if (curT == "Искать по теме")
            {
                cbAllItems.Visible = true;
                searchWay = 2;
                cbAllItems.DataSource = TermsIO.GetAllThemeNames();
            }
            pResult.Controls.Clear();
            labels.Clear();
            tvParent.Nodes.Clear();
            tvParent.Visible = false;
            tbSearch.Text = "Введите термин";
        }
 
        /// <summary>
        /// Поиск терминов
        /// </summary>
        private void Search(String cterm) {
            cterm = cterm.ToLower(); 
            pResult.Controls.Add(new Label());
            labels.Clear();
            tvParent.Nodes.Clear();
            tvParent.Visible = false;
            pResult.Controls.Clear();
            List<int> temp = new List<int>();
            if (searchWay == 0) {
                if (!chSearchType.Checked)
                {
                    temp = TermsIO.TreeSearch(cterm);
                }
                else
                {
                    temp = TermsIO.SearchDefinition(cterm);
                }
            }
            if (searchWay == 1) {
                if (!chSearchType.Checked)
                {
                    temp = TermsIO.TreeSearchInVocab(cterm, cbAllItems.Text);
                }
                else {
                    temp = TermsIO.SearchDefinitionInVocab(cterm, cbAllItems.Text);
                }
            }
            if (searchWay == 2) {
                if (!chSearchType.Checked)
                {
                    temp = TermsIO.TreeSearchInTheme(cterm, cbAllItems.Text);
                }
                else {
                    temp = TermsIO.SearchDefinitionInTheme(cterm, cbAllItems.Text);
                }
            }
            
            if (temp.Count == 0 && !isFromEdit) {
                MessageBox.Show("Не найдено");
            }
            isFromEdit = false; 
            int x = 10, y = 15;
            
            for (int i = 0; i < temp.Count; i++)
            {
                
                labels.Add(new Label());
                int j = labels.Count - 1;
                labels[j].Text = Wrap(temp[i]);
                labels[j].Name = temp[i].ToString();
                Size sz = new Size(pResult.Width, Int32.MaxValue);
                sz = TextRenderer.MeasureText(labels[j].Text, labels[j].Font, sz, TextFormatFlags.WordBreak);
                
                labels[j].MinimumSize = new System.Drawing.Size(pResult.Size.Width - 30, sz.Height + 20);
                if (labels.Count == 1)
                {
                    labels[j].Location = new System.Drawing.Point(x, y);
                }
                else
                {
                    try
                    {
                        y += labels[i - 1].Size.Height + 20;
                        labels[j].Location = new System.Drawing.Point(x, y);
                    }
                    catch { }
                }
                labels[j].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                pResult.Controls.Add(labels[j]);

                labels[j].BackColor = Color.Transparent;
               
                labels[j].MouseClick += label_MouseClick;
                labels[j].ContextMenuStrip = cmsEdit;
              
                
            }
        }

        /// <summary>
        /// Нажатие на метку данного термина.
        /// </summary>
        void label_MouseClick(object sender, MouseEventArgs e)
        {
            tvParent.Visible = true; 
            foreach (var i in labels) {
                i.Font = new Font(i.Font, FontStyle.Regular);
            }
            var t = sender as Label;
            
            t.Font = new Font(t.Font, FontStyle.Bold);

            tvParentGetNodes(Convert.ToInt32(t.Name)); 
   
        }

        /// <summary>
        /// Метод получения дерева родителей.
        /// </summary>
        private void tvParentGetNodes(int id) {
            tvParent.Nodes.Clear();
            
            List<int> t = TermsIO.GetTermParentList(id);
            Vocabulary curV = Vocabulary.GetVocabByID(TermsIO.GetTermByID(id).Vocab);

            tvParent.Nodes.Add(TermsIO.NormalizeName(curV.Name));
            
            
            TreeNode curNode = tvParent.Nodes[0];
            curNode.NodeFont = new Font(tvParent.Font, FontStyle.Italic);
            
            for (int  i  = 0; i < t.Count; ++i) {
                TreeNode NodeToAdd = new TreeNode(TermsIO.NormalizeName(Term.GetTermByID(t[i]).Name));
                NodeToAdd.Name = t[i].ToString();
                curNode.Nodes.Add(NodeToAdd);
                curNode = NodeToAdd;
                if (i == t.Count - 1) curNode.BackColor = Color.Bisque;
            }
            
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Поиск".
        /// </summary>
        private void bSearch_Click(object sender, EventArgs e)
        {
            String cterm = tbSearch.Text.Trim();
            this.Search(cterm);
        }



        
        

        /// <summary>
        /// Обработка нажатия на "Добавить" + "Термин".
        /// </summary>
        private void терминToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddTerm fAT = new fAddTerm();
            fAT.ShowDialog(); 
        }

        /// <summary>
        /// Обработка нажатия на "Добавить" + "Словарь".
        /// </summary>
        private void словарьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FAddVocab fAV = new FAddVocab();
            fAV.ShowDialog(); 
        }

        /// <summary>
        /// Обработка нажатия на Enter.
        /// </summary>
        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bSearch_Click(null, null);
                
            }
        }

        /// <summary>
        /// Обработка нажатия на "Словари" + "По темам" .
        /// </summary>
        private void поТемамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThemes fTH = new FThemes();
            fTH.ShowDialog();
        }

        /// <summary>
        /// Обработка нажатия на "Словари" + "Список" .
        /// </summary>
        private void списокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FThVocabList fTVL = new FThVocabList();
            fTVL.ShowDialog();
        }


        /// <summary>
        /// Обработка нажатия на "Словари" + "Статистика" .
        /// </summary>
        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FStatistics fS = new FStatistics();
            fS.Complete();
            Hide();
            fS.ShowDialog();
            Show();
        }



        /// <summary>
        /// Обработка нажатия на "Справка" + "О программе".
        /// </summary>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAbout fAB = new FAbout();
            fAB.ShowDialog(); 
        }

        /// <summary>
        /// Обработка нажатия на "Справка" + "Помощь".
        /// </summary>
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHelp fH = new FHelp();
            fH.ShowDialog();
        }

        

        /// <summary>
        /// Метод, вызывающий окно редактирования термина.
        /// </summary>
        private void tmItemEdit_Click(object sender, EventArgs e)
        {
            var t = cmsEdit.SourceControl as Label;
            FEditTerm fET = new FEditTerm(Convert.ToInt32(t.Name));
            fET.ShowDialog();
            isFromEdit = true;
            bSearch_Click(null, null);
            
        }

        
    }
}
