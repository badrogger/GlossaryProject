using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Glossary.Model
{
    class Term : BaseGlossary {
        String description;  
        public String Description {
            get { return description;  }
            set { description = value;  }
        }
        public Term(String name) : base(name) { }
        public Term(String name, String description) : base(name) {
            this.Description = description; 
        }
        [JsonConstructor]
        public Term(String name, BaseGlossary prev, String description) : base(name, prev)
        {
            this.Description = description;
        }
        
    }
}
