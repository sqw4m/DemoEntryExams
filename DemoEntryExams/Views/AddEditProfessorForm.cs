using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEntryExams.Views
{
    public partial class AddEditProfessorForm : Form
    {
        public string Surname { get; set; }
        public string PName { get; set; }
        public string Patronymic { get; set; }
        public int Payment { get; set; }

        public AddEditProfessorForm()
        {
            InitializeComponent();
            this.Text = "Добавление нового экзаменатора";
        } // AddEditProfessor

        public AddEditProfessorForm(string surname, string name, string patronymic, int payment)
        {
            InitializeComponent();
            this.Text = "Редактирование выбранного экзаменатора";

            txbSurname.Text = surname;
            txbName.Text = name;
            txbPatronymic.Text = patronymic;
            nudPayment.Value = payment;
        } // AddEditProfessor

        private void btnSave_Click(object sender, EventArgs e)
        {
            Surname = txbSurname.Text;
            PName = txbName.Text;
            Patronymic = txbPatronymic.Text;
            Payment = (int)nudPayment.Value;
        } // btnSave_Click
    } // AddEditProfessor : Form
} // DemoEntryExams.Views
