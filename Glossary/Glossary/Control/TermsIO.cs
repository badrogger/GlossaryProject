using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glossary.Model;
using System.IO;
using Newtonsoft.Json;

namespace Glossary.Control
{
    /// <summary>
    ///  Класс, реализующий взаимодействие форм с моделью.
    /// </summary>
    class TermsIO
    {
        /// <summary>
        ///  Статический метод чтения из файла.
        /// </summary>
        public static void Read() {
            readThemes();
            readVocabs();
            readTerms();  
        }
        

        
        /// <summary>
        ///  Статический метод перезаписи словарей и терминов.
        /// </summary>
        public static void Rewrite() {
            rewriteVocabularys();
            rewriteTerms();
        }

        /// <summary>
        ///  Статический метод поиска терминов по имени во всех словарях.
        /// </summary>
        public static List<int> Search(String termName) {
            List<Term> tmp = new List<Term>();
            List<int> res = new List<int>();
            try
            {
                tmp = Term.GetTermsByName(termName);
            }
            catch (KeyNotFoundException) {

                 return res;
            }

            foreach (var i in tmp) {
                Vocabulary cur = Vocabulary.GetVocabByID(i.Vocab);
                res.Add(i.ID);
            }
            return res;
        }

        /// <summary>
        ///  Статический метод поиска терминов по имени в заданном словаре.
        /// </summary>
        public static List<int> SearchInVocab(String termName, String vName) {
            Vocabulary v = Vocabulary.GetVocabByName(vName);
            return v.GetTermsByName(termName);
        }

        /// <summary>
        ///  Статический метод поиска терминов по имени в словарях на определенную тему.        
        ///  </summary>
        public static List<int> SearchInTheme(String termName, String tName) {
            Theme t = Theme.GetThemeByName(tName);
            return t.GetTermsByName(termName); 
        }

        /// <summary>
        ///  Статический метод поиска терминов по определению во всех словарях.
        /// </summary>
        public static List<int> SearchDefinition(String pattern) {
            return Term.SearchInDefinitions(pattern);
        }

        /// <summary>
        ///  Статический метод поиска терминов по определению во определенном словаре.
        /// </summary>
        public static List<int> SearchDefinitionInVocab(String pattern, String vName) {
            Vocabulary v = Vocabulary.GetVocabByName(vName);
            return v.Terms.Where(t => t >= 0 && Term.GetTermByID(t).Definition.Contains(pattern)).ToList();
        }

        /// <summary>
        ///  Статический метод поиска терминов по определению в словарях на определенную тему.
        /// </summary>
        public static List<int> SearchDefinitionInTheme(String pattern, String tName) {
            Theme CTheme = Theme.GetThemeByName(tName);
            return CTheme.GetTermsByDefinitions(pattern);
            
        }


        /// <summary>
        ///  Статический метод поиска термина с помощью бора.
        /// </summary>
        public static List<int> TreeSearch(String term) {
            List<int> res = new List<int>(Term.SearchByTree(term));
            return res; 
        }

        /// <summary>
        ///  Статический метод поиска термина в определенном словаре с помощью бора.
        /// </summary>
        public static List<int> TreeSearchInVocab(String term, String vocabName)
        {
            int vocabID = Vocabulary.GetIDByName(vocabName);
            List<int> res = new List<int>(Term.SearchByTree(term));
            return res.Where(t => Term.GetTermByID(t).Vocab == vocabID).ToList();
        }

        /// <summary>
        ///  Статический метод поиска в словарях на заданную тематику с помощью бора.
        /// </summary>
        public static List<int> TreeSearchInTheme(String term, String themeName)
        {
            int themeID = Theme.GetThemeByName(themeName).ID;
            List<int> res = new List<int>(Term.SearchByTree(term));
            return res.Where(t => Vocabulary.GetVocabByID(Term.GetTermByID(t).Vocab).MTheme == themeID).ToList();
        }
        /// <summary>
        ///  Статический метод, возвращающий термина по id.
        /// </summary>
        public static Term GetTermByID(int id) {
            return Term.GetTermByID(id);
        }

