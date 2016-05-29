using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glossary.Model;

namespace Glossary.SearchTree
{
    /// <summary>
    ///  Класс, реализующий бор.
    /// </summary>
    class Trie
    {
        public class Node
        {
            
            public Node(char key = '#')
            {
                Key = key;
                Children = new Node[34];
                Items = new List<int>();
            }

            public char Key { get; set; }
            public List<int> Items { get; set; }
            public Node[] Children { get; set; }
        }
        private static int RussianCharToInt(char c)
        {
            return (int)c - (int)'а';
        }
        private Node root { get; set; }
        public Trie()
        {
            root = new Node();
        }

        /// <summary>
        ///  Добавление элемента c заданным именем и id.
        /// </summary>
        public void Add(String name, int id)
        {
            Node cur = root, prev = null;
            int i = 0;
            while (i < name.Length && cur != null)
            {
                int c = RussianCharToInt(name[i]);
                prev = cur;
                cur = cur.Children[c];
                if (cur != null) i++;
            }
            if (i == name.Length)
            {
                cur.Items.Add(id);
                return;
            }
            cur = prev;
            while (i < name.Length)
            {
                int c = RussianCharToInt(name[i]);
                cur.Children[c] = new Node(name[i++]);
                prev = cur;
                cur = cur.Children[c];

            }
            cur.Items.Add(id);
        }
        /// <summary>
        ///  Удаление элемента с заданным id.
        /// </summary>
        public void Remove(String name, int id)
        {
            Node cur = root, prev = null;
            int i = 0;
            while (i < name.Length && cur != null)
            {
                int c = RussianCharToInt(name[i]);
                prev = cur;
                cur = cur.Children[c];
                if (cur != null) i++;
            }
            if (i == name.Length)
            {

                cur.Items.Remove(id);
                if (cur.Items.Count > 0) return;
                bool isLeaf = true;
                foreach (var j in cur.Children)
                {
                    if (j != null) isLeaf = false;
                }
                if (isLeaf) prev.Children[RussianCharToInt(name[i - 1])] = null;
                return;
            }
        }

        
        /// <summary>
        ///  Мтод поиска префикса.
        /// </summary>
        public List<int> Search(String name)
        {
            List<int> res = new List<int>();
            Node cur = root, prev = null;
            int i = 0;
            while (i < name.Length && cur != null)
            {
                int c = RussianCharToInt(name[i]);
                prev = cur;
                cur = cur.Children[c];
                if (cur != null) i++;
            }
            if (cur == null && i == 0)
            {
                return res;
            }
            if (i == name.Length)
            {
                res.AddRange(cur.Items);
            }
            if (cur == null) { return res;  }
            TravelAndAdd(cur, res);
            return res;
        }

        /// <summary>
        ///  Метод обхода и добавления узлов.
        /// </summary>
        private void TravelAndAdd(Node cur, List<int> res)
        {
            foreach (var i in cur.Children)
            {
                if (i != null)
                {
                    if (i.Items.Count > 0) res.AddRange(i.Items);
                    TravelAndAdd(i, res);
                }
            }
        }
    }
}
