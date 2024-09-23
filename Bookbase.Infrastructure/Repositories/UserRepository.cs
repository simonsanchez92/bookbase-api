﻿using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bookbase.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;


        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetOne(int userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId && !u.Deleted);

            if (user == null)
            {
                //    //TODO: retrieve err 
                //    throw new KeyNotFoundException($"User with id {userId} not found");
            }

            return user;
        }

        public async Task<User> GetOne(Expression<Func<User, bool>> predicate)
        {
            var user = await _context.Users.FirstOrDefaultAsync(predicate);

            if (user == null)
            {
                //TODO: return err
                return null;
            }

            return user;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.Where(u => !u.Deleted).ToListAsync();
        }

        public async Task<User> Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> Update(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;

        }


    }
}
