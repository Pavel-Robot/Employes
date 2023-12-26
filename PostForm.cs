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
    public partial class PostForm : Form
    {
        public PostForm()
        {
            InitializeComponent();

            PostName.Text = "Введите должность";
            PostName.ForeColor = Color.Gray;

            foreach ( var i in Database.posts) listBox1.Items.Add($"{i.Name}");



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FullName_TextChanged(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Post post = new Post(PostName.Text);

            Database.posts.Add(post);

            //обновляем коллекцию
            listBox1.Items.Clear();
            foreach (var i in Database.posts) listBox1.Items.Add($"{i.Name}");

            MessageBox.Show(
                "Успешно добавлено: " + post.Name,
                "Сообщение");
            /*

            //находим индекс, где встречается в БД наше ФИО
            int index = Database.posts.IndexOf(Database.posts.Where(n => n.Name == PostName.Text).FirstOrDefault());

            //PS возможно тут надо  все вхождения ФИО удалить

            Post post = new Post(PostName.Text);

            //Заменяем на новую
            Database.posts[index] = post;

            //Удаляем все вхождения 
            Database.posts.RemoveAll(x => x.Name == PostName.Text); */
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе выбор, получаем индекс с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            //И заполняем поля нашей формы
            PostName.Text = Database.posts[index_it].Name;
        }

        private void PostForm_Load(object sender, EventArgs e)
        {

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе редактировать, получаем индекс с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            //И заполняем поля класса должность с нашей формы
            Database.posts[index_it].Name = PostName.Text;

            //обновляем коллекцию
            listBox1.Items.Clear();
            foreach (var i in Database.posts) listBox1.Items.Add($"{i.Name}");

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе удалить, получаем текст с выбранного элемента списка
            string fname = listBox1.SelectedItem.ToString();

            //Удаляем все вхождения с выбранной должностью в базе данных
            Database.posts.RemoveAll(x => x.Name == fname);

            //обновляем коллекцию
            listBox1.Items.Clear();
            //foreach (var i in Database.applicants) listBox1.Items.Add(i.FullName);
            foreach (var i in Database.posts) listBox1.Items.Add($"{i.Name}");

        }

        private void показатьСотрудниковВыбраннойДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //При клике правой мыши и выборе показать, получаем индекс с выбранного элемента списка
            int index_it = listBox1.SelectedIndex;

            string post_name = Database.posts[index_it].Name;

            //Database.employees.Where(x => x.post.Name == post_name);

            listBox2.Items.Clear();
            for (int i = 0; i < Database.employees.Count(); i++) 
            {
                if (Database.employees[i].post.Name == post_name) listBox2.Items.Add($"{Database.employees[i].FullName} | {Database.employees[i].post.Name}");

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PostName_Enter(object sender, EventArgs e)
        {
            if (PostName.Text == "Введите должность")
                PostName.Text = "";
                PostName.ForeColor = Color.Black;
        }

        private void PostName_Leave(object sender, EventArgs e)
        {
            if (PostName.Text == "")
            {
                PostName.Text = "Введите должность";
                PostName.ForeColor = Color.Gray;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        Point lastpoint;
        private void PostForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X; //смещение по X
                this.Top += e.Y - lastpoint.Y; //смещение по Y
            }
        }

        private void PostForm_MouseDown(object sender, MouseEventArgs e)
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
