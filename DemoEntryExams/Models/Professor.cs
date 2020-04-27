using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntryExams.Models
{
    public class Professor
    {
        public Professor()
        {
            Exams = new HashSet<Exam>();
        } // Professor

        public int Id { get; set; }
        public virtual Person Person { get; set; }

        // Размер оплаты за прием экзамена у одного абитуриента (может различаться для разных преподавателей)
        public double Payment { get; set; }

        // связные свойства для связи один-ко-многим с сущностью Exam
        public virtual ICollection<Exam> Exams { get; set; }
    } // Professor
} // namespace DemoEntryExams.Models
