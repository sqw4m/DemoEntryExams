using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoEntryExams.Utils
{
    static class Utils
    {
        // объект для получения случайных чисел
        public static readonly Random Random = new Random(Environment.TickCount);

        // вывести строку в заданную позицию
        public static void WritePos(int left, int top, string str) {
            Console.SetCursorPosition(left, top);
            Console.Write(str);
        } // WritePos

        // пример краткой формы записи метода
        public static void SetPos(int left, int top) =>
            Console.SetCursorPosition(left, top);
        
        // Вычисление наибольшего общего делителя
        public static int Gcd(int a, int b) {
            return b == 0 ? a : Gcd(b, a % b);
        } // Gcd

        // Получение случайного числа
        // краткая форма записи метода - это не лямбда выражение
        public static int GetRand(int lo, int hi) => Random.Next(lo, hi + 1);
        public static double GetRand(double lo, double hi) => lo + (hi - lo)*Random.NextDouble();

        // получение случайной фамилии и инициалов
        public static string GetRandSurnameNP()
        {
            string[] names = {
                "Попова Мария", "Попова Валентина", "Попова Анна", "Иванов Александр", "Васильев Алексей", "Петров Николай",  
                "Соколов Кирилл", "Яковлев Роман", "Андреев Остап", "Алексеев Геннадий", "Александров Орест", "Смирнов Олег",
                "Лебедев Ростислав", "Григорьев Анатолий", "Степанов Людвиг", "Семёнов Даниил", "Павлов Сергей", "Богданов Николай",
                "Николаев Петр", "Дмитриев Константин", "Егоров Вячеслав", "Волков Павел", "Кузнецов Егор", "Никитин Леонид", 
                "Соловьёв Кузьма", "Тимофеев Ярослав", "Орлов Потап", "Афанасьев Агат", "Филиппов Никита", "Сергеев Захар",
                "Захаров Назар", "Матвеев Лаврентий", "Виноградов Савва", "Кузьмин Клим", "Максимов Матвей", "Козлов Вальдемар",
                "Михайлов Вениамин", "Фёдоров Владимир", "Попов Иван", "Попов Вениамин", "Попов Николай", "Попов Арест"
            };

            return names[GetRand(0, names.Length - 1)];
        } // GetRandName

        // получение случайного номера автомобиля
        public static string GetRandAutoNumber() =>
            $"{(char)GetRand(0x0410, 0x42F)}{GetRand(100, 999)}{(char)GetRand(0x0410, 0x42F)}{(char)GetRand(0x0410, 0x42F)}";

        // получение случайного номера маршрута автобуса
        public static string GetRandRoutNumber() 
        {
            string[] routs = { "32", "26У", "4В", "77", "14", "23" };

            return $"{routs[GetRand(0, routs.Length - 1)]}";
        } // GetRandRoutNumber

        // получение знака зодиака по дате рождения
        public static string GetZodiacSign(DateTime dob)
        {
            if ((dob.Day >= 21 && dob.Month == 3) || (dob.Day <= 20 && dob.Month == 4))
                return "Овен";
            if ((dob.Day >= 21 && dob.Month == 4) || (dob.Day <= 20 && dob.Month == 5))
                return "Телец";
            if ((dob.Day >= 21 && dob.Month == 5) || (dob.Day <= 20 && dob.Month == 6))
                return "Близнецы";
            if ((dob.Day >= 21 && dob.Month == 6) || (dob.Day <= 21 && dob.Month == 7))
                return "Рак";
            if ((dob.Day >= 22 && dob.Month == 7) || (dob.Day <= 22 && dob.Month == 8))
                return "Лев";
            if ((dob.Day >= 23 && dob.Month == 8) || (dob.Day <= 22 && dob.Month == 9))
                return "Дева";
            if ((dob.Day >= 23 && dob.Month == 9) || (dob.Day <= 22 && dob.Month == 10))
                return "Весы";
            if ((dob.Day >= 23 && dob.Month == 10) || (dob.Day <= 21 && dob.Month == 11))
                return "Скорпион";
            if ((dob.Day >= 22 && dob.Month == 11) || (dob.Day <= 21 && dob.Month == 12))
                return "Стрелец";
            if ((dob.Day >= 22 && dob.Month == 12) || (dob.Day <= 20 && dob.Month == 1))
                return "Козерог";
            if ((dob.Day >= 21 && dob.Month == 1) || (dob.Day <= 19 && dob.Month == 2))
                return "Водолей";
            if ((dob.Day >= 20 && dob.Month == 2) || (dob.Day <= 20 && dob.Month == 3))
                return "Рыбы";
            else
                return "Ошибка даты";
        }

        // получение случайной строки
        public static string GetRandString()
        {
            string[] strings = {
                "", "сесть", "информационный", "вытащить", "", "тело",
                "инвестиция", "тишина", "", "европейский", "", "легендарный",
                "", "школьный", "", "войско", "природный", "выявлять",
                "сопровождать", "крохотный", "", "предупредить", "", "фирма",
                "организм", "", "применять", "обстоятельство", "", "посторонний",
                "благоприятный", "", "остров", "", "основной", "грязный",
                "", "дешевый", "любопытный", "чувствительный", "", "ядерный"
            };

            return strings[GetRand(0, strings.Length - 1)];
        } // GetRandString

        // вывод сообщения о разработке метода
        public static void UnderConstruction() {
            SetColor(ConsoleColor.Yellow, ConsoleColor.DarkYellow);
                        
            WritePos(8, 3, "┌──────────────────────────────────┐");
            WritePos(8, 4, "│    [К сведению]                  │");
            WritePos(8, 5, "│                                  │");
            WritePos(8, 6, "│    Метод в разработке            │");
            WritePos(8, 7, "│                                  │");
            WritePos(8, 8, "└──────────────────────────────────┘");
                        
            RestoreColor();
            Console.Write("\n\n\n\n\n");
        } // UnderConstruction

        // Установить текущий цвет символов и фона с сохранением
        // текущего цвета символов и фона
        private static (ConsoleColor Fore,  ConsoleColor Back) _storeColor;
        public static void SetColor(ConsoleColor fore, ConsoleColor back) {
            _storeColor = (Console.ForegroundColor, Console.BackgroundColor);
            Console.ForegroundColor = fore;
            Console.BackgroundColor = back;
        } // SetColor

        // Сохранить цвет
        public static void SaveColor() =>
            _storeColor = (Console.ForegroundColor, Console.BackgroundColor);

        // Восстановить сохраненный цвет
        public static void RestoreColor() =>
            (Console.ForegroundColor, Console.BackgroundColor) = _storeColor;

    } // class Utils

}
