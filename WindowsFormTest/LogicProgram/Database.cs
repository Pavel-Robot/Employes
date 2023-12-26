using project;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTest.LogicProgram
{
    static class Database
    {
        public static List<Applicant> applicants = new List<Applicant>(); //Соискатели
        public static List<Employee> employees = new List<Employee>();  //Работники
        public static List<Post> posts = new List<Post>(); //Должности
        public static List<SubDivision> subdivisions = new List<SubDivision>(); //Подразделения

        /*
        public static ListBox ListApplicants = new ListBox();
        public static ListBox ListEmployees = new ListBox();
        public static ListBox ListPosts = new ListBox();
        public static ListBox ListSubDivisions = new ListBox();*/
    }
}
