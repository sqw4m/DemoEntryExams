using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEntryExams.Models;
using static DemoEntryExams.Utils.Utils;

namespace DemoEntryExams.Context.Configuration
{
    // DropCreateDatabaseAlways 
    class InitEntryExamsContent : DropCreateDatabaseIfModelChanges<EntryExamsDbContext>
    {
        protected override void Seed(EntryExamsDbContext context)
        {
            base.Seed(context);

            Subject[] subjects = { 
                new Subject {SubjectTitle="высшая математика"},
                new Subject {SubjectTitle="история"},
                new Subject {SubjectTitle="химия"},
                new Subject {SubjectTitle="физика"},
                new Subject {SubjectTitle="теор.мех."},
            };
            foreach (var subject in subjects)
            {
                context.Subjects.Add(subject);
            }

            Person[] persons = {
                new Person {Surname="Романова", Name = "Анастасия", Patronymic = "Олеговна"},
                new Person {Surname="Бойко", Name = "Евгений", Patronymic = "Степанович"},
                new Person {Surname="Вареник", Name = "Владимир", Patronymic = "Дмитриевич"},
                new Person {Surname="Чуб", Name = "Алла", Patronymic = "Генадиевна"},
                new Person {Surname="Вустяк", Name = "Никита", Patronymic = "Степанович"},
                new Person {Surname="Перепелица", Name = "Евгений", Patronymic = "Викторович"},
                new Person {Surname="Карманова", Name = "Екатерина", Patronymic = "Андреевна"},
                new Person {Surname="Пак", Name = "Витольд", Patronymic = "Витольдович"},
                new Person {Surname="Щербань", Name = "Игорь", Patronymic = "Егорович"},
                new Person {Surname="Антоненко", Name = "Филип", Patronymic = "Бедросович"},
                new Person {Surname="Конюхова", Name = "Елизавета", Patronymic = "Павловна"},
                new Person {Surname="Федорова", Name = "Наталья", Patronymic = "Тихоновна"}
            };

            foreach (var person in persons)
            {
                context.People.Add(person);
            }

            var abit1 = new Abiturient
            {
                Person = persons[0],
                Address = "Донецк-23, ул. Лесная, 12, 1",
                Year = 2003,
                Passport = "ВР980644"
            };
            var abit2 = new Abiturient
            {
                Person = persons[2],
                Address = "Макеевка-3, ул. Озерная, 1",
                Year = 2003,
                Passport = "ОР123456"
            };
            var abit3 = new Abiturient
            {
                Person = persons[3],
                Address = "Донецк-14, ул. Ахтырская, 24",
                Year = 2002,
                Passport = "ПШ729261"
            };
            var abit4 = new Abiturient
            {
                Person = persons[5],
                Address = "Донецк-17, ул. Гладкова, 69",
                Year = 2002,
                Passport = "ВК829251"
            };
            var abit5 = new Abiturient
            {
                Person = persons[6],
                Address = "Донецк-15, ул. Зелёная, 32",
                Year = 2004,
                Passport = "ТР920271"
            };
            var abit6 = new Abiturient
            {
                Person = persons[8],
                Address = "Донецк-25, ул. Державная, 120",
                Year = 2002,
                Passport = "ВУ826912"
            };
            var abit7 = new Abiturient
            {
                Person = persons[9],
                Address = "Донецк-5, ул. Карельская, 6",
                Year = 2002,
                Passport = "АВ826972"
            };
            var abit8 = new Abiturient
            {
                Person = persons[10],
                Address = "Донецк-47, ул. Генераторная, 16",
                Year = 2004,
                Passport = "НК820127"
            };

            var proff1 = new Professor
            {
                Person = persons[1],
                Payment = 2100
            };
            var proff2 = new Professor
            {
                Person = persons[4],
                Payment = 2400
            };
            var proff3 = new Professor
            {
                Person = persons[7],
                Payment = 2000
            };
            var proff4 = new Professor
            {
                Person = persons[11],
                Payment = 1800
            };

            context.Exams.Add(new Exam
            {
                Professor = proff1,
                Abiturient = abit1,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1,5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff3,
                Abiturient = abit7,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff1,
                Abiturient = abit8,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff1,
                Abiturient = abit3,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff2,
                Abiturient = abit5,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff4,
                Abiturient = abit2,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff4,
                Abiturient = abit6,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff1,
                Abiturient = abit4,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff2,
                Abiturient = abit5,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff2,
                Abiturient = abit8,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff3,
                Abiturient = abit3,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff4,
                Abiturient = abit2,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff2,
                Abiturient = abit6,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });

            context.Exams.Add(new Exam
            {
                Professor = proff1,
                Abiturient = abit6,
                Subject = subjects[GetRand(0, subjects.Length - 1)],
                ExamDate = DateTime.Now.AddDays(-GetRand(1, 30)),
                ExamGrade = GetRand(1, 5)
            });
            context.SaveChanges();
        } // Seed
    } // InitEntryExamsContent
} // namespace DemoEntryExams.Context.Configuration
