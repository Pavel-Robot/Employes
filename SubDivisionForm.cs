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
    public partial class SubDivisionForm : Form
    {
        public SubDivisionForm()
        {
            InitializeComponent();

            SubDivName.Text = "Введите структурное подразделение";
            SubDivName.ForeColor = Color.Gray;

            //foreach (var i in Database.employees) toolStripComboBox1.Items.Add($"{i.FullName} | {i.subdiv.Name}");

            foreach (var i in Database.subdivisions) listBox1.Items.Add($"{i.Name} | {i.HeadPerson}");
        }

        private void SubDivisionForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubDivision subdiv = new SubDivision(SubDivName.Text, "не задан начальник");
            Database.subdivisions.Add(subdiv);

            MessageBox.Show(
                "Успешно добавлено: " + subdiv.Name,
                "Сообщение");

            listBox1.Items.Clear();
            foreach (var i in Database.subdivisions) listBox1.Items.Add($"{i.Name} | {i.HeadPerson}");

            /*
            //находим индекс, где встречается в БД наше ФИО
            int index = Database.subdivisions.IndexOf(Database.subdivisions.Where(n => n.Name == SubDivName.Text).FirstOrDefault());

            SubDivision subdiv = new SubDivision(SubDivName.Text, headname.Text);

            //Заменяем на новую
            Database.subdivisions[index] = subdiv;


            Database.subdivisions.RemoveAll(x => x.Name == SubDivName.Text); */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            //string name_it = toolStripComboBox1.SelectedItem.ToString();
            



        }

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе выбор, получаем индекс с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            //И заполняем поля нашей формы
            SubDivName.Text = Database.subdivisions[index_it].Name;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе удалить, получаем текст с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            //Удаляем все вхождения с выбранной должностью в базе данных
            Database.subdivisions.RemoveAll(x => x.Name == Database.subdivisions[index_it].Name);

            //обновляем коллекцию
            listBox1.Items.Clear();
            //foreach (var i in Database.applicants) listBox1.Items.Add(i.FullName);
            foreach (var i in Database.subdivisions) listBox1.Items.Add($"{i.Name} | {i.HeadPerson}");
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе редактировать, получаем индекс с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            //И заполняем поля класса должность с нашей формы
            Database.subdivisions[index_it].Name = SubDivName.Text;

            //обновляем коллекцию
            listBox1.Items.Clear();
            foreach (var i in Database.subdivisions) listBox1.Items.Add($"{i.Name} | {i.HeadPerson}");
        }

        private void показатьСотрудниковВыбраннойДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе показать, получаем индекс с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            string post_name = Database.subdivisions[index_it].Name;

            //Database.employees.Where(x => x.post.Name == post_name);

            listBox2.Items.Clear();
            for (int i = 0; i < Database.employees.Count(); i++)
            {
                if (Database.employees[i].subdiv.Name == post_name) listBox2.Items.Add($"{Database.employees[i].FullName} | {Database.employees[i].subdiv.Name}");

            }
        }

        private void ContexMouseEnterHead(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            toolStripComboBox1.Text = "";

            string[] inputarr = listBox1.SelectedItem.ToString().Split('|');
            string sub_name = inputarr[0].Trim();


            for (int i = 0; i < Database.employees.Count(); i++) {

                if (Database.employees[i].subdiv.Name == sub_name)
                {
                    toolStripComboBox1.Items.Add($"{Database.employees[i].FullName} | {Database.employees[i].subdiv.Name}");
                }
                
            }
        }

        private void MouseUpClickSub(object sender, MouseEventArgs e)
        {
            
        }

        private void SelectesIndChangeSubDiv(object sender, EventArgs e)
        {
            string[] inputarr = toolStripComboBox1.SelectedItem.ToString().Split('|');
            string sub_div = inputarr[1].Trim();

            foreach (var i in Database.subdivisions) {

                if (i.Name == sub_div)
                    i.HeadPerson = inputarr[0].Trim();

            }

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var i in Database.subdivisions) listBox1.Items.Add($"{i.Name} | {i.HeadPerson}");

            //MessageBox.Show(
            //   "Успешно добавлен элемент: ",
            //   "Сообщение");
        }

        private void SubDivName_Enter(object sender, EventArgs e)
        {
            if (SubDivName.Text == "Введите структурное подразделение")
                SubDivName.Text = "";
            SubDivName.ForeColor = Color.Black;
        }

        private void SubDivName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubDivName_Leave(object sender, EventArgs e)
        {
            if (SubDivName.Text == "")
            {
                SubDivName.Text = "Введите структурное подразделение";
                SubDivName.ForeColor = Color.Gray; 
                
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        Point lastpoint;
        private void SubDivisionForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X; //смещение по X
                this.Top += e.Y - lastpoint.Y; //смещение по Y
            }
        }

        private void SubDivisionForm_MouseDown(object sender, MouseEventArgs e)
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
    }
}
