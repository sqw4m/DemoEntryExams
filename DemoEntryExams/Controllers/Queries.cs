using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DemoEntryExams.Models;
using DemoEntryExams.Context;
using DemoEntryExams.Context.Configuration;

namespace DemoEntryExams.Controllers
{
    class Queries
    {
        public Queries() { Database.SetInitializer(new InitEntryExamsContent()); }

        // вывод персон в таблицу
        public IList QueryShowPeople()
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.People
                    .Select(p => new {
                        p.Id,
                        p.Surname,
                        p.Name,
                        p.Patronymic
                    }).ToList();
            } // using
        } // QueryShowPeople

        // вывод дисциплин в таблцицу
        public IList QueryShowSubjects()
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Subjects
                    .Select(sub => new
                    {
                        sub.Id,
                        sub.SubjectTitle
                    }).ToList();
            } // using
        } // QueryShowCategories


        // вывод абитуриентов в таблцицу
        public IList QueryShowAbiturients()
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Abiturients
                    .Select(ab => new
                    {
                        ab.Id,
                        ab.Person.Surname,
                        ab.Person.Name,
                        ab.Person.Patronymic,
                        ab.Year,
                        ab.Passport,
                        ab.Address
                    }).ToList();
            } // using
        } // QueryShowAbiturients

        // вывод преподавателей в таблцицу
        public IList QueryShowProfessors()
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Professors
                    .Select(prof => new
                    {
                        prof.Id,
                        prof.Person.Surname,
                        prof.Person.Name,
                        prof.Person.Patronymic,
                        prof.Payment
                    }).ToList();
            } // using
        } // QueryShowProfessors

        // вывод экзаменов в таблцицу
        public IList QueryShowExams()
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Exams
                    .Select(ex => new
                    {
                        ex.Id,
                        Абитуриент = ex.Abiturient.Person.Surname + " " + 
                        ex.Abiturient.Person.Name.Substring(0,1) + ". " + 
                        ex.Abiturient.Person.Patronymic.Substring(0, 1) + ".",
                        Преподаватель = ex.Professor.Person.Surname + " " + 
                        ex.Professor.Person.Name.Substring(0, 1) + ". " + 
                        ex.Professor.Person.Patronymic.Substring(0, 1) + ".",
                        Дата = DbFunctions.TruncateTime(ex.ExamDate),
                        Предмет = ex.Subject.SubjectTitle,
                        Оценка = ex.ExamGrade
                    }).ToList();
            } // using
        } // QueryShowExams

        // 1	Запрос на выборку	
        // Выбирает из таблицы АБИТУРИЕНТЫ информацию об абитуриентах, 
        // фамилия которых начинается с заданной буквы
        public IEnumerable Query01(string LetterSurnameStartWith)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Abiturients
                    .Where(a => a.Person.Surname.ToLower().StartsWith(LetterSurnameStartWith.ToLower()))
                    .Select(a => new {
                        a.Id,
                        Абитуриент = a.Person.Surname + " " +
                        a.Person.Name.Substring(0, 1) + ". " +
                        a.Person.Patronymic.Substring(0, 1) + ".",
                        a.Passport,
                        a.Address
                    }).ToList();
            } // using
        } // Query01

        // 2	Запрос на выборку	
        // Выбирает из таблицы ЭКЗАМЕНАТОРЫ информацию об экзаменаторах, 
        // для которых установлен размер оплаты за прием одного экзамена в заданном интервале
        public IEnumerable Query02(int minPayment, int maxPayment)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Professors
                    .Where(p => p.Payment >= minPayment && p.Payment <= maxPayment)
                    .Select(p => new {
                        p.Id,
                        Профессор = p.Person.Surname + " " +
                        p.Person.Name.Substring(0, 1) + ". " +
                        p.Person.Patronymic.Substring(0, 1) + ".",
                        p.Payment
                    }).ToList();
            } // using
        } // Query02

        // 3	Запрос на выборку	
        // Выбирает из таблицы ЭКЗАМЕНЫ информацию об экзаменах, принятых заданным преподавателем
        public IEnumerable Query03(string profSurname)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Exams
                    .Where(e => e.Professor.Person.Surname.ToLower() == profSurname.ToLower())
                    .Select(e => new {
                        e.Id,
                        Абитуриент = e.Abiturient.Person.Surname + " " +
                        e.Abiturient.Person.Name.Substring(0, 1) + ". " +
                        e.Abiturient.Person.Patronymic.Substring(0, 1) + ".",
                        e.ExamDate,
                        Преподаватель = e.Professor.Person.Surname + " " +
                        e.Professor.Person.Name.Substring(0, 1) + ". " +
                        e.Professor.Person.Patronymic.Substring(0, 1) + ".",
                        e.Subject.SubjectTitle,
                        e.ExamGrade
                    }).ToList();
            } // using
        } // Query03

        // 4	Запрос с параметром	
        // Выбирает из таблицы ЭКЗАМЕНАТОРЫ информацию об экзаменаторе с заданными фамилией, 
        // именем, отчеством. Конкретные фамилия, имя и отчество вводятся при выполнении запроса
        public IEnumerable Query04(string surname, string name, string patronymic)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Professors
                    .Where(p => p.Person.Surname.ToLower() == surname.ToLower() &&
                    p.Person.Name.ToLower() == name.ToLower() &&
                    p.Person.Patronymic.ToLower() == patronymic.ToLower())
                    .Select(p => new {
                        p.Id,
                        p.Person.Surname,
                        p.Person.Name,
                        p.Person.Patronymic,
                        p.Payment
                    }).ToList();
            } // using
        } // Query04

        // 5	Запрос с параметром	
        // Выбирает из таблиц АБИТУРИЕНТЫ, ЭКЗАМЕНАТОРЫ и ЭКЗАМЕНЫ информацию обо всех экзаменах 
        // (ФИО абитуриента, ФИО экзаменатора, Наименование дисциплины, Дата сдачи экзамена, Оценка) 
        // в некоторый заданный интервал времени. Нижняя и верхняя границы интервала задаются при выполнении запроса
        public IEnumerable Query05(DateTime dateStart, DateTime dateFinish)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Exams
                    .Where(e => e.ExamDate >= dateStart && e.ExamDate <= dateFinish)
                    .Select(e => new {
                        e.Id,
                        Абитуриент = e.Abiturient.Person.Surname + " " +
                        e.Abiturient.Person.Name.Substring(0, 1) + ". " +
                        e.Abiturient.Person.Patronymic.Substring(0, 1) + ".",
                        e.ExamDate,
                        Преподаватель = e.Professor.Person.Surname + " " +
                        e.Professor.Person.Name.Substring(0, 1) + ". " +
                        e.Professor.Person.Patronymic.Substring(0, 1) + ".",
                        e.Subject.SubjectTitle,
                        e.ExamGrade
                    }).ToList();
            } // using
        } // Query05

        // 6	Запрос с вычисляемыми полями	
        // Вычисляет для каждого экзамена размер налога (Налог=Размер оплаты*13%) 
        // и зарплаты экзаменатора (Зарплата=Размер оплаты - Налог). 
        // Сортировка по полю Дата сдачи экзамена
        public IEnumerable Query06()
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Exams
                    .Select(e => new {
                        e.ExamDate,
                        Преподаватель = e.Professor.Person.Surname + " " +
                        e.Professor.Person.Name.Substring(0, 1) + ". " +
                        e.Professor.Person.Patronymic.Substring(0, 1) + ".",
                        Налог = e.Professor.Payment*0.13,
                        Зарплата = e.Professor.Payment - e.Professor.Payment * 0.13
                    }).OrderBy(e => e.ExamDate).ToList();
            } // using
        } // Query06

        // 7	Итоговый запрос	
        // Выполняет группировку по полю Год рождения в таблице АБИТУРИЕНТЫ. 
        // Для каждой группы определяет количество абитуриентов 
        public IEnumerable Query07()
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Abiturients
                    .GroupBy(a => a.Year)
                    .Select(a => new { 
                        Год = a.Key,
                        Кол = a.Count()
                    }).ToList();
            } // using
        } // Query07

        // 8	Итоговый запрос	
        // Выполняет группировку по полю Наименование дисциплины в таблице ЭКЗАМЕНЫ.
        // Для каждой дисциплины вычисляет среднее значения по полю Оценка
        public IEnumerable Query08()
        {
            using (var ctx = new EntryExamsDbContext())
            {
                return ctx.Exams
                    .GroupBy(e => e.Subject.SubjectTitle)
                    .Select(e => new {
                        Предмет = e.Key,
                        СреднийБалл = e.Average(ex => ex.ExamGrade)
                    }).ToList();
            } // using
        } // Query08

        // 9	Запрос на удаление	
        // Удалить данные об абитуриенте
        public void Query09(int id)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                Abiturient abiturient = ctx.Abiturients.First(a => a.Id == id);
                ctx.Abiturients.Remove(abiturient);

                ctx.SaveChanges();
            } // using
        } // Query09

        // 10	Запрос на удаление	
        // Удалить данные об экзаменаторе
        public void Query10(int id)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                Professor professor = ctx.Professors.First(a => a.Id == id);
                ctx.Professors.Remove(professor);

                ctx.SaveChanges();
            } // using
        } // Query10

        // 11	Запрос на удаление	
        // Удалить данные о сданном абитуриентом экзамене
        public void Query11(int id)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                Exam exam = ctx.Exams.First(a => a.Id == id);
                ctx.Exams.Remove(exam);

                ctx.SaveChanges();
            } // using
        } // Query11

        // 12	Запрос на обновление	
        // Изменить данные об абитуриенте
        public void Query12(string surname, string name, string patronymic, int year,
            string passport, string address, int id)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                var abit = ctx.Abiturients
                    .Where(a => a.Id == id);

                foreach (var a in abit)
                {
                    a.Person.Surname = surname;
                    a.Person.Name = name;
                    a.Person.Patronymic = patronymic;
                    a.Year = year;
                    a.Passport = passport;
                    a.Address = address;
                } // foreach

                ctx.SaveChanges();
            } // using
        } // Query12

        // 13	Запрос на обновление	
        // Изменить данные об экзаменаторе
        public void Query13(string surname, string name, string patronymic, int payment, int id)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                var prof = ctx.Professors
                    .Where(p => p.Id == id);

                foreach (var p in prof)
                {
                    p.Person.Surname = surname;
                    p.Person.Name = name;
                    p.Person.Patronymic = patronymic;
                    p.Payment = payment;
                } // foreach

                ctx.SaveChanges();
            } // using
        } // Query13

        // 14	Запрос на обновление	
        // Изменить данные о сданном абитуриентом экзамене
        public void Query14(string surnameA, string nameA, string patronymicA,
            string surnameP, string nameP, string patronymicP,
            string subject, DateTime examDate, int examGrade, int id)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                var exm = ctx.Exams
                    .Where(e => e.Id == id);

                foreach (var e in exm)
                {
                    e.AbiturientId = ctx.Abiturients.First(a => a.Person.Surname == surnameA &&
                    a.Person.Name == nameA && a.Person.Patronymic == patronymicA).Id;
                    e.ProfessorId = ctx.Professors.First(p => p.Person.Surname == surnameP &&
                    p.Person.Name == nameP && p.Person.Patronymic == patronymicP).Id;
                    e.SubjectId = ctx.Subjects.First(s => s.SubjectTitle == subject).Id;
                    e.ExamDate = examDate;
                    e.ExamGrade = examGrade;
                } // foreach

                ctx.SaveChanges();
            } // using
        } // Query14

        // 15	Запрос на добавление	
        // Добавить абитуриента
        public void Query15(string surname, string name, string patronymic,
            int year, string passport, string address)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                var person = new Person { Surname = surname, Name = name, Patronymic = patronymic };

                ctx.Abiturients.Add(new Abiturient
                {
                    Person = person,
                    Year = year,
                    Passport = passport,
                    Address = address
                });

                ctx.SaveChanges();
            } // using
        } // Query15

        // 16	Запрос на добавление	
        // Добавить преподавателя
        public void Query16(string surname, string name, string patronymic, int payment)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                var person = new Person { Surname = surname, Name = name, Patronymic = patronymic };

                ctx.Professors.Add(new Professor
                {
                    Person = person,
                    Payment = payment
                });

                ctx.SaveChanges();
            } // using
        } // Query16

        // 17	Запрос на добавление	
        // Добавить запись о сданном экзамене
        public void Query17(string surnameA, string nameA, string patronymicA,
            string surnameP, string nameP, string patronymicP,
            string subject, DateTime examDate, int examGrade)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                ctx.Exams.Add(new Exam
                {
                    AbiturientId = ctx.Abiturients.First(
                        a => a.Person.Surname == surnameA && 
                    a.Person.Name == nameA && 
                    a.Person.Patronymic == patronymicA).Id,
                    ProfessorId = ctx.Professors.First(
                        p => p.Person.Surname == surnameP &&
                    p.Person.Name == nameP &&
                    p.Person.Patronymic == patronymicP).Id,
                    SubjectId = ctx.Subjects.First(s => s.SubjectTitle == subject).Id,
                    ExamDate = examDate,
                    ExamGrade = examGrade
                });

                ctx.SaveChanges();
            } // using
        } // Query17

        public string AbiturientProfessor(int id)
        {
            using (var ctx = new EntryExamsDbContext())
            {
                var exam = ctx.Exams.First(e => e.Id == id);

                return exam.Abiturient.Person.Surname + " " + exam.Abiturient.Person.Name + " " +
                    exam.Abiturient.Person.Patronymic + " " + exam.Professor.Person.Surname + " " +
                    exam.Professor.Person.Name + " " + exam.Professor.Person.Patronymic;
            } // using
        } // AbiturientProfessor
    } // Queries
} // DemoEntryExams.Controllers
