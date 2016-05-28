using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Glossary.Model
{
    /// <summary>
    ///  Класс, реализующий сущность "Словарь".
    /// </summary>
    public class Vocabulary : BaseGlossary
    {
        private int _id = -1; // поле id
        private int _mtheme = -1; // поле темы словаря
        
        private static Dictionary<int, List<int>> _iDsByTheme = new Dictionary<int, List<int>>(); // список id по темам
        private static Dictionary<String, int> _iDbyName = new Dictionary<string, int>();  // id  по имени
        private static Dictionary<int, Vocabulary> _vocabByID = new Dictionary<int, Vocabulary>(); // объекты по id
        
        /// <summary>
        /// Конструктор использующийся для десериализации (по имени и описанию).
        /// </summary>
        [JsonConstructor]
        public Vocabulary(String name, String des) : base(name)
        {
            
            Description = des;
            Terms = new List<int>();

        }
        /// <summary>
        /// Конструктор по имени, описанию и теме.
        /// </summary>
        public Vocabulary(String name, String des, int theme) : this(name, des)
        {
            try
            {
                ID = _vocabByID.Max(v => v.Key) + 1;
            }
            catch (InvalidOperationException) {
                ID = 0; 
            }
            MTheme = theme;
            
        }
        /// <summary>
        /// Конструктор по имени, описанию, теме и списку терминов.
        /// </summary>
        public Vocabulary(String name, String des, int theme, List<int> t) : this(name, des, theme)
        {
            Terms = t;
        }


        public String Description { get; set; } // описание словаря
        public List<int> Terms { get; set; } // список терминов в словаре
        public override int ID // перегрузка свойства id
        {
            get { return _id; }
            set
            {
                _id = value;
                _vocabByID[_id] = this;
                _iDbyName[this.Name] = _id;
            }
        }
        public int MTheme // свойство тема
        {
            get
            {
                return _mtheme;
            }
            set
            {
                if (_mtheme != value) // если тема изменяем
                {
                    if (_mtheme >= 0)
                    {
                        Theme.GetThemeByID(_mtheme).Vocabs.Remove(ID); // удаляем из списка старой темы 
                        _iDsByTheme[_mtheme].Remove(ID); // удаляем из спика словарей по темам
                        if (_iDsByTheme[_mtheme].Count == 0)  // если словарей с таким именем не осталось
                        {
                            _iDsByTheme.Remove(_mtheme); // удаляем имя из словаря
                        }
                    }
                    _mtheme = value;
                    if (_mtheme >= 0)
                    {
                        // добавляем словарь в соответствующие коллекции
                        Theme.GetThemeByID(_mtheme).Add(ID);
                        if (!_iDsByTheme.ContainsKey(_mtheme))
                            _iDsByTheme[_mtheme] = new List<int>();
                        _iDsByTheme[_mtheme].Add(ID);
                    }
                }
            }
        }

        /// <summary>
        /// Статический метод возвращающий объект-словарь по id.
        /// </summary>
        public static Vocabulary GetVocabByID(int id) {
            return _vocabByID[id]; 
        }

        /// <summary>
        /// Статический метод возвращающий id по имени.
        /// </summary>
        public static int GetIDByName(String name)
        {
            return _iDbyName[name];
        }

        /// <summary>
        /// Статический метод возвращающий объект-термин по имени.
        /// </summary>
        public static Vocabulary GetVocabByName(String name)
        {
            return GetVocabByID(_iDbyName[name]);
        }
        /// <summary>
        /// Статическое свойство, возвращающее список имен всех словарей.
        /// </summary>
        public static List<String> AllItemsNames {
            get
            {
                List<String> res = new List<String>();
                
                foreach (var i in _vocabByID) {
                    res.Add(i.Value.Name);
                }
                return res;
            }
        }

        /// <summary>
        /// Статическое свойство, возвращающее список всех словарей.
        /// </summary>
        public static List<Vocabulary> AllItems() {
            return _vocabByID.Select(v => v.Value).OrderBy(w => w.ID).ToList();
        }

        /// <summary>
        /// Метод, возвращающий список терминов с заданным именем.
        /// </summary>
        public List<int> GetTermsByName(String name) {
            List<int> res = Terms.Where(tid => Term.GetTermByID(tid).Name == name).ToList();
            return res; 
        }

        /// <summary>
        /// Метод, удаляющий словарь.
        /// </summary>
        public void Remove() {
            List<int> vt = new List<int>(Terms);
            foreach (var i in vt) {
                Term.GetTermByID(i).Remove();
            }
            MTheme = -1;
            _vocabByID.Remove(ID);
            _iDbyName.Remove(Name);
             
        }
        /// <summary>
        /// Метод, возвращающий имена всех терминов в словаре.
        /// </summary>
        public List<String> AllTermsNames() {
            return Terms.Select(t => Term.GetTermByID(t).Name).ToList(); 
            /*List<String> res = new List<String>();
            foreach (var i in Terms)
            {
                res.Add(Term.GetTermByID(i).Name);
            }
            return res;  */
        }

        /// <summary>
        ///Статический метод, возвращающий все именна тем, в которых есть хотя бы 1 словарь.
        /// </summary>     
        public static List<String> AllThemesNames()
        {
            return _iDsByTheme.Select(t => Theme.GetThemeByID(t.Key).Name).ToList();
          
        }

        /// <summary>
        /// Метод, возвращающий количество символов в определениях всех терминов словаря.
        /// </summary> 
        public long GetNumberOfChars() {
            return Terms.Aggregate(0, (acc, tid) => acc += Term.GetTermByID(tid).Definition.Length);
        }


        public int TermsNumber // количество терминов в словаре
        {
            get { return Terms.Count; }
        }

        /// <summary>
        /// Перегрузка метода добавления термина.
        /// </summary> 
        public override void Add(int a) {
            Terms.Add(a); 
        }

        /// <summary>
        /// Перегрузка метода добавления диапазона терминов.
        /// </summary> 
        public override void AddRange(List<int> lst)
        {
            Terms.AddRange(lst);
        }

    }
}
