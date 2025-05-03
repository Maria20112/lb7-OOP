using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class Controller
    {
        /// <summary>
        /// Объект класса People, хранит всех созданных людей
        /// </summary>
        private People people = new People();

        /// <summary>
        /// Функция, возвращающая коллекцию объектов Person
        /// </summary>
        /// <returns>коллекцию объектов Person</returns>
        public People getPeople() { return people; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Controller() { }

        /// <summary>
        /// Функция, создающая и добавляющая нового человека в коллекцию
        /// </summary>
        /// <param name="person_name">Имя</param>
        /// <param name="person_surname">Фамилия</param>
        /// <param name="person_gender">Пол</param>
        /// <param name="person_year_of_birth">Год рождения</param>
        /// <param name="person_city">Город</param>
        /// <param name="person_country">Страна</param>
        /// <param name="person_height">Рост</param>
        public void Add(string person_name, string person_surname, string person_gender, 
            string person_year_of_birth, string person_city, string person_country, string person_height)
        {
            Person newPerson;
            if (person_name == "")
            {
                newPerson = new Person();
            }
            else if (person_surname == "")
            {
                newPerson = new Person(person_name);
            }
            else if (person_city == "" || person_country == "" || person_height == "")
            {
                newPerson = new Person(person_name, person_surname);
            }
            else
            {
                newPerson = new Person(person_name, person_surname, person_gender, person_year_of_birth, person_city, person_country, person_height);
            }
            people.Add(newPerson);
        }

        /// <summary>
        /// Функция, удаляющая человека по номеру строки
        /// </summary>
        /// <param name="number">номер удаляемого человека</param>
        public void Delete(int number)
        {
            people.Remove(number);
        }
    }
}
