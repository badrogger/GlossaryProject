using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Glossary.SearchTree;

namespace Glossary.Model
{
    /// <summary>
    ///  Класс, реализующий сущность "Термин"
    /// </summary>
    public class Term : BaseGlossary { 
        private int _id = -1; // поле id
        private int _vocab = -1; // поле словаря, в котором находится термин
        private int _parent = -1; // поле родительского термина
        private static Dictionary<int, Term> _termByID = new Dictionary<int, Term>(); // словарь, возвращающий термин по id  
        private static Dictionary<string, List<int>> _iDsByName = new Dictionary<string, List<int>>(); // словарь, возвращающий список id по имени
        private static Trie TermsTree = new Trie(); 
       
        /// <summary>
        /// Конструктор использующийся для десериализации (по имени и определению).
        /// </summary>
        [JsonConstructor]
        public Term(String name, String def) : base(name)
        {   
            _termByID[-1] = null;
            Definition = def;
            Children = new List<int>();
            Parent = -1;      
        }
        /// <summary>
        /// Конструктор по имени, определению и словарю.
        /// </summary>
        public Term(String name, String def, int v) : this(name, def) {
            try {
                ID = _termByID.Max(t => t.Key) + 1;
            }
            catch (InvalidOperationException)
            {
                ID = 0; 
            }
            Vocab = v;
            
        }
        /// <summary>
        /// Конструктор по имени,определению и словарю и родительскому термину.
        /// </summary>
        public Term(String name, String def, int v, int p) : this(name, def, v)
        {
            Parent = p;   
        }
        /// <summary>
        /// Конструктор по имени,определению и словарю и родительскому термину и списку детей.
        /// </summary>
        public Term(String name, String def, List<int> ch, int v, int p) : this(name, def, v, p)
        {
            Children = ch; 
        }

        public override int ID // перегрузка свойства ID
        {
            get { return _id; }
            set
            {
                _id = value;
                _termByID[_id] = this; // добавление в словарь id
                TermsTree.Add(Name, ID);
                if (!_iDsByName.ContainsKey(Name)) // если имя раньше не встречалось
                    _iDsByName[Name] = new List<int>();
                _iDsByName[Name].Add(ID); // добавить id в список данного имени
            }
        }
        public String Definition { get; set; } // определение термина
        public List<int> Children { get; set; } // список потомков
        public int Parent // Родительский термин
        {
            get { return _parent; }
            set
            {
                if (_parent != value) // если изменяется родитель
                {
                    if (_parent >= 0) // если не корень, удалить из родительского списка детей
                        Term.GetTermByID(_parent).Children.Remove(this.ID);
                    _parent = value;
                    if (_parent >= 0) // если термин на стал корнем, добавить в родительский список детей
                    {
                        Term curP = GetTermByID(_parent);
                        if (curP.Children.FindIndex(x => x == ID) == -1)
                            curP.Add(this.ID);
                    }
                }
            }
        }


        public int Vocab // Соварь, где находится термин
        {
            get { return _vocab; }
            set
            {
                if (_vocab != value) // если словарь изменился
                {
                    if (_vocab >= 0)
                        Vocabulary.GetVocabByID(_vocab).Terms.Remove(this.ID); // удаляем из старого
                    _vocab = value;
                    if (_vocab >= 0)
                    {
                        Vocabulary curV = Vocabulary.GetVocabByID(_vocab); // добавляем в новый
                        if (curV.Terms.FindIndex(x => x == ID) == -1)
                            curV.Add(this.ID);
                    }
                }
            }



        }

        /// <summary>
        /// Метод возвращающий объект-термин по id.
        /// </summary>
        public static Term GetTermByID(int id)
        {
            return _termByID[id];
        }
        /// <summary>
        /// Метод возвращающий список терминов по id.
        /// </summary>
        public static List<Term> GetTermsByName(String name) {
            List<Term> res = new List<Term>();
            List<int> cont = _iDsByName[name];
            foreach (var i in cont) {
                res.Add(GetTermByID(i)); 
            }
            return res; 
        }
        /// <summary>
        /// Свойство, возвращающее список имен всех терминов.
        /// </summary>
        public static List<String> AllItemsNames
        {
            get
            {
                List<String> res = new List<String>();
                foreach (var i in _iDsByName)
                {
                    res.Add(i.Key);
                }
                return res;
            }
        }
        /// <summary>
        /// Свойство, возвращающее список всех терминов.
        /// </summary>
        public static List<Term> AllItems()
        {
            return _termByID.Where(nt => nt.Key >= 0).Select(t => t.Value).OrderBy(i => i.ID).ToList();
        }

        /// <summary>
        /// Метод добавления потомка.
        /// </summary>
        public override void Add(int childsID)
        {
            Children.Add(childsID);
            GetTermByID(childsID).Parent = ID; 
        }
        /// <summary>
        /// Метод добавления диапазона потомков.
        /// </summary>
        public override void AddRange(List<int> lst)
        {
            Children.AddRange(lst);
            foreach (var i in lst) GetTermByID(i).Parent = ID; 
        }
        /// <summary>
        /// Метод удаления термина.
        /// </summary>
        public void Remove()
        {       
            List<int> Tch = new List<int>(Children);
            foreach (var i in Tch) {
                GetTermByID(i).Parent = Parent; 
            }
            Vocab = -1;
            Parent = -1;
            TermsTree.Remove(Name, ID); 
            _termByID.Remove(ID);
            _iDsByName[Name].Remove(ID);
            if (_iDsByName[Name].Count == 0) {
                _iDsByName.Remove(Name); 
            }
        }
        /// <summary>
        /// Метод редактирования термина.
        /// </summary>
        public void Edit(String NewName, String NewDefinition) 
        {
            TermsTree.Remove(Name, ID);
            _iDsByName[Name].Remove(ID);
            Name = NewName;
            _iDsByName[Name].Add(ID); 
            Definition = NewDefinition;
            TermsTree.Add(Name, ID); 
        }

        /// <summary>
        /// Статический метод поиска термина по префиксу с помощью бора.
        /// </summary>
        public static List<int> SearchByTree(String name)
        {
            return new List<int>(TermsTree.Search(name)); 
        }

        /// <summary>
        /// Статический метод поиска строки в определении терминов.
        /// </summary>
        public static List<int> SearchInDefinitions(String pattern)
        {
            var tmp = _termByID.Where(t => t.Key >= 0 && t.Value.Definition.Contains(pattern));
            if (tmp == null || tmp.Count() == 0) return new List<int>(); 
            return tmp.Select(p => p.Key).ToList();
        }
    }
    
}
