using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Lab1_Csharp_07._09.Classes;

namespace Lab1_Csharp_07._09
{
    public partial class Form1 : Form
    {
        public List<Worker> ListFromFile = new List<Worker>(); 
        public DataGridView DATA1;
        public DataGridView DATA2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DATA1 = new DataGridView
            {
                Location = new Point(318, 62),
                Size = new Size(400, 200),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            DATA2 = new DataGridView
            {
                Location = new Point(318, 262),
                Size = new Size(400, 200),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            MenuStrip menu = new MenuStrip();
            
            ToolStripMenuItem save = new ToolStripMenuItem("Зберегти");
            ToolStripMenuItem print = new ToolStripMenuItem("Вивести");
            ToolStripMenuItem clear = new ToolStripMenuItem("Очистити");
            ToolStripMenuItem find = new ToolStripMenuItem("Знайти");
            
            save.Click += (s, ev) => SaveToJson();
            print.Click += (s, ev) => LoadFromJson();
            clear.Click += (s, ev) => ClearDataGridView();
            find.Click += (s, ev) => OpenFindWindow();
            
            menu.Items.Add(save);
            menu.Items.Add(print);
            menu.Items.Add(clear);
            menu.Items.Add(find);
            
            this.MainMenuStrip = menu;
            this.Controls.Add(menu);
            
            InitializeDataGridView(DATA1);
            InitializeDataGridView(DATA2);

            this.Controls.AddRange(new Control[] { DATA1, DATA2 });
            
            this.CenterToScreen();
        }

        private void InitializeDataGridView(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.Columns.Add("Name", "Ім`я");
            dataGrid.Columns.Add("Gender", "Стать");
            dataGrid.Columns.Add("Position", "Посада");
            dataGrid.Columns.Add("Age", "Вік");
            dataGrid.Columns.Add("Experience", "Досвід");
        }

        public void UpdateDataGridView(DataGridView dataGrid, List<Worker> workers)
        {
            dataGrid.Rows.Clear();
            foreach (var worker in workers)
            {
                dataGrid.Rows.Add(worker.Name, worker.Gender ? "Чоловік" : "Жінка", worker.Position, worker.Age, worker.Experience);
            }
        }

        private void ClearDataGridView()
        {
            DATA1.Rows.Clear();
            DATA2.Rows.Clear();
            ListFromFile.Clear();
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            CheckMale.Checked = false;
            CheckFemale.Checked = false;
        }

        private void LoadFromJson()
        {
            if (File.Exists("D:\\ООП 3 курс\\workers.json"))
            {
                string jsonString = File.ReadAllText("D:\\ООП 3 курс\\workers.json");
                ListFromFile = JsonSerializer.Deserialize<List<Worker>>(jsonString);
                UpdateDataGridView(DATA1, ListFromFile);
            }
        }

        private void SaveToJson()
        {
            string jsonString = JsonSerializer.Serialize(ListFromFile, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("D:\\ООП 3 курс\\workers.json", jsonString);
            MessageBox.Show("Дані збережено!");
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                return false;
            if (!int.TryParse(numericUpDown1.Text, out int age) || age <= 0 || age > 120)
                return false;
            if (!int.TryParse(numericUpDown2.Text, out int experience) || experience < 0 || experience > age)
                return false;
            return CheckMale.Checked || CheckFemale.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!");
                return;
            }

            var worker = new Worker
            {
                Name = textBox1.Text,
                Gender = CheckMale.Checked,
                Position = textBox2.Text,
                Age = (int)numericUpDown1.Value,
                Experience = (int)numericUpDown2.Value
            };
            ListFromFile.Add(worker);
            UpdateDataGridView(DATA1, ListFromFile);
            ClearTextBoxes();
        }

        private void OpenFindWindow()
        {
            using (FindWorkerForm findForm = new FindWorkerForm(this))
            {
                findForm.ShowDialog();
            }
        }
    }
}