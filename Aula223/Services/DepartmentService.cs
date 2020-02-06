using Aula223.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula223.Services
{
    public class DepartmentService
    {

        private readonly Aula223Context _context;

        public DepartmentService(Aula223Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
