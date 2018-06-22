namespace Mesas.Tests
{
    using Xunit;
    using Mesas.Entities;

    public class ProfessorTest
    {
            [Fact]
        public void DisplayName_Should_Be_Doe_Joe()
        {
            var professor = new Professor { FirstName = "John", LastName = "Doe" } ;
            Assert.Equal(professor.DisplayName, "Doe, John");
        }

    }
}