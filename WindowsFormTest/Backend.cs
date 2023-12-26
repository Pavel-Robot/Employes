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
using static project.Employee;

namespace WindowsFormTest
{
    public partial class Backend : Form
    {
        public Backend()
        {
            InitializeComponent();

            FullName.Text = "Введите ФИО";
            FullName.ForeColor = Color.Gray;

            foreach (var i in Database.employees) 
                dataGridView1.Rows.Add(i.FullName, i.Status);
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void databaseBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[dataGridView1.CurrentRow.Index]
            //dataGridView1.Rows[1].Cells[2].Style.ForeColor = Color.Aqua;
            //e.RowIndex
            //e.ColumnIndex

            //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void Backend_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var i in Database.employees) { 

                if(FullName.Text == "Введите ФИО" || FullName.Text == "")
                    dataGridView1.Rows.Add(i.FullName, i.Status);

                else if(FullName.Text == i.FullName) 
                    dataGridView1.Rows.Add(i.FullName, i.Status);
            }


            MessageBox.Show(
                "Успешно показаны все",
                "Сообщение");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var i in Database.employees)
                if(i.Status == InpStatus.Work && (FullName.Text == "Введите ФИО" || FullName.Text == ""))
                    dataGridView1.Rows.Add(i.FullName, i.Status);

                else if(i.Status == InpStatus.Work && FullName.Text == i.FullName) 
                    dataGridView1.Rows.Add(i.FullName, i.Status);

            MessageBox.Show(
                "Успешно показаны работающие",
                "Сообщение");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var i in Database.employees)
                if (i.Status == InpStatus.Dissmised && (FullName.Text == "Введите ФИО" || FullName.Text == ""))
                    dataGridView1.Rows.Add(i.FullName, i.Status);

                else if(i.Status == InpStatus.Dissmised && FullName.Text == i.FullName)
                    dataGridView1.Rows.Add(i.FullName, i.Status);

            MessageBox.Show(
                "Успешно показаны уволенные",
                "Сообщение");

        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {

            

            //MessageBox.Show(
             //  "Текст изменился:" + FullName.Text,
             // "Сообщение");
        }

        private void FullName_Enter(object sender, EventArgs e)
        {
            if (FullName.Text == "Введите ФИО")
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

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Gray;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string TabVal = dataGridView1.SelectedCells[0].Value.ToString();

            int ind = dataGridView1.CurrentRow.Index;
            string name = Database.employees[ind].FullName;
            int counter = 0;


            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить запись {name}?",
                                       "Сообщение об удалении", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Database.employees.RemoveAt(ind);



                dataGridView1.Rows.Clear();
                foreach (var i in Database.employees)
                {

                    if (FullName.Text == "Введите ФИО" || FullName.Text == "")
                        dataGridView1.Rows.Add(i.FullName, i.Status);

                    else if (FullName.Text == i.FullName)
                        dataGridView1.Rows.Add(i.FullName, i.Status);
                }


                counter = Database.employees.Where(x => x.FullName == name).Count();


                //если удалены все записи, то вывести
                if (counter == 0)
                {
                    MessageBox.Show(
                "Все записи " + name + " удалены",
                "Сообщение");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }


        }

        Point lastpoint;
        private void Backend_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X; //смещение по X
                this.Top += e.Y - lastpoint.Y; //смещение по Y
            }
        }

        private void Backend_MouseDown(object sender, MouseEventArgs e)
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
