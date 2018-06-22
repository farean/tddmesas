namespace Mesas.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Mesas.Entities;
    using Mesas.Interfaces.Repositories;

    public class ProfessorsService 
    {
        private IProfessorsRepository repository;
        public ProfessorsService(IProfessorsRepository repository)
        {
            this.repository = repository;

        }
        public List<Professor> GetProfessors()
        {
            return repository.GetAll();

        }

        public Professor GetByIdProfessor(int id)
        {
            return repository.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public List<Professor> GetProfessors_ByWeekDay(DayOfWeek day)
        {
            return null;
        }

    }
}