using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntryExams.Models
{
    // персональные данные, общие для абитуриентов и экзаменаторов
    public class Person
    {
        public int Id { get; set; }
        
        public string Surname { get; set; }// Фамилия  
        public string  Name { get; set; } // Имя      
        public string Patronymic { get; set; }// Отчество 

        // связные свойства для связи один-ко-одному с сущностями Abiturient и Professor
        public virtual Abiturient Abiturient { get; set; }
        public virtual Professor Professor { get; set; }

    } // Person
} // namespace DemoEntryExams.Models
