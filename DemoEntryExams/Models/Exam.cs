using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntryExams.Models
{
    public class Exam
    {
        public int Id { get; set; }

        public virtual Subject Subject { get; set; }

        // внешний ключ дисциплины
        public int SubjectId { get; set; }

        public virtual Abiturient Abiturient { get; set; }

        // внешний ключ абитуриента
        public int AbiturientId { get; set; }

        public virtual Professor Professor { get; set; }

        // внешний ключ профессора
        public int ProfessorId { get; set; }

        // дата сдачи экзамена
        public DateTime ExamDate { get; set; }

        // оценка за экзамен
        public int ExamGrade { get; set; }
    } // Exams
} // namespace DemoEntryExams.Models
