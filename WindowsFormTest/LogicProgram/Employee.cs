using Microsoft.VisualBasic;
using System;
using System.Xml.Linq;


namespace project {

    ///<summary>����� �������� ��������� �� �������� ����������</summary>
    public class Employee : Applicant
    {

        /// <summary>
        /// ������ ���������� (����� enum)
        /// </summary>
        public InpStatus Status { get; set; }

        /// <summary>
        /// ���� �����
        /// </summary>
        public DateTime? DateOfEmployment { get; set; }

        /// <summary>
        /// ���� ����������
        /// </summary>
        public DateTime? DateOfDismissal { get; set; }

        /// <summary>
        /// �������� ��������� ����� ����� Post
        /// </summary>
        public Post post { get; set; }

        /// <summary>
        /// �������� ������������� � ���������� (��� � ������� ������ SubDivision � ��������� subdiv)
        /// </summary>
        public SubDivision subdiv { get; set; }


        /// <summary>
        /// ����������� ������ ���������
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="education"></param>
        public Employee(string fullname, DateTime dateofbirth, string education) : base(fullname, dateofbirth, education) { }


        /// <summary>
        /// ����� ���������� ����������
        /// </summary>        
        public void DissEmp()
        {
            DateOfDismissal = DateTime.Now;
            Status = InpStatus.Dissmised;

        }


        /// <summary>
        /// ������������ ��� ������� ����������
        /// </summary>
        public enum InpStatus { 
            Work,
            Dissmised
        }


    }






}