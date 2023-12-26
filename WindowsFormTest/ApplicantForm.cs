using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormTest.LogicProgram;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormTest
{
    
    public partial class ApplicantForm : Form
    {
        public ApplicantForm()
        {
            
            InitializeComponent();

            FullName.Text = "Введите ФИО";
            FullName.ForeColor = Color.Gray;

            DateOfBirth.Text = "Введите дату рождения";
            DateOfBirth.ForeColor = Color.Gray;

            Education.Text = "Введите образование";
            Education.ForeColor = Color.Gray;

            listBox1.Items.Clear();
            //foreach (var i in Database.applicants) listBox1.Items.Add(i.FullName);
            foreach (var i in Database.applicants) listBox1.Items.Add($"{i.FullName}  | {i.DateOfBirth.ToShortDateString()} | {i.Education}");
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
            //this.Hide();



        }

        private void Employee_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void Post_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void SubDivision_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void FullName_Enter(object sender, EventArgs e)
        {
            if(FullName.Text == "Введите ФИО")
                FullName.Text = "";
            FullName.ForeColor = Color.Black;

        }

        private void FullName_Leave(object sender, EventArgs e)
        {
            if (FullName.Text == "")
            {
                FullName.Text = "Введите ФИО";
                FullName.ForeColor = Color.Gray;
            }
        }

        private void DateOfBirth_Enter(object sender, EventArgs e)
        {
            if (DateOfBirth.Text == "Введите дату рождения")
                DateOfBirth.Text = "";
            DateOfBirth.ForeColor = Color.Black;
        }

        private void DateOfBirth_Leave(object sender, EventArgs e)
        {
            if (DateOfBirth.Text == "")
            {
                DateOfBirth.Text = "Введите дату рождения";
                DateOfBirth.ForeColor = Color.Gray;
            }
        }

        private void Education_Enter(object sender, EventArgs e)
        {
            if (Education.Text == "Введите образование")
                Education.Text = "";
            Education.ForeColor = Color.Black;
        }

        private void Education_Leave(object sender, EventArgs e)
        {
            if (Education.Text == "")
            {
                Education.Text = "Введите образование";
                Education.ForeColor = Color.Gray;
            }
        }

        private void Add_Applicant_Click_1(object sender, EventArgs e)
        {
            string[] data = DateOfBirth.Text.Split('.');
            int Day = int.Parse(data[0]);
            int Month = int.Parse(data[1]);
            int Year = int.Parse(data[2]);


            var applicant = new Applicant(FullName.Text, new DateTime(Year, Month, Day), Education.Text);

            Database.applicants.Add(applicant);

            //обновляем коллекцию
            listBox1.Items.Clear();
            foreach (var i in Database.applicants) listBox1.Items.Add($"{i.FullName}  | {i.DateOfBirth.ToShortDateString()} | {i.Education}");

            MessageBox.Show(
                "Успешно добавлен: " + applicant.FullName,
                "Сообщение");

            /*
            //находим индекс, где встречается в БД наше ФИО
            int index = Database.applicants.IndexOf(Database.applicants.Where(n => n.FullName == FullName.Text).FirstOrDefault());

            //PS возможно тут надо  все вхождения ФИО удалить

            string[] data = DateOfBirth.Text.Split('.');
            int Day = int.Parse(data[0]);
            int Month = int.Parse(data[1]);
            int Year = int.Parse(data[2]);

            var applicant = new Applicant(FullName.Text, new DateTime(Year, Month, Day), Education.Text);

            //Заменяем на новую
            Database.applicants[index] = applicant;



            //Удаляем все вхождения с выбранным ФИО
            Database.applicants.RemoveAll(x => x.FullName == FullName.Text);
            */

        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveApplicant_Click(object sender, EventArgs e)
        {
            
        }

        private void RedApplicant_Click(object sender, EventArgs e)
        {

            
        }

        private void ApplicantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе удалить, получаем текст с выбранного элемента списка
            string fname = listBox1.SelectedItem.ToString();

            //потом парсить начинаю
            string[] parsing = fname.Split('|');
            fname = parsing[0].Trim();


            //Удаляем все вхождения с выбранным ФИО с базы данных
            Database.applicants.RemoveAll(x => x.FullName == fname);

            //обновляем коллекцию
            listBox1.Items.Clear();
            //foreach (var i in Database.applicants) listBox1.Items.Add(i.FullName);
            foreach (var i in Database.applicants) listBox1.Items.Add($"{i.FullName}  | {i.DateOfBirth.ToShortDateString()} | {i.Education}");

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе выбор, получаем индекс с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            string[] data = DateOfBirth.Text.Split('.');
            int Day = int.Parse(data[0]);
            int Month = int.Parse(data[1]);
            int Year = int.Parse(data[2]);

            //И заполняем поля класса соискатель с нашей формы
            Database.applicants[index_it].FullName = FullName.Text;
            Database.applicants[index_it].DateOfBirth = new DateTime(Year, Month, Day);
            Database.applicants[index_it].Education = Education.Text;

            //обновляем коллекцию
            listBox1.Items.Clear();
            foreach (var i in Database.applicants) listBox1.Items.Add($"{i.FullName}  | {i.DateOfBirth.ToShortDateString()} | {i.Education}");

        }

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе выбор, получаем индекс с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            //И заполняем поля нашей формы
            FullName.Text = Database.applicants[index_it].FullName;
            DateOfBirth.Text = Database.applicants[index_it].DateOfBirth.ToShortDateString();
            Education.Text = Database.applicants[index_it].Education;


        }

        private void ApplicantForm_MouseEnter(object sender, EventArgs e)
        {
            
        }

        Point lastpoint;
        private void ApplicantForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {

                this.Left += e.X - lastpoint.X; //смещение по X
                this.Top += e.Y - lastpoint.Y; //смещение по Y
            }
        }

        private void ApplicantForm_MouseDown(object sender, MouseEventArgs e)
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
