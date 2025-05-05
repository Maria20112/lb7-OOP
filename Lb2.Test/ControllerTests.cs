using Xunit;
using Lb2;

namespace Lb2.Test
{
    public class ControllerTests
    {
        private readonly Controller _controller;

        public ControllerTests()
        {
            _controller = new Controller();
        }

        [Fact]
        public void PeopleProperty_ShouldInitializeWithEmptyCollection()
        {
            // Assert
            Assert.NotNull(_controller.People);
            Assert.Empty(_controller.People.getAll());
        }

        [Fact]
        public void Add_WithEmptyName_ShouldCreateDefaultPerson()
        {
            // Act
            _controller.Add("", "Петров", "мужской", "1990", "Ростов", "Россия", "174");

            // Assert
            var person = _controller.People.getAll();
            Assert.Equal("Иван", person.First().name);
            Assert.Equal("Иванов", person.First().surname);
        }

        [Fact]
        public void Add_WithNameOnly_ShouldCreatePersonWithName()
        {
            // Act
            _controller.Add("John", "", "", "", "", "", "");

            // Assert
            var person = _controller.People.getAll();
            Assert.Equal("John", person.First().name);
            Assert.Equal("Иванов", person.First().surname);
        }

        [Fact]
        public void Add_WithNameAndSurnameOnly_ShouldCreatePersonWithBasicInfo()
        {
            // Act
            _controller.Add("Петр", "Doe", "", "", "", "", "");

            // Assert
            var person = _controller.People.getAll();
            Assert.Equal("Петр", person.First().name);
            Assert.Equal("Doe", person.First().surname);
            Assert.Equal("мужской", person.First().Gender);
        }

        [Fact]
        public void Add_WithAllParameters_ShouldCreateFullPerson()
        {
            // Act
            _controller.Add("Анна", "Куликова", "женский", "2003", "Рим", "Италия", "166");

            // Assert
            var person = _controller.People.getAll().First();
            Assert.Equal("Анна", person.name);
            Assert.Equal("Куликова", person.surname);
            Assert.Equal("женский", person.Gender);
            Assert.Equal(2003, person.Year_of_birth);
            Assert.Equal("Рим", person.City);
            Assert.Equal("Италия", person.Country);
            Assert.Equal(166, person.Height);
        }

        [Fact]
        public void Delete_WithValidIndex_ShouldRemovePerson()
        {
            // Arrange
            _controller.Add("John", "Doe", "Male", "1990", "New York", "USA", "180");
            _controller.Add("Jane", "Smith", "Female", "1995", "Los Angeles", "USA", "165");
            int initialCount = _controller.People.getAll().Count;

            // Act
            _controller.Delete(1);

            // Assert
            Assert.Equal(initialCount - 1, _controller.People.getAll().Count);
            Assert.Equal("John", _controller.People.getAll().First().name);
        }

        [Fact]
        public void Delete_WithInvalidIndex_ShouldNotThrow()
        {
            // Arrange
            _controller.Add("John", "Doe", "Male", "1990", "New York", "USA", "180");
            int initialCount = _controller.People.getAll().Count;

            // Act & Assert
            _controller.Delete(-1); 
            _controller.Delete(100); 
            Assert.Equal(initialCount, _controller.People.getAll().Count);
        }
    }
}