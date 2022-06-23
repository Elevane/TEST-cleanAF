using cleanAf.Domain.Entitites;
using cleanAf.infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanAf.infrastructure.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<User>> getAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task Add(User user)
        {
             await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
