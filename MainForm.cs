using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormTest.LogicProgram;

namespace WindowsFormTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            button_test_data.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicantForm applicantform = new ApplicantForm();
            applicantform.Show();

        }

        private void Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void Post_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostForm postform = new PostForm();
            postform.Show();
        }

        private void SubDivision_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubDivisionForm subdivForm = new SubDivisionForm();
            subdivForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_test_data_Click(object sender, EventArgs e)
        {
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
            Database.posts.Add(new Post("Начальник"));
            Database.posts.Add(new Post("Бармен"));

            //Тестовые данные - подразделения и заведующие
            Database.subdivisions.Add(new SubDivision("Лаборатория косм. техники", "Максим Кубриков"));
            Database.subdivisions.Add(new SubDivision("Лаборатория МКА", "Вячеслав Ханифович"));
            Database.subdivisions.Add(new SubDivision("Лаборатория программирования", "Антон Юрьевич"));
            Database.subdivisions.Add(new SubDivision("Лаборатория рад. обстановки", "Сергей Владимирович"));

            //Тестовые данные - сотрудники на основе соискателя
            Database.employees.Add(Database.applicants[0].Hiring(Database.subdivisions[2])); //Веревкина в лаб. прог. к Антону Юрьевичу
            Database.employees.Add(Database.applicants[1].Hiring(Database.subdivisions[2])); //Самарина в лаб. прог. к Антону Юрьевичу
            Database.employees.Add(Database.applicants[4].Hiring(Database.subdivisions[0])); //Трубу в лаб. прог. к Кубрикову
            Database.employees.Add(Database.applicants[5].Hiring(Database.subdivisions[1])); //Гвоздь в лаб. МКА к Ханову

            //Тестовые данные - сотрудники полностью с нуля
            //Database.employees.Add(new Employee("Молоток Сергей Сергеевич", new DateTime(1999, 9, 9), "ПТУ"));



            //скрываем кнопку
            button_test_data.Visible = false;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Backend backForm = new Backend();
            backForm.Show();
        }
    }
}
