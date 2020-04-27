using System.Collections.Generic;

namespace DemoEntryExams.Models
{
    public class Abiturient
    {
        public Abiturient()
        {
            Exams = new HashSet<Exam>();
        } // Abiturient

        public int Id { get; set; }
        public virtual Person Person { get; set; }

        public string Address { get; set; }// Адрес абитуриента

        public int Year { get; set; }// Год рождения абитуриента

        public string Passport { get; set; }// Серия-номер паспорта абитуриента

        // связные свойства для связи один-ко-многим с сущностью Exam
        public virtual ICollection<Exam> Exams { get; set; }

    } // Abiturient
} // namespace DemoEntryExams.Models
