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
            Assert.Empty(_controller.People);
        }

        [Fact]
        public void Add_WithEmptyName_ShouldCreateDefaultPerson()
        {
            // Act
            _controller.Add("", "Doe", "Male", "1990", "New York", "USA", "180");

            // Assert
            var person = _controller.People[0];
            Assert.Equal("Unknown", person.Name);
            Assert.Equal("Unknown", person.Surname);
        }

        [Fact]
        public void Add_WithNameOnly_ShouldCreatePersonWithName()
        {
            // Act
            _controller.Add("John", "", "", "", "", "", "");

            // Assert
            var person = _controller.People[0];
            Assert.Equal("John", person.Name);
            Assert.Equal("Unknown", person.Surname);
        }

        [Fact]
        public void Add_WithNameAndSurnameOnly_ShouldCreatePersonWithBasicInfo()
        {
            // Act
            _controller.Add("John", "Doe", "", "", "", "", "");

            // Assert
            var person = _controller.People[0];
            Assert.Equal("John", person.Name);
            Assert.Equal("Doe", person.Surname);
            Assert.Equal("Unknown", person.Gender);
        }

        [Fact]
        public void Add_WithAllParameters_ShouldCreateFullPerson()
        {
            // Act
            _controller.Add("John", "Doe", "Male", "1990", "New York", "USA", "180");

            // Assert
            var person = _controller.People[0];
            Assert.Equal("John", person.Name);
            Assert.Equal("Doe", person.Surname);
            Assert.Equal("Male", person.Gender);
            Assert.Equal("1990", person.YearOfBirth);
            Assert.Equal("New York", person.City);
            Assert.Equal("USA", person.Country);
            Assert.Equal("180", person.Height);
        }

        [Fact]
        public void Delete_WithValidIndex_ShouldRemovePerson()
        {
            // Arrange
            _controller.Add("John", "Doe", "Male", "1990", "New York", "USA", "180");
            _controller.Add("Jane", "Smith", "Female", "1995", "Los Angeles", "USA", "165");
            int initialCount = _controller.People.Count;

            // Act
            _controller.Delete(0);

            // Assert
            Assert.Equal(initialCount - 1, _controller.People.Count);
            Assert.Equal("Jane", _controller.People[0].Name);
        }

        [Fact]
        public void Delete_WithInvalidIndex_ShouldNotThrow()
        {
            // Arrange
            _controller.Add("John", "Doe", "Male", "1990", "New York", "USA", "180");
            int initialCount = _controller.People.Count;

            // Act & Assert
            _controller.Delete(-1); // Should handle gracefully
            _controller.Delete(100); // Should handle gracefully
            Assert.Equal(initialCount, _controller.People.Count);
        }

        [Fact]
        public void Controller_ShouldMaintainSeparatePeopleInstances()
        {
            // Arrange
            var controller1 = new Controller();
            var controller2 = new Controller();

            // Act
            controller1.Add("John", "Doe", "Male", "1990", "New York", "USA", "180");
            controller2.Add("Jane", "Smith", "Female", "1995", "Los Angeles", "USA", "165");

            // Assert
            Assert.Single(controller1.People);
            Assert.Single(controller2.People);
            Assert.NotSame(controller1.People, controller2.People);
        }
    }
}