using Microsoft.EntityFrameworkCore;
using RihalChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalChallenge.Data
{
    public class StudentsService
    {


        private SqliteDbContext _db;
       

        public StudentsService(SqliteDbContext db)
        {
            this._db = db;
        }
        

        public async Task<List<Students>> GetStudentsAsync()
        {

            try
            {
                var Students = await _db.Students
               .Include(s => s.Classes)
               .Include(s => s.Countries)
               .ToListAsync();

                return Students;
            }
            catch (Exception)
            {
                throw;
            }
           
           
        }
    }
}
