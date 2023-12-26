using project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormTest.LogicProgram;

namespace WindowsFormTest
{
    //internal static class Program
    internal static class Program
    {


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //static List<Applicant> applicants = new List<Applicant>();
            //List<Applicant> applicants = new List<Applicant>();

            DoForDataBase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new Strip());
        }


        /// <summary>
        /// Заносим в память данные о соискателях и сотрудниках
        /// </summary>
        public static void DoForDataBase() {

            //Тестовые данные - соискатели
            Database.applicants.Add(new Applicant("Веревкин Павел Николаевич", new DateTime(1997, 2, 6), "СибГУ им. М. Ф. Решетнева"));
            Database.applicants.Add(new Applicant("Самарин Илья Валерьевич", new DateTime(1994, 3, 20), "СибГУ им. М. Ф. Решетнева"));
            Database.applicants.Add(new Applicant("Кузнецов Иван Иванович", new DateTime(1995, 2, 10), "Сибирский фед. унив."));
            Database.applicants.Add(new Applicant("Романов Николай Павлович", new DateTime(1980, 1, 1), "КГТУ"));
            Database.applicants.Add(new Applicant("Труба Николай Николаевич", new DateTime(1985, 2, 2), "MIT"));
            Database.applicants.Add(new Applicant("Гвоздь Павел Павлович", new DateTime(1990, 3, 3), "ФизТех"));
            Database.applicants.Add(new Applicant("Доска Елена Васильевна", new DateTime(1995, 4, 4), "МГУ"));

            //Тестовые данные - должности
            Database.posts.Add(new Post("Разнорабочий"));
            Database.posts.Add(new Post("Бригадир"));
            Database.posts.Add(new Post("Охранник"));
            Database.posts.Add(new Post("Бармен"));
            Database.posts.Add(new Post("Программист C#"));

            //Тестовые данные - подразделения и заведующие
            Database.subdivisions.Add(new SubDivision("Лаборатория косм. техники", "Максим Кубриков"));
            Database.subdivisions.Add(new SubDivision("Лаборатория МКА", "Вячеслав Ханифович"));
            Database.subdivisions.Add(new SubDivision("Лаборатория программирования", "Антон Юрьевич"));
            Database.subdivisions.Add(new SubDivision("Лаборатория рад. обстановки", "Сергей Владимирович"));

            //Тестовые данные - сотрудники на основе соискателя
            //и удалим соискателей, что стали сотрудниками из БД
            Database.employees.Add(Database.applicants[0].Hiring(Database.subdivisions[2])); //Веревкина в лаб. прог. к Антону Юрьевичу
            Database.applicants.RemoveAt(0);
            Database.employees.Add(Database.applicants[0].Hiring(Database.subdivisions[2])); //Самарина в лаб. прог. к Антону Юрьевичу
            Database.applicants.RemoveAt(0);
            Database.employees.Add(Database.applicants[2].Hiring(Database.subdivisions[0])); //Трубу в лаб. прог. к Кубрикову
            Database.applicants.RemoveAt(2);
            Database.employees.Add(Database.applicants[2].Hiring(Database.subdivisions[1])); //Гвоздь в лаб. МКА к Ханову
            Database.applicants.RemoveAt(2);




            //Database.applicants.RemoveAt(4);
            //Database.applicants.RemoveAt(5);
            //Тестовые данные - сотрудники полностью с нуля
            //Database.employees.Add(new Employee("Молоток Сергей Сергеевич", new DateTime(1999, 9, 9), "ПТУ"));

            //Тестовые данные - Задаем должности - Время найма - статус
            Database.employees[0].post = Database.posts[4];//Веревкин будет прогером
            Database.employees[0].DateOfEmployment = DateTime.Now;
            Database.employees[0].Status = Employee.InpStatus.Work;

            Database.employees[1].post = Database.posts[4]; //Самарин будет прогером
            Database.employees[1].DateOfEmployment = DateTime.Now;
            Database.employees[1].Status = Employee.InpStatus.Work;

            Database.employees[2].post = Database.posts[3]; //Труба будет барменом
            Database.employees[2].DateOfEmployment = DateTime.Now;
            Database.employees[2].Status = Employee.InpStatus.Work;

            Database.employees[3].post = Database.posts[3]; //Гвоздь будет барменом
            Database.employees[3].DateOfEmployment = DateTime.Now;
            Database.employees[3].Status = Employee.InpStatus.Dissmised;


        }

    }
}
