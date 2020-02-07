using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula223.Models;
using Microsoft.EntityFrameworkCore;

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
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        internal void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
