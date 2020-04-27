using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoEntryExams.Models;

namespace DemoEntryExams.Views
{
    public partial class AddEditAbiturientForm : Form
    {
        public string Surname { get; set; }
        public string AName { get; set; }
        public string Patronymic { get; set; }
        public int Year { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }

        public AddEditAbiturientForm()
        {
            InitializeComponent();
            this.Text = "Добавление нового абитуриента";
        } // AddEditAbiturientForm

        public AddEditAbiturientForm(string surname, string name, string patronymic, 
            int year, string passport, string address)
        {
            InitializeComponent();
            this.Text = "Редактирование выбранного абитуриента";

            txbSurname.Text = surname;
            txbName.Text = name;
            txbPatronymic.Text = patronymic;
            nudBithYear.Value = year;
            txbPassport.Text = passport;
            txbAddress.Text = address;
        } // AddEditAbiturientForm

        private void btnSave_Click(object sender, EventArgs e)
        {
            Surname = txbSurname.Text;
            AName = txbName.Text;
            Patronymic = txbPatronymic.Text;
            Year = (int)nudBithYear.Value;
            Passport = txbPassport.Text;
            Address = txbAddress.Text;
        } // btnSave_Click
    } // AddEditAbiturientForm : Form
} // DemoEntryExams.Views