        /// <summary>
        ///  Статический метод, возвращающий словарь по id.
        /// </summary>
        public static Vocabulary GetVocabByID(int id)
        {
            return Vocabulary.GetVocabByID(id);
        }

        /// <summary>
        ///  Статический метод, возвращающий тему по id.
        /// </summary>
        public static Theme GetThemeByID(int id)
        {
            return Theme.GetThemeByID(id);
        }


        /// <summary>
        ///  Статический метод, возвращающий словарь по имени.
        /// </summary>
        public static Vocabulary GetVocabByName(String name)
        {
            return Vocabulary.GetVocabByName(name);
        }


        /// <summary>
        ///  Статический метод, возвращающий список имен всех словарей.
        /// </summary>
        public static List<String> GetAllVocabNames() {
            List<String> res = new List<string>();
            res.AddRange(Vocabulary.AllItemsNames);
            return res;
        }

        /// <summary>
        ///  Статический метод, возвращающий список всех словарей.
        /// </summary>
        public static List<Vocabulary> GetAllVocabs() {
            return new List<Vocabulary>(Vocabulary.AllItems());
        }

        /// <summary>
        ///  Статический метод, возвращающий список имен всех тем.
        /// </summary>
        public static List<String> GetAllThemeNames() {
            List<String> res = new List<string>();
            res.AddRange(Theme.AllItemsNames);
            return res;
        }

        /// <summary>
        ///  Статический метод, возвращающий список имен всех словарей в заданной теме.
        /// </summary>
        public static List<String> GetAllVocabsNamesInTheme(int themeID) {
            Theme cTheme = Theme.GetThemeByID(themeID);
            return cTheme.GetAllVocabsNames();
        }

        /// <summary>
        ///  Статический метод, возвращающий список id всех словарей в заданной теме.
        /// </summary>
        public static List<int> GetAllVocabsIDsInTheme(int themeID)
        {
            Theme cTheme = Theme.GetThemeByID(themeID);
            return cTheme.GetAllVocabsIDs();
        }

        /// <summary>
        ///  Статический метод, возвращающий количество символов во всех определениях терминов в словаре.
        /// </summary>
        public static long GetAllCharsInVocab(int vocabID) {
            return Vocabulary.GetVocabByID(vocabID).GetNumberOfChars();
        }


        /// <summary>
        ///  Статический метод, добавления термина.
        /// </summary>
        public static void AddTerm(String name, String definition, String vocabName, String parentName)
        {
            StreamWriter TermsWriter = new StreamWriter("Terms.json", true);
            int vid = Vocabulary.GetIDByName(vocabName);
            Vocabulary Voc = Vocabulary.GetVocabByName(vocabName);

            int pid = -1;
            if (parentName != "\"Отсутствует\"")
            {
                pid = Voc.Terms.Find(x => Term.GetTermByID(x).Name == parentName);
            }
            
            Term toAdd = new Term(name, definition, vid, pid);

            TermsWriter.WriteLine(JsonConvert.SerializeObject(toAdd));
            TermsWriter.Close();
        }



        /// <summary>
        ///  Статический метод, добавления словаря.
        /// </summary>
        public static void AddVocab(String name, String theme, String description) {
            StreamWriter wv = new StreamWriter("Vocabularys.json", true);
            Vocabulary toAdd = new Vocabulary(name, description, Theme.GetThemeByName(theme).ID);
            wv.WriteLine(JsonConvert.SerializeObject(toAdd));
            wv.Close(); 
        }

        

