using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class People
    {
        /// <summary>
        /// стек
        /// </summary>
        private Stack<Person> peopleStack;
        /// <summary>
        /// делегат (добавление элемента)
        /// </summary>
        public delegate void PersonAdd();
        /// <summary>
        /// делегат (удаление элемента)
        /// </summary>
        public delegate void PersonRemove();
        /// <summary>
        /// событие (добавление элемента)
        /// </summary>
        public event PersonAdd? NotifyAdd;
        /// <summary>
        /// событие (удаление элемента)
        /// </summary>
        public event PersonRemove? NotifyRemove;

        /// <summary>
        /// возвращает стек
        /// </summary>
        /// <returns></returns>
        public Stack<Person> getAll()
        {
            return peopleStack;
        }

        /// <summary>
        /// добавляет нового человека в стек
        /// </summary>
        /// <param name="person">новый человек</param>
        public void Add(Person person)
        {
            peopleStack.Push(person);
            NotifyAdd?.Invoke();
        }

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public People()
        {
            peopleStack = new Stack<Person>();
        }

        /// <summary>
        /// удаляет человека из стека по номеру
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            id--;
            Stack<Person> helpStack = new Stack<Person> ();
            int count = 0;
            while (peopleStack.Count > 0)
            {
                Person curr = peopleStack.Pop();
                if (count != id)
                {
                    helpStack.Push(curr);
                }
                count++;
            }
            while (helpStack.Count > 0)
            {
                peopleStack.Push(helpStack.Pop ());
            }
            NotifyRemove?.Invoke();
        }
    }
}
