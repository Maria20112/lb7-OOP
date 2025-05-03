using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{

    public class PersonArgumentExeption : ArgumentException
    {
        ///<summary>
        ///Свойство, обозначающее время и дату создания исключения. 
        ///Инициализируется на этапе генерации исключения с помощью инициализатора, впоследствии позволяет 
        ///получать установленное значение при обращении
        /// </summary>    
        ///<returns>Объект с временем и датой создания исключения</returns>
        public DateTime TimeOfExeption { get; init; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonArgumentExeption() : base() { }
        /// <summary>
        /// Конструктор с параметром для создания исключения с сообщением
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        public PersonArgumentExeption(string message) : base(message) { }
        /// <summary>
        /// Конструктор с параметрами для создания исключения с сообщением и внутренним исключением
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="innerExeption">Внутреннее исключение</param>
        public PersonArgumentExeption(string message, Exception innerExeption) : base(message, innerExeption) { }
    }
}

