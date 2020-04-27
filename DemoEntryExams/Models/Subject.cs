using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntryExams.Models
{
    public class Subject
    {
        public Subject()
        {
            Exams = new HashSet<Exam>();
        } // Subject

        public int Id { get; set; }

        public string SubjectTitle { get; set; }// название дисциплины

        // связные свойства для связи один-ко-многим с сущностью Exam
        public virtual ICollection<Exam> Exams { get; set; }
    } // Subject
} // namespace DemoEntryExams.Models
