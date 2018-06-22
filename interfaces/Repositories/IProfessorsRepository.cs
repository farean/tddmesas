namespace Mesas.Interfaces.Repositories
{
    using System;
    using System.Collections.Generic;
    using Mesas.Entities;
    
    public interface IProfessorsRepository
    {
        List<Professor> GetAll();
        Professor GetById(int id);
        List<Professor> GetProfessors_ByDay(DayOfWeek dayOfWeek);
    }
}