using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula223.Models;

namespace Aula223.Services
{
    public class SellerService
    {

        private readonly Aula223Context _context;

        public SellerService(Aula223Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); 
        }

        public void Inset(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
