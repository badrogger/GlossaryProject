using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Glossary.Model
{
    /// <summary>
    /// Абстрактный класс, реализующий основные элементы модели.
    /// </summary>
    public abstract class BaseGlossary
    {   
        public String Name { get; set; } // имя
        public virtual int ID { get; set; } // идентификационный номер 
        /// <summary>
        /// Конструктор элемента модели по имени.
        /// </summary>
        /// <param name="name"></param>
        public BaseGlossary(String name) 
        {
            this.Name = name.ToLower();
        }
        /// <summary>
        /// Метод связывания терминов с элементом.
        /// </summary>
        
        public abstract void Add(int id);
        /// <summary>
        /// Метод связывания диапазона терминов с элементом.
        /// </summary>
        
        public abstract void AddRange(List<int> idLst);       
    }
}
