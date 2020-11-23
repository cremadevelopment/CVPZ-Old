using CVPZ.Core.Entities;
using CVPZ.Core.Repository;
using CVPZ.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CVPZ.Infrastructure.Repository
{
    public class JournalEntryRepository : IRepository<JournalEntry>
    {
        private readonly CVPZContext _context;

        public JournalEntryRepository(CVPZContext context)
        {
            // ToDo :: Is this the correct location to initialize the database and migrate if necessary.
            _context = context;
            _context.Database.Migrate();
//          _context.Database.EnsureCreated();
        }

        public async Task<JournalEntry> AddAsync(JournalEntry entity)
        {
            await _context.JournalEntries.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(JournalEntry entity)
        {
            _context.JournalEntries.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<JournalEntry> GetByIdAsync(int id)
        {
            return await _context.JournalEntries.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<JournalEntry>> ListAsync()
        {

            return await _context.JournalEntries.ToListAsync();
        }

        public async Task UpdateAsync(JournalEntry entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
