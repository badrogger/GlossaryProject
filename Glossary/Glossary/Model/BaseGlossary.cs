using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Glossary.Model
{
    class BaseGlossary
    {
        String name;
        BaseGlossary parent;
        public String Name {
            get { return name; }
            set { name = value;  }
        }
        public BaseGlossary Parent {
            get { return parent;  }
            set { parent = value; }
        }
        
        public BaseGlossary(String name) {
            this.Name = name;
            
            this.Parent = null;
        }
        [JsonConstructor]
        public BaseGlossary(String name, BaseGlossary parent)
        {
            this.Name = name;
           
            this.Parent = parent;
        }
        
    }
}
