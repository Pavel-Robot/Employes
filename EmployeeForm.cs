using Microsoft.Office.Interop.Excel;
using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormTest.LogicProgram;
using Application = System.Windows.Forms.Application;
using Excel = Microsoft.Office.Interop.Excel;
using Point = System.Drawing.Point;

namespace WindowsFormTest
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            //foreach (var i in Database.applicants) comboBox0.Items.Add(i.FullName);
            //foreach (var i in Database.posts) comboBox1.Items.Add(i.Name);
            //foreach (var i in Database.subdivisions) comboBox2.Items.Add(i.Name);

            //foreach (var i in Database.employees) comboBox3.Items.Add(i.FullName);


            foreach (var i in Database.applicants) comboBox0.Items.Add($"{i.FullName} | {i.DateOfBirth.ToShortDateString()} | {i.Education}");
            foreach (var i in Database.posts) comboBox1.Items.Add($"{i.Name}");
            foreach (var i in Database.subdivisions) comboBox2.Items.Add($"{i.Name} | {i.HeadPerson}");
            foreach (var i in Database.employees) comboBox3.Items.Add($"{i.FullName} | {i.post.Name} | {i.Status} | {i.DateOfEmployment.GetValueOrDefault().ToShortDateString()} | {i.DateOfDismissal.GetValueOrDefault().ToShortDateString()}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Education_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind0 = comboBox0.SelectedIndex;
            int ind1 = comboBox1.SelectedIndex;
            int ind2 = comboBox2.SelectedIndex;

            int indEmpEnd = Database.employees.Count();

            Database.employees.Add(Database.applicants[ind0].Hiring(Database.subdivisions[ind2]));
            Database.employees[indEmpEnd].post = Database.posts[ind1];
            Database.employees[indEmpEnd].Status = Employee.InpStatus.Work;
            Database.employees[indEmpEnd].DateOfEmployment = DateTime.Now;


            Database.applicants.RemoveAt(ind0);

            comboBox0.Items.Clear();
            comboBox0.Text = "Выберите соискателя для найма из списка";

            comboBox1.Items.Clear();
            comboBox1.Text = "Выберите должность для найма из списка";

            comboBox2.Items.Clear();
            comboBox2.Text = "Выберите подразделение для найма из списка";

            comboBox3.Items.Clear();


            foreach (var i in Database.applicants) comboBox0.Items.Add($"{i.FullName} | {i.DateOfBirth.ToShortDateString()} | {i.Education}");
            foreach (var i in Database.posts) comboBox1.Items.Add($"{i.Name}");
            foreach (var i in Database.subdivisions) comboBox2.Items.Add($"{i.Name} | {i.HeadPerson}");
            foreach (var i in Database.employees) comboBox3.Items.Add($"{i.FullName} | {i.post.Name} | {i.Status} | {i.DateOfEmployment.GetValueOrDefault().ToShortDateString()} | {i.DateOfDismissal.GetValueOrDefault().ToShortDateString()}");



            MessageBox.Show(
                "Успешно добавлен сотрудник: " + Database.employees[indEmpEnd].FullName,
                "Сообщение");

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string appl = comboBox0.SelectedItem.ToString();
            int ind0 = comboBox0.SelectedIndex;
            int ind1 = comboBox1.SelectedIndex;
            int ind2 = comboBox2.SelectedIndex;

            int indEmpEnd = comboBox3.SelectedIndex;

            //string pst = comboBox1.SelectedItem.ToString();
            //string sdiv = comboBox2.SelectedItem.ToString();

            Database.employees[indEmpEnd].subdiv = Database.subdivisions[ind1];
            Database.employees[indEmpEnd].post = Database.posts[ind1];
            //Database.employees[indEmpEnd].Status = Employee.InpStatus.Work;
            //Database.employees[indEmpEnd].DateOfEmployment = DateTime.Now;


            //Database.employees[ind0].post = Database.posts[ind1];

            comboBox0.Items.Clear();
            comboBox0.Text = "Выберите соискателя для найма из списка";

            comboBox1.Items.Clear();
            comboBox1.Text = "Выберите должность для найма из списка";

            comboBox2.Items.Clear();
            comboBox2.Text = "Выберите подразделение для найма из списка";

            comboBox3.Items.Clear();
            comboBox3.Text = "Выберите сотрудника из списка";

            foreach (var i in Database.applicants) comboBox0.Items.Add($"{i.FullName} | {i.DateOfBirth.ToShortDateString()} | {i.Education}");
            foreach (var i in Database.posts) comboBox1.Items.Add($"{i.Name}");
            foreach (var i in Database.subdivisions) comboBox2.Items.Add($"{i.Name} | {i.HeadPerson}");
            foreach (var i in Database.employees) comboBox3.Items.Add($"{i.FullName} | {i.post.Name} | {i.Status} | {i.DateOfEmployment.GetValueOrDefault().ToShortDateString()} | {i.DateOfDismissal.GetValueOrDefault().ToShortDateString()}");


            MessageBox.Show(
                "Успешно сохранены изменения сотрудника: " + Database.employees[indEmpEnd].FullName,
                "Сообщение");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int ind0 = comboBox0.SelectedIndex;
            //int ind1 = comboBox1.SelectedIndex;
            //int ind2 = comboBox2.SelectedIndex;
            int indEmpEnd = comboBox3.SelectedIndex;

            Database.employees[indEmpEnd].post = new Post("");
            
            Database.employees[indEmpEnd].subdiv = new SubDivision("", ""); //чиститься структурное подразделение

            //из объекта стр. подрз. удаляется данный сотрудник
            for (int i = 0; i < Database.subdivisions.Count(); i++) {
                if (Database.subdivisions[i].HeadPerson == Database.employees[indEmpEnd].FullName) {

                    Database.subdivisions[i].HeadPerson = "";
                }
            
            }
            
            Database.employees[indEmpEnd].Status = Employee.InpStatus.Dissmised;
            Database.employees[indEmpEnd].DateOfDismissal = DateTime.Now;


            comboBox0.Items.Clear();
            comboBox0.Text = "Выберите соискателя для найма из списка";

            comboBox1.Items.Clear();
            comboBox1.Text = "Выберите должность для найма из списка";

            comboBox2.Items.Clear();
            comboBox2.Text = "Выберите подразделение для найма из списка";

            comboBox3.Items.Clear();
            comboBox3.Text = "Выберите сотрудника из списка";

            foreach (var i in Database.applicants) comboBox0.Items.Add($"{i.FullName} | {i.DateOfBirth.ToShortDateString()} | {i.Education}");
            foreach (var i in Database.posts) comboBox1.Items.Add($"{i.Name}");
            foreach (var i in Database.subdivisions) comboBox2.Items.Add($"{i.Name} | {i.HeadPerson}");
            foreach (var i in Database.employees) comboBox3.Items.Add($"{i.FullName} | {i.post.Name} | {i.Status} | {i.DateOfEmployment.GetValueOrDefault().ToShortDateString()} | {i.DateOfDismissal.GetValueOrDefault().ToShortDateString()}");


            MessageBox.Show(
                "Успешно уволен сотрудник: " + Database.employees[indEmpEnd].FullName,
                "Сообщение");
        }

        private void comboBox0_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                using (WindowsFormTest.LogicProgram.ExcelHelper helper = new WindowsFormTest.LogicProgram.ExcelHelper())
                {
                    //if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "Выгрузка о работниках.xlsx")))
                    if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "Выгрузка о работниках.xlsx")))
                    {
                        //helper.Set(column: "A", row: 1, data: "lksadklsajdkl");
                        //var val = helper.Get(column: "A", row: 6);
                        //helper.Set(column: "B", row: 1, data: DateTime.Now);


                        helper.Set("A", 1, "Всего структурных подразделений");
                        helper.Set("C", 1, Database.subdivisions.Count());

                        //for(int i = 0; i < Database.subdivisions.Count(); i++)
                       // {
                            //первая строка шаблона
                            helper.Set("A", 3, Database.subdivisions[0].Name);
                            helper.Set("B", 3, "Сотрудников в подразделении");
                            int counter = Database.employees.Where(x => x.subdiv.Name == Database.subdivisions[0].Name).Count();
                            helper.Set("C", 3, counter);

                            //вторая строка шаблона
                            helper.Set("A", 4, "Начальник подразделения");
                            helper.Set("B", 4, Database.subdivisions[0].HeadPerson);




                        //}


                        helper.Save();
            




                        MessageBox.Show(
                "Успешно выгружен файл .xsls: ",
                "Сообщение");
                    }
                }

                Console.Read();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }*/
            string name_str;
            int INDEX = 0;
            

            Excel.Application newExcel = new Excel.Application();

            //newExcel.StandardFontSize = 12;
            Excel.Workbook wb = (Excel.Workbook)newExcel.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)newExcel.ActiveSheet;
            //newExcel.Visible = true;

            //ws.Name = "Лист выгрузки данных";

            ws.StandardWidth = 30;
            //ws.Columns[1].ColumnWidth = 30;
            //ws.Columns[2].ColumnWidth = 32;
            //ws.Columns[3].ColumnWidth = 10;


            INDEX++;
            ws.Cells[INDEX, "A"] = "Всего структурных подразделений";
            ws.Cells[INDEX, "C"] = Database.subdivisions.Count();
            INDEX++;



            //for (int i = 0; i < Database.subdivisions.Count(); i++)
            foreach (var sub in Database.subdivisions)
            {
                //первая строка шаблона
                INDEX++;

                name_str = sub.Name;
                ws.Cells[INDEX, "A"] = name_str; 
                ws.Cells[INDEX, "B"] = "Сотрудников в подразделении"; 
                ws.Cells[INDEX, "C"] = Database.employees.Where(x => x.subdiv.Name == name_str).Count();

                //вторая строка шаблона
                INDEX++;

                ws.Cells[INDEX, "A"] = "Начальник подразделения"; 
                ws.Cells[INDEX, "B"] = sub.HeadPerson;

                //Третьи и последующие строки - фио сотрудников
                foreach (var emp in Database.employees)
                {
                    if (emp.subdiv.Name == name_str)
                    {
                        INDEX++;

                        ws.Cells[INDEX, "A"] = emp.FullName;
                        
                    }
                }
                INDEX++; //отступили строчку перед новым подразделением
            }


            //string fre = Path.Combine(Environment.CurrentDirectory, "Data.xlsx");
            ws.SaveAs(Path.Combine(Environment.CurrentDirectory, "Data.xlsx"));

            wb.Close();
            newExcel.Quit();

            MessageBox.Show(
                "Успешно выгружен файл : " + Environment.CurrentDirectory + "\\Data.xlsx",
                "Сообщение");
        }

        Point lastpoint;
        private void EmployeeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X; //смещение по X
                this.Top += e.Y - lastpoint.Y; //смещение по Y
            }
        }

        private void EmployeeForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y); //место где нажали на мышку (начало координат)
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X; //смещение по X
                this.Top += e.Y - lastpoint.Y; //смещение по Y
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y); //место где нажали на мышку (начало координат)
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
