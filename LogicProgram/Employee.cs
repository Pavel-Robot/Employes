using Microsoft.VisualBasic;
using System;
using System.Xml.Linq;


namespace project {

    ///<summary>Класс сотрудик наследует от родителя соискатель</summary>
    public class Employee : Applicant
    {

        /// <summary>
        /// Статус сотрудника (через enum)
        /// </summary>
        public InpStatus Status { get; set; }

        /// <summary>
        /// Дата найма
        /// </summary>
        public DateTime? DateOfEmployment { get; set; }

        /// <summary>
        /// Дата увольнения
        /// </summary>
        public DateTime? DateOfDismissal { get; set; }

        /// <summary>
        /// Название должности через класс Post
        /// </summary>
        public Post post { get; set; }

        /// <summary>
        /// Название подразделения и начальника (все в объекте класса SubDivision с названием subdiv)
        /// </summary>
        public SubDivision subdiv { get; set; }


        /// <summary>
        /// Конструктор класса сотрудник
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="education"></param>
        public Employee(string fullname, DateTime dateofbirth, string education) : base(fullname, dateofbirth, education) { }


        /// <summary>
        /// Метод увольнение сотрудника
        /// </summary>        
        public void DissEmp()
        {
            DateOfDismissal = DateTime.Now;
            Status = InpStatus.Dissmised;

        }


        /// <summary>
        /// Перечисление для статуса сотрудника
        /// </summary>
        public enum InpStatus { 
            Work,
            Dissmised
        }


    }






}