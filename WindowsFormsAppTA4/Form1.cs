using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTA4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Worker
        {
            public int ID;
            public string Name;
            public string CompanyName;
            public string ContactNumber;
            public string Email;
            public Worker(int ID, string Name, string CompanyName, string ContactNumber, string Email)
            {
                this.ID = ID;
                this.Name = Name;
                this.CompanyName = CompanyName;
                this.ContactNumber = ContactNumber;
                this.Email = Email;
            }
        }

        class JobSeekers
        {
            public int ID;
            public string Name;
            public string ContactNumber;
            public string Email;
            public JobSeekers(int ID, string Name, string ContactNumber, string Email)
            {
                this.ID = ID;
                this.Name = Name;
                this.ContactNumber = ContactNumber;
                this.Email = Email;
            }
        }

        class Application
        {
            public int ID;
            public string Vacancy;
            public int Salary;
            public string Description;
            public Application(int ID, string Vacancy, int Salary, string Description)
            {
                this.ID = ID;
                this.Vacancy = Vacancy;
                this.Salary = Salary;
                this.Description = Description;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Меню выбора таблиц
            DataTable table = new DataTable();
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewSelect.AllowUserToAddRows = false;
            table.Columns.Add("Table", typeof(string));
            string[] Types = new string[3] { "Worker", "Job", "Application" };

            for (int i = 0; i < Types.Length; i++)//Заполнения таблицы для выбора
            {
                DataRow row = table.NewRow();
                row["Table"] = Types[i];
                table.Rows.Add(row);
            }
            dataGridViewSelect.DataSource = table;//Отображение на таблице
            dataGridViewSelect.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;//Запрет на сортировку

            //Начальные значения для Работодателей
            TableMainWorker.Columns.Add("ID", typeof(int));//Создание раздела ID на таблицы
            TableMainWorker.Columns.Add("Name", typeof(string));//Создание раздела Name для таблицы
            TableMainWorker.Columns.Add("CompanyName", typeof(string));//Создание раздела CompanyName для таблицы
            TableMainWorker.Columns.Add("ContactNumber", typeof(string));//Создание раздела ContactNumber для таблицы
            TableMainWorker.Columns.Add("Email", typeof(string));//Создание раздела Email для таблицы
            //Заполнение информации
            myHashtableWorker.Add(1, new Worker(1, "Alvarez Artur", "ITDEV", "+380674555255", "arturalv@gmail.com"));
            myHashtableWorker.Add(2, new Worker(2, "Vengerovich Artem", "Microsoft", "+380677705534", "artem@gmail.com"));
            myHashtableWorker.Add(3, new Worker(3, "Heyvan Veronika", "Google", "+380677453921", "nika@gmail.com"));
            myHashtableWorker.Add(4, new Worker(4, "Kostunenko Mihailo", "ITSTEP", "+380677489367", "mihailo@gmail.com"));
            //Заполнение таблицы
            foreach (DictionaryEntry i in myHashtableWorker)
            {
                DataRow row = TableMainWorker.NewRow();
                row["ID"] = ((Worker)i.Value).ID;
                row["Name"] = ((Worker)i.Value).Name;
                row["CompanyName"] = ((Worker)i.Value).CompanyName;
                row["ContactNumber"] = ((Worker)i.Value).ContactNumber;
                row["Email"] = ((Worker)i.Value).Email;
                TableMainWorker.Rows.Add(row);
            }

            //Начальные значения для Тех кто ищет работу
            TableMainJobSeekers.Columns.Add("ID", typeof(int));//Создание раздела ID для таблицы
            TableMainJobSeekers.Columns.Add("Name", typeof(string));//Создание раздела Name для таблиц
            TableMainJobSeekers.Columns.Add("ContactNumber", typeof(string));//Создание раздела ContactNumber для таблицы
            TableMainJobSeekers.Columns.Add("Email", typeof(string));//Создание раздела Email для таблицы
            //Заполнение информации
            myHashtableJobSeekers.Add(1, new JobSeekers(1, "Lyashenko Anastasiya", "+380673647589", "anastasiya@gmail.com"));
            myHashtableJobSeekers.Add(2, new JobSeekers(2, "Naumenko Liza", "+380673647829", "liza@gmail.com"));
            myHashtableJobSeekers.Add(3, new JobSeekers(3, "Rychkova Daria", "+380677589356", "Daria@gmail.com"));
            myHashtableJobSeekers.Add(4, new JobSeekers(4, "Sorokin Maksim", "+3806764739274", "maksim@gmail.com"));
            myHashtableJobSeekers.Add(5, new JobSeekers(5, "Berdichevskiy Denis", "+380674839274", "denis@gmail.com"));
            //Заполнение таблицы
            foreach (DictionaryEntry i in myHashtableJobSeekers)
            {
                DataRow row = TableMainJobSeekers.NewRow();
                row["ID"] = ((JobSeekers)i.Value).ID;
                row["Name"] = ((JobSeekers)i.Value).Name;
                row["ContactNumber"] = ((JobSeekers)i.Value).ContactNumber;
                row["Email"] = ((JobSeekers)i.Value).Email;
                TableMainJobSeekers.Rows.Add(row);
            }

            //Начальные значения для Вакансии
            TableMainApplication.Columns.Add("ID", typeof(int));//Создание раздела ID для таблицы
            TableMainApplication.Columns.Add("JobTitle", typeof(string));//Создание раздела JobTitle для таблицы
            TableMainApplication.Columns.Add("Salary", typeof(int));//Создание раздела Salary для таблиц
            TableMainApplication.Columns.Add("JobDescription", typeof(string));//Создание раздела JobDescription для таблиц
            //Заполнение информации
            myHashtableApplication.Add(1, new Application(1, "Designer", 25000, "Design, develop and maintain software applications."));
            myHashtableApplication.Add(2, new Application(2, "Admin", 17000, "Analyze large datasets and present findings to stakeholders."));
            myHashtableApplication.Add(3, new Application(3, "Programmer", 23000, "Lead product development efforts and coordinate with cross-functional teams."));
            //Заполнение таблицы
            foreach (DictionaryEntry i in myHashtableApplication)
            {
                DataRow row = TableMainApplication.NewRow();
                row["ID"] = ((Application)i.Value).ID;
                row["JobTitle"] = ((Application)i.Value).Vacancy;
                row["Salary"] = ((Application)i.Value).Salary;
                row["JobDescription"] = ((Application)i.Value).Description;
                TableMainApplication.Rows.Add(row);
            }
        }

        void ClearTB()
        {
            TBName.Text = "";
            TBCompanyName.Text = "";
            TBContactNumber.Text = "";
            TBEmail.Text = "";
            TBJobDes.Text = "";
            TBJobTitle.Text = "";
            TBSalary.Text = "";
        }

        void Proverka()
        {
            if (textBox1.Text != "")
            {
                string searchValue_1 = textBox1.Text.ToLower();
                string[] searchValue_2 = searchValue_1.Split(' ');
                dataGridViewMain.CurrentCell = null;
                foreach (DataGridViewRow row in dataGridViewMain.Rows)//Присваиваем таблице false
                {
                    row.Visible = false;
                }
                int temp = 0;
                foreach (DataGridViewRow row in dataGridViewMain.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string searchValue_3 = dataGridViewMain.Rows[row.Index].Cells[cell.ColumnIndex].Value.ToString().ToLower();
                        string[] searchValue_4 = searchValue_3.Split(' ');
                        for (int i = 0; i < searchValue_4.Length; i++)
                        {
                            for (int j = 0; j < searchValue_2.Length; j++)
                            {
                                if (searchValue_4[i] == searchValue_2[j])
                                {
                                    dataGridViewMain.Rows[row.Index].Visible = true;
                                    temp++;
                                }

                            }
                        }
                        if (searchValue_2.Length > 1)//вывод если у нас в поиске больше чем 1 слова то проверяем на кол-во совпадений
                        {
                            if (temp != searchValue_2.Length)
                            {
                                dataGridViewMain.Rows[row.Index].Visible = false;
                                temp = 0;
                            }
                        }
                    }
                }
            }
        }

        

        //Работодатели
        DataTable TableMainWorker = new DataTable();
        Hashtable myHashtableWorker = new Hashtable();
        int _IDWorker = 5;
        //Работодатели
        DataTable TableMainJobSeekers = new DataTable();
        Hashtable myHashtableJobSeekers = new Hashtable();
        int _IDJobSeekers = 5;
        //Вакансии
        DataTable TableMainApplication = new DataTable();
        Hashtable myHashtableApplication = new Hashtable();
        int _IDApplication = 4;

        int selectedIndex = -1;

        private void dataGridViewSelect_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSelect.SelectedRows.Count > 0)
                {
                    selectedIndex = dataGridViewSelect.SelectedRows[0].Index;
                }

                ArrayList Empty = new ArrayList();
                dataGridViewMain.DataSource = Empty;

                switch (selectedIndex)//Появление таблиц
                {
                    case 0:
                        ClearTB();
                        ButtonAdd.Enabled = true;
                        ButtonDel.Enabled = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;


                        TBName.Visible = true;
                        TBCompanyName.Visible = true;
                        TBContactNumber.Visible = true;
                        TBEmail.Visible = true;
                        TBJobDes.Visible = false;
                        TBJobTitle.Visible = false;
                        TBSalary.Visible = false;

                        dataGridViewMain.DataSource = TableMainWorker;
                        break;

                    case 1:
                        ClearTB();
                        ButtonAdd.Enabled = true;
                        ButtonDel.Enabled = true;
                        label1.Visible = true;
                        label4.Visible = true;
                        label3.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label2.Visible = false;


                        TBName.Visible = true;
                        TBContactNumber.Visible = true;
                        TBEmail.Visible = true;
                        TBCompanyName.Visible = false;
                        TBJobDes.Visible = false;
                        TBJobTitle.Visible = false;
                        TBSalary.Visible = false;
                        dataGridViewMain.DataSource = TableMainJobSeekers;
                        break;

                    case 2:
                        ClearTB();
                        ButtonAdd.Enabled = true;
                        ButtonDel.Enabled = true;
                        label1.Visible = false;
                        label4.Visible = false;
                        label3.Visible = false;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label2.Visible = false;

                        TBJobDes.Visible = true;
                        TBJobTitle.Visible = true;
                        TBSalary.Visible = true;
                        TBContactNumber.Visible = true;
                        TBName.Visible = false;
                        TBEmail.Visible = false;
                        TBCompanyName.Visible = false;
                        dataGridViewMain.DataSource = TableMainApplication;
                        break;
                }
            }
            catch
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Поиск
        {
            try
            {
                string searchValue_1 = textBox1.Text.ToLower();
                string[] searchValue_2 = searchValue_1.Split(' ');
                dataGridViewMain.CurrentCell = null;
                foreach (DataGridViewRow row in dataGridViewMain.Rows)//Присваиваем таблице false
                {
                    row.Visible = false;
                }
                int temp = 0;
                foreach (DataGridViewRow row in dataGridViewMain.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string searchValue_3 = dataGridViewMain.Rows[row.Index].Cells[cell.ColumnIndex].Value.ToString().ToLower();
                        string[] searchValue_4 = searchValue_3.Split(' ');
                        for (int i = 0; i < searchValue_4.Length; i++)
                        {
                            for (int j = 0; j < searchValue_2.Length; j++)
                            {
                                if (searchValue_4[i] == searchValue_2[j])
                                {
                                    dataGridViewMain.Rows[row.Index].Visible = true;
                                    temp++;
                                }

                            }
                        }
                        if (searchValue_2.Length > 1)//вывод если в поиске больше чем 1 слова то проверяем на кол-во совпадений
                        {
                            if (temp != searchValue_2.Length)
                            {
                                dataGridViewMain.Rows[row.Index].Visible = false;
                                temp = 0;
                            }
                        }
                    }
                }
                if (textBox1.Text == "")//Если поиск пуст то возв все на место
                {
                    foreach (DataGridViewRow row in dataGridViewMain.Rows)
                    {
                        dataGridViewMain.Rows[row.Index].Visible = true;
                    }
                }
            }
            catch
            {
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSelect.SelectedRows.Count > 0)
                {
                    selectedIndex = dataGridViewSelect.SelectedRows[0].Index;
                }

                switch (selectedIndex)//Добавление
                {
                    case 0://Добавление для Worker
                        myHashtableWorker.Add(_IDWorker, new Worker(_IDWorker, TBName.Text, TBCompanyName.Text, TBContactNumber.Text, TBEmail.Text));
                        DataRow row = TableMainWorker.NewRow();
                        row["ID"] = ((Worker)myHashtableWorker[_IDWorker]).ID;
                        row["Name"] = ((Worker)myHashtableWorker[_IDWorker]).Name;
                        row["CompanyName"] = ((Worker)myHashtableWorker[_IDWorker]).CompanyName;
                        row["ContactNumber"] = ((Worker)myHashtableWorker[_IDWorker]).ContactNumber;
                        row["Email"] = ((Worker)myHashtableWorker[_IDWorker]).Email;
                        TableMainWorker.Rows.Add(row);
                        _IDWorker++;
                        dataGridViewMain.DataSource = TableMainWorker;
                        break;

                    case 1://Добавление для JobSeekers
                        myHashtableJobSeekers.Add(_IDJobSeekers, new JobSeekers(_IDJobSeekers, TBName.Text, TBContactNumber.Text, TBEmail.Text));
                        row = TableMainJobSeekers.NewRow();
                        row["ID"] = ((JobSeekers)myHashtableJobSeekers[_IDJobSeekers]).ID;
                        row["Name"] = ((JobSeekers)myHashtableJobSeekers[_IDJobSeekers]).Name;
                        row["ContactNumber"] = ((JobSeekers)myHashtableJobSeekers[_IDJobSeekers]).ContactNumber;
                        row["Email"] = ((JobSeekers)myHashtableJobSeekers[_IDJobSeekers]).Email;
                        TableMainJobSeekers.Rows.Add(row);
                        _IDJobSeekers++;
                        dataGridViewMain.DataSource = TableMainJobSeekers;
                        break;

                    case 2://Добавление для Application
                        myHashtableApplication.Add(_IDApplication, new Application(_IDApplication, TBJobTitle.Text, Convert.ToInt32(TBSalary.Text), TBJobDes.Text));
                        row = TableMainApplication.NewRow();
                        row["ID"] = ((Application)myHashtableApplication[_IDApplication]).ID;
                        row["JobTitle"] = ((Application)myHashtableApplication[_IDApplication]).Vacancy;
                        row["Salary"] = ((Application)myHashtableApplication[_IDApplication]).Salary;
                        row["JobDescription"] = ((Application)myHashtableApplication[_IDApplication]).Description;
                        TableMainApplication.Rows.Add(row);
                        _IDApplication++;
                        dataGridViewMain.DataSource = TableMainApplication;
                        break;
                }
            }
            catch
            {
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndexMain = -1;
                if (dataGridViewMain.SelectedRows.Count > 0)
                {
                    selectedIndexMain = dataGridViewMain.SelectedRows[0].Index;
                }
                switch (selectedIndex)//Удаление 
                {
                    case 0:
                        myHashtableWorker.Remove(TableMainWorker.Rows[selectedIndexMain]["ID"]);
                        dataGridViewMain.Rows.RemoveAt(selectedIndexMain);
                        Proverka();
                        break;

                    case 1:
                        myHashtableJobSeekers.Remove(TableMainJobSeekers.Rows[selectedIndexMain]["ID"]);
                        dataGridViewMain.Rows.RemoveAt(selectedIndexMain);
                        Proverka();
                        break;

                    case 2:
                        myHashtableApplication.Remove(TableMainApplication.Rows[selectedIndexMain]["ID"]);
                        dataGridViewMain.Rows.RemoveAt(selectedIndexMain);
                        Proverka();
                        break;
                }
            }
            catch
            {
            }
        }

        
    }
}
