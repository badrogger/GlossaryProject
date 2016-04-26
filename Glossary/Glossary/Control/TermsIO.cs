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
   


    class TermsIO
    {
       
        public static Dictionary<String, Term> dict;
        public static String db = "data_base.json";
        public static void Load() {
            String s;
            StreamReader t = new StreamReader(db);
            while ((s = t.ReadLine()) != null) {
                Term cur = JsonConvert.DeserializeObject<Term>(s);
                dict[cur.Name] = cur; 
            }
            t.Close();
            
        }
        public static void Add(String name, String category, String description) {

            Term nterm;
            if (dict.ContainsKey(category))
                nterm = new Term(name, dict[category], description);
            else
                nterm = new Term(name, description);
            dict[name] = nterm;
            
            String json = JsonConvert.SerializeObject(nterm);
            StreamWriter t = new StreamWriter(db, true);
            t.WriteLine(json);
            
            t.Close();
        }
        public static List<String> GetParentTree(Term a){
            List<String> res = new List<String>();
            BaseGlossary cur = a;
            while (cur != null) {
                res.Add(cur.Name);
                cur = cur.Parent;
            }
            res.Reverse();
            return res; 
        }
    }
}
