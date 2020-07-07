using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFEdDbLib;
using System.Transactions;

namespace EFEdDbLib.Controllers
{
    public class ClassesController
    {
        private readonly EdDbContext _context = null;

        public async Task<List<Clas>> GetAll()
        {
            return await _context.Class.ToListAsync();
        }

        public async Task<Clas> GetByPk(int id)
        {
            return await _context.Class.FindAsync(id);
        }

        public async Task<bool> Insert(Clas clas)
        {
            if(clas == null)
            {
                throw new Exception ("Class cannot be null");
            }
            var result = await _context.AddAsync(clas);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(int id, Clas clas)
        {
            if (clas == null)
            {
                throw new Exception("Class cannot be null");
            }

            if(id != clas.Id)
            {
                throw new Exception("Class Id does not match class.Id");
            }

            _context.Update(clas);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var clas = GetByPk(id);
            if(clas == null)
            {
                throw new Exception("Class cannot = null");
            }
            await Delete(clas.Id);
            return true;
        }

        public async Task<bool> Delete(Clas clas)
        {
            if (clas == null)
            {
                throw new Exception("class cannot = null.");
            }

            _context.Remove(clas);
            await _context.SaveChangesAsync();
            return true;
        }
        public ClassesController()
        {
            _context = new EdDbContext();
        }

    }
}
