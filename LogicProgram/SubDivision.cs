using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    /// <summary>
    /// Класс структурное подразделение
    /// </summary>
    public class SubDivision
    {
        /// <summary>
        /// Название структурного подразделения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Начальник структурного подразделения
        /// </summary>
        public string HeadPerson { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>>
        /// <param name="name">Название структурного подразделения</param>
        /// <param name="headperson">Начальник структурного подразделения</param>
        public SubDivision(string name, string headperson) {
        
            this.Name = name;
            this.HeadPerson = headperson;
        
        }

    }
}
