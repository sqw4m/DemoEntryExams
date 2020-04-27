using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEntryExams.Models;

namespace DemoEntryExams.Context
{
    class EntryExamsDbContext : DbContext
    {
        // dbContext имя строки соединения в app.config
        public EntryExamsDbContext() : this("dbContext") { }
        public EntryExamsDbContext(string connectionString)
            : base(connectionString) { }

        // отображение таблиц данных
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Abiturient> Abiturients { get; set; }
        public DbSet<Person> People { get; set; }

        // Реализация FluentAPI
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // настройка Exam
            modelBuilder.Entity<Exam>()
                .Property(e => e.ExamDate)
                .IsRequired();
            modelBuilder.Entity<Exam>()
                .Property(e => e.ExamGrade)
                .IsRequired();

            // настройка Subject
            modelBuilder.Entity<Subject>()
                .Property(s => s.SubjectTitle)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            // связь один-ко-многим Subject-Exam
            modelBuilder.Entity<Subject>()
                .HasMany(s => s.Exams)
                .WithRequired(e => e.Subject);

            // настройка Person
            modelBuilder.Entity<Person>()
                .Property(p => p.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(35);
            modelBuilder.Entity<Person>()
                .Property(p => p.Surname)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(55);
            modelBuilder.Entity<Person>()
                .Property(p => p.Patronymic)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(55);
            // внешние ключи
            // связь один-к-одному с абитуриентами
            modelBuilder.Entity<Abiturient>()
                .HasRequired(a => a.Person)
                .WithOptional(p => p.Abiturient);

            // связь один-к-одному с преподавателями
            modelBuilder.Entity<Professor>()
                .HasRequired(prof => prof.Person)
                .WithOptional(pers => pers.Professor);

            // настройка сущности Abiturient
            modelBuilder.Entity<Abiturient>().Property(a => a.Address)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(60);

            modelBuilder.Entity<Abiturient>().Property(a => a.Year)
                .IsRequired();

            modelBuilder.Entity<Abiturient>().Property(a => a.Passport)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode();
            // связь один-ко-многим Abiturient-Exam
            modelBuilder.Entity<Abiturient>()
                .HasMany(a => a.Exams)
                .WithRequired(e => e.Abiturient);

            // настройка сущности Professor
            modelBuilder.Entity<Professor>().Property(p => p.Payment)
                .IsRequired();
            // связь один-ко-многим Professor-Exam
            modelBuilder.Entity<Professor>()
                .HasMany(p => p.Exams)
                .WithRequired(e => e.Professor);

            // унаследованная обработка
            base.OnModelCreating(modelBuilder);
        } // OnModelCreating
    } // EntryExamsDbContext
} // namespace DemoEntryExams.Context
