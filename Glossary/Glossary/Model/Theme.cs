using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glossary.Model
{
    /// <summary>
    ///  Класс, реализующий сущность "Тема".
    /// </summary>
    
    public class Theme : BaseGlossary
    {
        private static Dictionary<String, Theme> _themeByName = new Dictionary<string, Theme>(); // тема по имени
        private static Dictionary<int, Theme> _themeByID = new Dictionary<int, Theme>(); // тема по id
        private static int _idcount = 0; 
        
        public Theme(String name) : base(name) // конструктор по имени
        {
            Vocabs = new List<int>();    
            ID = _idcount++;
            _themeByID[ID] = this; 
            _themeByName[Name] = this; 
        }

        public List<int> Vocabs { get; set; } // список словарей в теме

        /// <summary>
        ///  Статический метод, возвращающий тему по имени.
        /// </summary>
        public static Theme GetThemeByName(String name) 
        {
            return _themeByName[name];
        }

        /// <summary>
        ///  Статический метод, возвращающий тему по id.
        /// </summary>
        public static Theme GetThemeByID(int id)
        {
            return _themeByID[id];
        }

        /// <summary>
        /// Перегрузка метода добавления термина.
        /// </summary> 
        public override void Add(int a)
        {
            this.Vocabs.Add(a); 
        }

        /// <summary>
        /// Перегрузка метода добавления диапазона терминов.
        /// </summary> 
        public override void AddRange(List<int> lst)
        {
            Vocabs.AddRange(lst);
        }

        /// <summary>
        ///  Метод, возвращающий список имен словарей на данную тему.
        /// </summary>
        public List<String> GetAllVocabsNames() {
            return Vocabs.Select(v => Vocabulary.GetVocabByID(v).Name).ToList(); 
        }

        /// <summary>
        ///  Метод, возвращающий список терминов с заданным именем в словарях на данную тему.
        /// </summary>
        public List<int> GetTermsByName(String name) {
            List<int> res = new List<int>();
            Vocabs.ForEach(v => res.AddRange(Vocabulary.GetVocabByID(v).GetTermsByName(name)));
            return res;
        }

        /// <summary>
        ///  Метод, возвращающий список терминов с заданым описанием в словарях на данную тему.
        /// </summary>
        public List<int> GetTermsByDefinitions(String pattern) {
            List<int> res = new List<int>();
            foreach (var vid in Vocabs) {
                res.AddRange(
                    Vocabulary.GetVocabByID(vid).Terms.Where(tid => 
                    Term.GetTermByID(tid).Definition.Contains(pattern)).ToList()
                );
            }
            return res;       
            
        }

        /// <summary>
        ///  Метод, возвращающий список id словарей с данной тематикой.
        /// </summary>
        public List<int> GetAllVocabsIDs()
        {
            return new List<int>(Vocabs);
        }

        /// <summary>
        ///  Статический метод, возвращающий список названий всех тем.
        /// </summary>
        public static List<String> AllItemsNames {
            get {
                List<String> res = _themeByName.Select(x => x.Key).ToList();
                return res; 
            }
        }
    }
}
