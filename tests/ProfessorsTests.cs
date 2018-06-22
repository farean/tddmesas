namespace Mesas.Tests
{
    using Moq;
    using System;
    using System.Collections.Generic;
    using Xunit;
    
    using Mesas.Entities;
    using Mesas.Interfaces.Repositories;
    using Mesas.Services;
    
    public class ProfessorsTests
    {
        private List<Professor> professors = new List<Professor>
            { 
                new Professor
                {
                Id = 2,
                FirstName = "Fernando",
                LastName = "Arean"
                },
                new Professor
                {
                    Id = 3,
                    FirstName = "User Name 3",
                    LastName = "User Last Name 3"
                }
            };

        [Fact]
        public void GetProfessors_Should_Equal_To_Two()
        {
            var repository = new Mock<IProfessorsRepository>();
            repository.Setup(x => x.GetAll()).Returns(professors);
            
            var listProfessors = new ProfessorsService(repository.Object).GetProfessors();

            Assert.Equal(listProfessors.Count,2);
        }

        [Fact]
        public void GetProfessorById_Should_Be_Equal_To_Two()
        {
            var repository = new Mock<IProfessorsRepository>();
            repository.Setup(x => x.GetAll()).Returns(professors);
            
            var professor = new ProfessorsService(repository.Object).GetByIdProfessor(2);

            Assert.Equal(professor.Id,2);
        }

        [Fact]
        public void GetProfessorById_Should_Be_Null()
        {
            var repository = new Mock<IProfessorsRepository>();
            repository.Setup(x => x.GetAll()).Returns(professors);

            var professor = new ProfessorsService(repository.Object).GetByIdProfessor(22);

            Assert.Null(professor);
        }

        [Fact]
        public void GetProfessorsByDayOfWeek_Should_Not_Empty()
        {
            var repository = new Mock<IProfessorsRepository>();
            repository.Setup(x => x.GetProfessors_ByDay(DayOfWeek.Monday)).Returns(professors);

            //var mondayProfessors= new ProfessorsService(repository.Object).get
        }
    }
}