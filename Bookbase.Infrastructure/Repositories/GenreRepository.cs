﻿using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bookbase.Infrastructure.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Genre> Create(Genre genre)
        {
            _context.Genres.Add(genre);
            await _context.SaveChangesAsync();

            return genre;
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            return _context.Genres.ToList();
        }

        public async Task<Genre?> GetOne(int genreId)
        {
            var genre = await _context.Genres.FirstOrDefaultAsync(g => g.Id == genreId);

            return genre;
        }

        public async Task<Genre?> GetOne(Expression<Func<Genre, bool>> predicate)
        {
            var genre = await _context.Genres.FirstOrDefaultAsync(predicate);

            return genre;
        }

        public Task<Genre> Update(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}
