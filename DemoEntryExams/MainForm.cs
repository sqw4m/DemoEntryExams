using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoEntryExams.Controllers;
using DemoEntryExams.Views;
using DemoEntryExams.Models;

namespace DemoEntryExams
{
    public partial class MainForm : Form
    {
        Queries _queries;
        public MainForm()
        {
            InitializeComponent();
            _queries = new Queries();
        } // MainForm

        private void MainForm_Load(object sender, EventArgs e)
        {
            tspMain.Stretch = true;
            dvwSubjects.DataSource = _queries.QueryShowSubjects();
            dvwAbiturients.DataSource = _queries.QueryShowAbiturients();
            dvwProfessors.DataSource = _queries.QueryShowProfessors();
            dvwExams.DataSource = _queries.QueryShowExams();
        } // MainForm_Load

        // 1	Запрос на выборку	
        // Выбирает из таблицы АБИТУРИЕНТЫ информацию об абитуриентах, 
        // фамилия которых начинается с заданной буквы
        private void tsbQuery1_MouseEnter(object sender, EventArgs e)
            => txbQueryInfo.Text = "Выбирает из таблицы АБИТУРИЕНТЫ информацию об абитуриентах, " +
            "фамилия которых начинается с заданной буквы";

        private void tsbQuery1_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpQueries;
            dvwQueries.DataSource = _queries.Query01("а");
        } // tsbQuery1_Click

        // 2	Запрос на выборку	
        // Выбирает из таблицы ЭКЗАМЕНАТОРЫ информацию об экзаменаторах, 
        // для которых установлен размер оплаты за прием одного экзамена в заданном интервале
        private void tsbQuery2_MouseEnter(object sender, EventArgs e)
            => txbQueryInfo.Text = "Выбирает из таблицы ЭКЗАМЕНАТОРЫ информацию об экзаменаторах,\n" +
            "для которых установлен размер оплаты за прием одного экзамена в заданном интервале";

