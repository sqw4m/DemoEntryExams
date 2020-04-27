using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using DemoEntryExams.Context;

namespace DemoEntryExams.Views
{
    public partial class AddEditExamForm : Form
    {
        public string SurnameA { get; set; }
        public string NameA { get; set; }
        public string PatronymicA { get; set; }
        public string SurnameP { get; set; }
        public string NameP { get; set; }
        public string PatronymicP { get; set; }
        public string Subject { get; set; }
        public DateTime ExamDate { get; set; }
        public int ExamGrade { get; set; }

        public AddEditExamForm()
        {
            InitializeComponent();
            this.Text = "Добавить новую запись о сданном экзамене";

            
        } // AddEditExamForm

        public AddEditExamForm(string aSurname, string aName, string aPatronymic, 
            string pSurname, string pName, string pPatronymic, 
            string subject, DateTime examDate, int examGrade)
        {
            InitializeComponent();
            this.Text = "Редактировать запись о сданном экзамене";

            cbxAbiturient.SelectedItem = aSurname + " " + aName + " " + aPatronymic;
            cbxProfessor.SelectedItem = pSurname + " " + pName + " " + pPatronymic;
            cbxSubject.SelectedItem = subject;
            mcrExamDate.SelectionStart = examDate;
            mcrExamDate.SelectionEnd = examDate;
            nudExamGrade.Value = examGrade;
        } // AddEditExamForm

        private void btnSave_Click(object sender, EventArgs e)
        {
            SurnameA = cbxAbiturient.Text.Split(' ')[0];
            NameA = cbxAbiturient.Text.Split(' ')[1];
            PatronymicA = cbxAbiturient.Text.Split(' ')[2];

            SurnameP = cbxProfessor.Text.Split(' ')[0];
            NameP = cbxProfessor.Text.Split(' ')[1];
            PatronymicP = cbxProfessor.Text.Split(' ')[2];

            Subject = cbxSubject.Text;

            ExamDate = mcrExamDate.SelectionStart;

            ExamGrade = (int)nudExamGrade.Value;
        } // btnSave_Click

        private void AddEditExamForm_Load(object sender, EventArgs e)
        {
            List<string> abiturients = new List<string>();
            List<string> professors = new List<string>();
            List<string> subjects = new List<string>();

            using (var ctx = new EntryExamsDbContext())
            {
                foreach (var ab in ctx.Abiturients)
                    abiturients.Add(ab.Person.Surname + " " +
                        ab.Person.Name + " " + ab.Person.Patronymic);

                foreach (var pr in ctx.Professors)
                    professors.Add(pr.Person.Surname + " " + 
                        pr.Person.Name + " " + pr.Person.Patronymic);

                foreach (var sb in ctx.Subjects)
                    subjects.Add(sb.SubjectTitle);
            } // using

            cbxAbiturient.Items.AddRange(abiturients.ToArray());
            cbxAbiturient.SelectedIndex = 0;
            cbxProfessor.Items.AddRange(professors.ToArray());
            cbxProfessor.SelectedIndex = 0;
            cbxSubject.Items.AddRange(subjects.ToArray());
            cbxSubject.SelectedIndex = 0;
        } // AddEditExamForm_Load
    } // AddEditExamForm : Form
} // DemoEntryExams.Views