        /// <summary>
        ///  Статический метод, редактирования термина.
        /// </summary>
        public static void EditTerm(int id, String name, String definition, String vocab, String p) {
            Term t = Term.GetTermByID(id);
            t.Name = name; t.Definition = definition;
            t.Vocab = Vocabulary.GetVocabByName(vocab).ID;
            if (p == "\"Отсутствует\"") t.Parent = -1;
            else t.Parent = Vocabulary.GetVocabByName(vocab).Terms.Find(i => Term.GetTermByID(i).Name == p);
            Rewrite(); 
        }

        /// <summary>
        ///  Статический метод, редактирования словаря.
        /// </summary>
        public static void EditVocab(int id, String name, String description, String theme) {
            Vocabulary v = Vocabulary.GetVocabByID(id);
            v.Name = name; v.Description = description;
            v.MTheme = Theme.GetThemeByName(theme).ID;
            Rewrite(); 
        }

        /// <summary>
        ///  Статический метод удаления термина.
        /// </summary>
        public static void DeleteTerm(int id)
        {
            Term.GetTermByID(id).Remove();
            Rewrite();
        }


        /// <summary>
        ///  Статический метод удаления словаря.
        /// </summary>
        public static void DeleteVocab(int id)
        {
            Vocabulary.GetVocabByID(id).Remove();
            Rewrite();
        }

        /// <summary>
        ///  Статический метод, возвращающий  список родителей данного термина.
        /// </summary>
        public static List<int> GetTermParentList(int id){
            List<int> res = new List<int>();
            Term t = Term.GetTermByID(id); 
            while (t != null)
            {
                res.Add(t.ID);
                
                t = Term.GetTermByID(t.Parent);
            }
            res.Reverse();
            return res; 
        }

        /// <summary>
        ///  Статический метод, возвращающий строку с первой заглавной буквой.
        /// </summary>
        public static String NormalizeName(String s)
        {
            return s.Length < 2 ? s.ToUpper() : s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1);
        }

        private static void readThemes()
        {
            StreamReader ThemesReader = new StreamReader("ThemesNames.txt", Encoding.Default);
            String currentString;
            try
            {
                while ((currentString = ThemesReader.ReadLine()) != null)
                {
                    Theme c = new Theme(currentString);
                }

            }
            catch { }
            ThemesReader.Close();
        }
        private static void readVocabs()
        {
            StreamReader VocabReader = new StreamReader("Vocabularys.json");
            String currentString;
            try
            {
                while ((currentString = VocabReader.ReadLine()) != null)
                {
                    Vocabulary v = JsonConvert.DeserializeObject<Vocabulary>(currentString);
                }
            }
            catch { }
            VocabReader.Close();
        }
        private static void readTerms()
        {
            StreamReader TermsReader = new StreamReader("Terms.json");
            String currentString;
            while ((currentString = TermsReader.ReadLine()) != null)
            {
                Term t = JsonConvert.DeserializeObject<Term>(currentString);
            }
            TermsReader.Close();
        }

        /// <summary>
        ///  Статический метод перезаписи словарей.
        /// </summary>
        public static void rewriteVocabularys()
        {
            StreamWriter VocabsWriter = new StreamWriter("Vocabularys.json");
            VocabsWriter.Write("");
            VocabsWriter.Close();
            VocabsWriter = new StreamWriter("Vocabularys.json", true);
            try
            {
                foreach (var i in Vocabulary.AllItems())
                {
                    VocabsWriter.WriteLine(JsonConvert.SerializeObject(i));
                }
            }
            catch { }
            VocabsWriter.Close();
        }

        /// <summary>
        ///  Статический метод перезаписи терминов.
        /// </summary>
        private static void rewriteTerms()
        {
            StreamWriter TermsWriter = new StreamWriter("Terms.json");
            TermsWriter.Write("");
            TermsWriter.Close();
            TermsWriter = new StreamWriter("Terms.json", true);
            foreach (var i in Term.AllItems())
            {
                TermsWriter.WriteLine(JsonConvert.SerializeObject(i));
            }
            TermsWriter.Close();
        }

    }
}