        private void tsbQuery2_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpQueries;
            dvwQueries.DataSource = _queries.Query02(1800, 1900);
        } // tsbQuery2_Click

        // 3	Запрос на выборку	
        // Выбирает из таблицы ЭКЗАМЕНЫ информацию об экзаменах, принятых заданным преподавателем
        private void tsbQuery3_MouseEnter(object sender, EventArgs e)
             => txbQueryInfo.Text = "Выбирает из таблицы ЭКЗАМЕНЫ информацию об экзаменах, принятых заданным преподавателем";

        private void tsbQuery3_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpQueries;
            dvwQueries.DataSource = _queries.Query03("пАК");
        } // tsbQuery3_Click

        // 4	Запрос с параметром	
        // Выбирает из таблицы ЭКЗАМЕНАТОРЫ информацию об экзаменаторе с заданными фамилией, 
        // именем, отчеством. Конкретные фамилия, имя и отчество вводятся при выполнении запроса
        private void tsbQuery4_MouseEnter(object sender, EventArgs e)
             => txbQueryInfo.Text = "Выбирает из таблицы ЭКЗАМЕНАТОРЫ информацию об экзаменаторе с заданными фамилией, именем, отчеством.\n" +
            "Конкретные фамилия, имя и отчество вводятся при выполнении запроса";

        private void tsbQuery4_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpQueries;
            dvwQueries.DataSource = _queries.Query04("пак", "витольд", "витольдович");
        } // tsbQuery4_Click

        // 5	Запрос с параметром	
        // Выбирает из таблиц АБИТУРИЕНТЫ, ЭКЗАМЕНАТОРЫ и ЭКЗАМЕНЫ информацию обо всех экзаменах 
        // (ФИО абитуриента, ФИО экзаменатора, Наименование дисциплины, Дата сдачи экзамена, Оценка) 
        // в некоторый заданный интервал времени. Нижняя и верхняя границы интервала задаются при выполнении запроса
        private void tsbQuery5_MouseEnter(object sender, EventArgs e)
            => txbQueryInfo.Text = "Выбирает из таблиц АБИТУРИЕНТЫ, ЭКЗАМЕНАТОРЫ и ЭКЗАМЕНЫ\n" +
            "информацию обо всех экзаменах в некоторый заданный интервал времени";
        private void tsbQuery5_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpQueries;
            dvwQueries.DataSource = _queries.Query05(new DateTime(2020, 04, 19), new DateTime(2020, 04, 21));
        } // tsbQuery5_Click

        // 6	Запрос с вычисляемыми полями	
        // Вычисляет для каждого экзамена размер налога (Налог=Размер оплаты*13%) 
        // и зарплаты экзаменатора (Зарплата=Размер оплаты - Налог). 
        // Сортировка по полю Дата сдачи экзамена
        private void tsbQuery6_MouseEnter(object sender, EventArgs e)
            => txbQueryInfo.Text = "Вычисляет для каждого экзамена размер налога и зарплаты экзаменатора.\n" +
            "Сортировка по полю Дата сдачи экзамена";

        private void tsbQuery6_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpQueries;
            dvwQueries.DataSource = _queries.Query06();
        } // tsbQuery6_Click

        // 7	Итоговый запрос	
        // Выполняет группировку по полю Год рождения в таблице АБИТУРИЕНТЫ. 
        // Для каждой группы определяет количество абитуриентов 
        private void tsbQuery7_MouseEnter(object sender, EventArgs e)
             => txbQueryInfo.Text = "Выполняет группировку по полю Год рождения в таблице АБИТУРИЕНТЫ.\n" +
            "Для каждой группы определяет количество абитуриентов ";
        private void tsbQuery7_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpQueries;
            dvwQueries.DataSource = _queries.Query07();
        } // tsbQuery7_Click

        // 8	Итоговый запрос	
        // Выполняет группировку по полю Наименование дисциплины в таблице ЭКЗАМЕНЫ.
        // Для каждой дисциплины вычисляет среднее значения по полю Оценка
        private void tsbQuery8_MouseEnter(object sender, EventArgs e)
             => txbQueryInfo.Text = "Выполняет группировку по полю Наименование дисциплины в таблице ЭКЗАМЕНЫ.\n" +
            "Для каждой дисциплины вычисляет среднее значения по полю Оценка";
        private void tsbQuery8_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpQueries;
            dvwQueries.DataSource = _queries.Query08();
        } // tsbQuery8_Click

        // 9	Запрос на удаление	
        // Удалить данные об абитуриенте
        private void tsbQuery9_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpAbiturients;
            txbQueryInfo.Text = "Удалить данные об абитуриенте";
        } // tsbQuery9_MouseEnter
        private void tsbQuery9_Click(object sender, EventArgs e)
        {
            // индекс текущей строки
            int row = dvwAbiturients.CurrentRow.Index;
            // id абитуриента в выбранной строке
            int id = int.Parse(dvwAbiturients[0, row].Value.ToString());
            _queries.Query09(id);
            dvwAbiturients.DataSource = _queries.QueryShowAbiturients();
        } // tsbQuery9_Click

        // 10	Запрос на удаление	
        // Удалить данные об экзаменаторе
        private void tsbQuery10_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpProfessors;
            txbQueryInfo.Text = "Удалить данные об экзаменаторе";
        } // tsbQuery10_MouseEnter
        private void tsbQuery10_Click(object sender, EventArgs e)
        {
            // индекс текущей строки
            int row = dvwProfessors.CurrentRow.Index;
            // id экзаменатора в выбранной строке
            int id = int.Parse(dvwProfessors[0, row].Value.ToString());
            _queries.Query10(id);
            dvwProfessors.DataSource = _queries.QueryShowProfessors();
        } // tsbQuery10_Click

        // 11	Запрос на удаление	
        // Удалить данные о сданном абитуриентом экзамене
        private void tsbQuery11_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpExams;
            txbQueryInfo.Text = "Удалить данные о сданном абитуриентом экзамене";
        } // tsbQuery11_MouseEnter
        private void tsbQuery11_Click(object sender, EventArgs e)
        {
            // индекс текущей строки
            int row = dvwExams.CurrentRow.Index;
            // id экзамена в выбранной строке
            int id = int.Parse(dvwExams[0, row].Value.ToString());
            _queries.Query11(id);
            dvwExams.DataSource = _queries.QueryShowExams();
        } // tsbQuery11_Click

        // 12	Запрос на обновление	
        // Изменить данные об абитуриенте
        private void tsbQuery12_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpAbiturients;
            txbQueryInfo.Text = "Изменить данные об абитуриенте";
        } // tsbQuery12_MouseEnter
        private void tsbQuery12_Click(object sender, EventArgs e)
        {
            if (dvwAbiturients.SelectedRows == null) return;

            AddEditAbiturientForm addEditAbiturientForm = new AddEditAbiturientForm(dvwAbiturients.CurrentRow.Cells[1].Value.ToString(),
                dvwAbiturients.CurrentRow.Cells[2].Value.ToString(), dvwAbiturients.CurrentRow.Cells[3].Value.ToString(),
                int.Parse(dvwAbiturients.CurrentRow.Cells[4].Value.ToString()), dvwAbiturients.CurrentRow.Cells[5].Value.ToString(),
                dvwAbiturients.CurrentRow.Cells[6].Value.ToString());
            addEditAbiturientForm.ShowDialog();

            if (addEditAbiturientForm.DialogResult == DialogResult.OK)
            {
                tbcMain.SelectedTab = tbpAbiturients;

                // индекс текущей строки
                int row = dvwAbiturients.CurrentRow.Index;
                // id экзамена в выбранной строке
                int id = int.Parse(dvwAbiturients[0, row].Value.ToString());

                _queries.Query12(addEditAbiturientForm.Surname, addEditAbiturientForm.AName, addEditAbiturientForm.Patronymic,
                    addEditAbiturientForm.Year, addEditAbiturientForm.Passport, addEditAbiturientForm.Address, id);

                dvwAbiturients.DataSource = _queries.QueryShowAbiturients();

                MessageBox.Show("Выбранная вами запись изменена",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // if
        } // tsbQuery12_Click

        // 13	Запрос на обновление	
        // Изменить данные об экзаменаторе
        private void tsbQuery13_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpProfessors;
            txbQueryInfo.Text = "Изменить данные об экзаменаторе";
        } // tsbQuery13_MouseEnter
        private void tsbQuery13_Click(object sender, EventArgs e)
        {
            if (dvwProfessors.SelectedRows == null) return;

            AddEditProfessorForm addEditProfessor = new AddEditProfessorForm(dvwProfessors.CurrentRow.Cells[1].Value.ToString(),
                dvwProfessors.CurrentRow.Cells[2].Value.ToString(), dvwProfessors.CurrentRow.Cells[3].Value.ToString(),
                int.Parse(dvwProfessors.CurrentRow.Cells[4].Value.ToString()));
            addEditProfessor.ShowDialog();

            if (addEditProfessor.DialogResult == DialogResult.OK)
            {
                tbcMain.SelectedTab = tbpProfessors;

                // индекс текущей строки
                int row = dvwProfessors.CurrentRow.Index;
                // id экзамена в выбранной строке
                int id = int.Parse(dvwProfessors[0, row].Value.ToString());

                _queries.Query13(addEditProfessor.Surname, addEditProfessor.PName, addEditProfessor.Patronymic,
                    addEditProfessor.Payment, id);

                dvwProfessors.DataSource = _queries.QueryShowProfessors();

                MessageBox.Show("Выбранная вами запись изменена",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // if
        } // tsbQuery13_Click

        // 14	Запрос на обновление	
        // Изменить данные о сданном абитуриентом экзамене
        private void tsbQuery14_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpExams;
            txbQueryInfo.Text = "Изменить данные о сданном абитуриентом экзамене";
        } // tsbQuery14_MouseEnter
        private void tsbQuery14_Click(object sender, EventArgs e)
        {
            if (dvwExams.SelectedRows == null) return;

            // индекс текущей строки
            int row = dvwExams.CurrentRow.Index;
            // id экзамена в выбранной строке
            int id = int.Parse(dvwExams[0, row].Value.ToString());
            
            string[] abProf = _queries.AbiturientProfessor(id).Split(' ');

            AddEditExamForm addEditExamForm = new AddEditExamForm(abProf[0], abProf[1], abProf[2], 
                abProf[3], abProf[4], abProf[5], dvwExams.CurrentRow.Cells[4].Value.ToString(),
                (DateTime)dvwExams.CurrentRow.Cells[3].Value, int.Parse(dvwExams.CurrentRow.Cells[5].Value.ToString()));
            addEditExamForm.ShowDialog();
            
            if (addEditExamForm.DialogResult == DialogResult.OK)
            {
                tbcMain.SelectedTab = tbpExams;
            
                _queries.Query14(addEditExamForm.SurnameA, addEditExamForm.NameA, addEditExamForm.PatronymicA,
                    addEditExamForm.SurnameP, addEditExamForm.NameP, addEditExamForm.PatronymicP,
                    addEditExamForm.Subject, addEditExamForm.ExamDate, addEditExamForm.ExamGrade, id);
            
                dvwExams.DataSource = _queries.QueryShowExams();
            
                MessageBox.Show("Выбранная вами запись изменена",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // if
        } // tsbQuery14_Click

        // 15	Запрос на добавление	
        // Добавить абитуриента
        private void tsbQuery15_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpAbiturients;
            txbQueryInfo.Text = "Добавить нового абитуриента";
        } // tsbQuery15_MouseEnter
        private void tsbQuery15_Click(object sender, EventArgs e)
        {
            AddEditAbiturientForm addEditAbiturientForm = new AddEditAbiturientForm();
            addEditAbiturientForm.ShowDialog();

            if (addEditAbiturientForm.DialogResult == DialogResult.OK)
            {
                tbcMain.SelectedTab = tbpAbiturients;

                _queries.Query15(addEditAbiturientForm.Surname, addEditAbiturientForm.AName, addEditAbiturientForm.Patronymic,
                    addEditAbiturientForm.Year, addEditAbiturientForm.Passport, addEditAbiturientForm.Address);

                dvwAbiturients.DataSource = _queries.QueryShowAbiturients();

                MessageBox.Show("В конец добавлен новый абитуриент",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // if
        } // tsbQuery15_Click

        // 16	Запрос на добавление	
        // Добавить преподавателя
        private void tsbQuery16_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpProfessors;
            txbQueryInfo.Text = "Добавить нового экзаменатора";
        } // tsbQuery16_MouseEnter
        private void tsbQuery16_Click(object sender, EventArgs e)
        {
            AddEditProfessorForm addEditProfessor = new AddEditProfessorForm();
            addEditProfessor.ShowDialog();

            if (addEditProfessor.DialogResult == DialogResult.OK)
            {
                tbcMain.SelectedTab = tbpProfessors;

                _queries.Query16(addEditProfessor.Surname, addEditProfessor.PName, 
                    addEditProfessor.Patronymic, addEditProfessor.Payment);

                dvwProfessors.DataSource = _queries.QueryShowProfessors();

                MessageBox.Show("В конец добавлен новый экзаменатор",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // if
        } // tsbQuery16_Click

        // 17	Запрос на добавление	
        // Добавить запись о сданном экзамене
        private void tsbQuery17_MouseEnter(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tbpExams;
            txbQueryInfo.Text = "Добавить новую запись о сданном экзамене";
        } // tsbQuery17_MouseEnter
        private void tsbQuery17_Click(object sender, EventArgs e)
        {
            AddEditExamForm addEditExamForm = new AddEditExamForm();
            addEditExamForm.ShowDialog();

            if (addEditExamForm.DialogResult == DialogResult.OK)
            {
                tbcMain.SelectedTab = tbpExams;

                _queries.Query17(addEditExamForm.SurnameA, addEditExamForm.NameA, addEditExamForm.PatronymicA,
                    addEditExamForm.SurnameP, addEditExamForm.NameP, addEditExamForm.PatronymicP,
                    addEditExamForm.Subject, addEditExamForm.ExamDate, addEditExamForm.ExamGrade);

                dvwExams.DataSource = _queries.QueryShowExams();

                MessageBox.Show("В конец добавлен новая запись о сданном экзамене",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // if
        } // tsbQuery17_Click

        private void tsbExit_Click(object sender, EventArgs e)
            => Application.Exit();
    } // MainForm : Form
} // DemoEntryExams
