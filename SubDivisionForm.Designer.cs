namespace WindowsFormTest
{
    partial class SubDivisionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button5 = new System.Windows.Forms.Button();
            this.SubDivName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьСотрудниковВыбраннойДолжностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(43, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(399, 31);
            this.button5.TabIndex = 28;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SubDivName
            // 
            this.SubDivName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SubDivName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubDivName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SubDivName.Location = new System.Drawing.Point(43, 79);
            this.SubDivName.Name = "SubDivName";
            this.SubDivName.Size = new System.Drawing.Size(399, 26);
            this.SubDivName.TabIndex = 26;
            this.SubDivName.Text = "Введите структурное подразделение";
            this.SubDivName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubDivName.TextChanged += new System.EventHandler(this.SubDivName_TextChanged);
            this.SubDivName.Enter += new System.EventHandler(this.SubDivName_Enter);
            this.SubDivName.Leave += new System.EventHandler(this.SubDivName_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 67);
            this.panel1.TabIndex = 25;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(455, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Структурное подразделение";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Miriam Libre", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Перейти назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(43, 299);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(399, 84);
            this.listBox2.TabIndex = 35;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 100);
            this.listBox1.TabIndex = 34;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.показатьСотрудниковВыбраннойДолжностиToolStripMenuItem,
            this.задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(510, 114);
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(509, 22);
            this.выбратьToolStripMenuItem.Text = "Выбрать";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(509, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(509, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // показатьСотрудниковВыбраннойДолжностиToolStripMenuItem
            // 
            this.показатьСотрудниковВыбраннойДолжностиToolStripMenuItem.Name = "показатьСотрудниковВыбраннойДолжностиToolStripMenuItem";
            this.показатьСотрудниковВыбраннойДолжностиToolStripMenuItem.Size = new System.Drawing.Size(509, 22);
            this.показатьСотрудниковВыбраннойДолжностиToolStripMenuItem.Text = "Показать сотрудников выбранного подразделения";
            this.показатьСотрудниковВыбраннойДолжностиToolStripMenuItem.Click += new System.EventHandler(this.показатьСотрудниковВыбраннойДолжностиToolStripMenuItem_Click);
            // 
            // задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem
            // 
            this.задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem.Name = "задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem";
            this.задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(509, 22);
            this.задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem.Text = "Задать начальника подразделения из сотрудников выбранного подразделения";
            this.задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem.MouseEnter += new System.EventHandler(this.ContexMouseEnterHead);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(350, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.SelectesIndChangeSubDiv);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // SubDivisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SubDivName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubDivisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubDivisionForm";
            this.Load += new System.EventHandler(this.SubDivisionForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SubDivisionForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SubDivisionForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox SubDivName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьСотрудниковВыбраннойДолжностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьНачальникаПодразделенияИзСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}