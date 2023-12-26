using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project.Employee;

namespace project
{	


	///<summary>Класс соискатель</summary>
	public class Applicant
    {

        /// <summary>
        /// ФИО соискателя
        /// </summary>
        public string FullName {get; set; }

        /// <summary>
        /// Дата рождения соискателя
		/// </summary>
		public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Образование
        /// <summary>
        public string Education { get; set; }

        /// <summary>
        /// Конструктор класса Applicant
        /// <param name="fullname">Полное имя</param>
        /// <param name="dateofbirth">Дата рождения</param>
        /// <param name="education">Образование</param>
        /// <summary>
        public Applicant(string fullname, DateTime dateofbirth, string education) {

			this.FullName = fullname;
			this.DateOfBirth = dateofbirth;
			this.Education = education;
		}

        
        ///<summary> Метод для произведения найма выбранного соискателя - [мод. доступа][возвр. знач][имя метода][аргументы] </summary>
        ///<param name="Object">Объект класса подразделение внутри которого два параметра: название подразделения и начальника подразделения</param>
        ///<return>Экземпляр класса Employee</return>
        public Employee Hiring(SubDivision Object) {

            //Создаем объект класса Employee с названием emp и используем поля данного класса Applicant
            Employee emp = new Employee(this.FullName, this.DateOfBirth, this.Education);

            //Задаем название для подразделения и начальника сотруднику просто отправляя объект класса SubDivision 
            emp.subdiv = Object;

            //Задаем статус для сотрудника через enum
            emp.Status = InpStatus.Work;

            //Задаем время найма
            emp.DateOfEmployment = DateTime.Now;

            return emp;
        }
        
    }


}