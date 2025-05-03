using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Lb2
{
    /// <summary>
    /// Класс, описывающий предметную область Человек
    /// </summary>
    public class Person
    {
        private const double MIN_HEIGHT = 45.0d;
        private const double MAX_HEIGHT = 250.0d;
        private const int MAX_AGE = 125;

        /// <summary>
        /// Поле "Имя человека"
        /// </summary>
        public string name = "Иван";
        /// <summary>
        /// Поле "Фамилия человека"
        /// </summary>
        public string surname = "Иванов";
        /// <summary>
        /// Поле "Пол человека"
        /// </summary>
        //string gender = "мужской";
        /// <summary>
        /// Поле "Год рождения человека"
        /// </summary>
        // int year_of_birth = 2000;
        /// <summary>
        /// Поле "Город проживания человека"
        /// </summary>
        // string city = "Москва";
        /// <summary>
        /// Поле "Страна проживания человека"
        /// </summary>
        // string country = "Россия";
        /// <summary>
        /// Поле "Рост человека"
        /// </summary>
        //double height = 180.5d;
        /// <summary>
        /// Общее количество созданных объектов класса Person
        /// </summary>
        //static byte persons_count = 0;

        /// <summary>
        ///Пол человека
        /// </summary>
        public string Gender { get; set; } = "мужской";

        /// <summary>
        /// Год рождения
        /// </summary>
        public int Year_of_birth { get; set; } = 2000;

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; } = "Москва";

        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; } = "Россия";

        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; } = 180.5d;

        /// <summary>
        /// Общее количество людей
        /// </summary>
        public static int Persons_count { get; private set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person()
        {
            try
            {
                checked
                {
                    Persons_count++;
                }
            }
            catch (OverflowException ex)
            {
                throw new MyOverflowException("Создано слишком много людей", ex)
                {
                    TimeOfExeption = DateTime.Now
                };
            }
        }

        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="_name">Имя</param>
        /// <param name="_surname">Фамилия</param>
        public Person(string _name, string _surname)
        {
            try
            {
                if (!IsRightName(_name))
                {
                    throw new PersonArgumentExeption("Ошибка ввода имени")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                if (!IsRightName(_surname))
                {
                    throw new PersonArgumentExeption("Ошибка ввода фамилии")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                name = _name;
                surname = _surname;
                checked
                {
                    Persons_count++;
                }
            }
            catch (OverflowException ex)
            {
                throw new MyOverflowException("Создано слишком много людей", ex)
                {
                    TimeOfExeption = DateTime.Now
                };
            }
        }

        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="_name">Имя</param>
        public Person(string _name)
        {
            try
            {
                if (!IsRightName(_name))
                {
                    throw new PersonArgumentExeption("Ошибка ввода имени")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                name = _name;
                checked
                {
                    Persons_count++;
                }
            }
            catch (OverflowException ex)
            {
                throw new MyOverflowException("Создано слишком много людей", ex)
                {
                    TimeOfExeption = DateTime.Now
                };
            }
        }

        /// <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="_name">Имя</param>
        /// <param name="_surname">Фамилия</param>
        /// <param name="_gender">Пол</param>
        /// <param name="_year_of_birth">Год рождения</param>
        /// <param name="_city">Город</param>
        /// <param name="_country">Страна</param>
        /// <param name="_height">Рост</param>
        public Person(string _name, string _surname, string _gender, string _year_of_birth,
            string _city, string _country, string _height)
        {
            try
            {
                if (!IsRightName(_name))
                {
                    throw new PersonArgumentExeption("Ошибка ввода имени")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                if (!IsRightName(_surname))
                {
                    throw new PersonArgumentExeption("Ошибка ввода фамилии")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                if (!IsRightYear(_year_of_birth))
                {
                    throw new PersonArgumentExeption("Ошибка ввода года рождения")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                if (!IsRightName(_city))
                {
                    throw new PersonArgumentExeption("Ошибка ввода города")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                if (!IsRightName(_country))
                {
                    throw new PersonArgumentExeption("Ошибка ввода страны")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                if (!IsRightHeight(_height))
                {
                    throw new PersonArgumentExeption("Ошибка ввода роста")
                    {
                        TimeOfExeption = DateTime.Now
                    };
                }
                name = _name;
                surname = _surname;
                Gender = _gender;
                Year_of_birth = Int32.Parse(_year_of_birth);
                City = _city;
                Country = _country;
                Height = Double.Parse(_height);
                checked
                {
                    Persons_count++;
                }
            }
            catch (OverflowException ex)
            {
                throw new MyOverflowException("Создано слишком много людей", ex)
                {
                    TimeOfExeption = DateTime.Now
                };
            }
        }

        /// <summary>
        /// Переопределенный метод ToString()
        /// </summary>
        /// <returns>Полная информация об объекте</returns>
        public override string ToString()
        {
            return "Имя: " + name + "\nФамилия: " + surname + "\nПол: " + Gender + "\nГод рождения: " +
                Year_of_birth.ToString() + "\nГород: " + City + "\nСтрана: " + Country +
                "\nРост: " + Height.ToString() + "\nОбщее количество человек: " + Persons_count.ToString();
        }

        /// <summary>
        /// Проверят правильность строки с возможным ростом человека
        /// </summary>
        /// <param name="_height">Строка с возможным ростом</param>
        /// <returns>True, если проверка пройдена, иначе - false</returns>
        static public bool IsRightHeight(string _height)
        {
            string regex = @"^[0-9]+(,[0-9]+)?$";
            return (Regex.IsMatch(_height, regex) && Convert.ToDouble(_height) > MIN_HEIGHT
                && Convert.ToDouble(_height) < MAX_HEIGHT);
        }


        /// <summary>
        /// Проверяет правильность строки с возможным годом рождения человека
        /// </summary>
        /// <param name="_year_of_birth">Строка с возможным годом рождения</param>
        /// <returns>True, если проверка пройдена, иначе - false</returns>
        static public bool IsRightYear(string _year_of_birth)
        {
            string regex = @"^[0-9]+$";
            int currentYear = DateTime.Now.Year;
            return (Regex.IsMatch(_year_of_birth, regex) &&
                Convert.ToInt32(_year_of_birth) >= currentYear - MAX_AGE
                && Convert.ToInt32(_year_of_birth) <= currentYear);
        }

        /// <summary>
        /// Проверяет правильность какого-либо названия
        /// </summary>
        /// <param name="str">Название</param>
        /// <returns>True, если проверка пройдена, иначе - false</returns>
        static public bool IsRightName(string str)
        {
            string regex = @"^[A-Za-zА-Яа-яЁё]+((-|')[A-Za-zА-Яа-яЁё]+)*$";
            return Regex.IsMatch(str, regex);
        }
    }
}
