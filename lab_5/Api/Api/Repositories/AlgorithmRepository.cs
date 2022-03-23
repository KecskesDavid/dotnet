using Api.Data;
using Api.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class AlgorithmRepository : IAlgorithmRepository
    {
        private readonly AppDbContext _context;

        public AlgorithmRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Algorithms?> getAlgorithm(int Id)
        {
            return await _context.Algorithms.FindAsync(Id);
        }

        public async Task<IEnumerable<Algorithms>> getAllAlgorithms()
        {
            return await Task.Run( () => _context.Algorithms.ToList());
        }

        public bool deleteAlgorithm(int Id)
        {
            var algorithm = _context.Algorithms.Find(Id);

            if(algorithm == null)
            {
                return false;
            }

            _context.Algorithms.Remove(algorithm);
            _context.SaveChanges();
            return true;
        }

        public Algorithms? saveAlgorithm(Algorithms algorithms)
        {
            _context.Add(algorithms);
            _context.SaveChanges();
            return algorithms;
        }

        public bool updateAlgorithm(int Id, Algorithms algorithm)
        {
            var algorithmToUpdate = _context.Algorithms.Find(Id);

            if (algorithmToUpdate == null)
            {
                return false;
            }

            algorithmToUpdate.copy(algorithm);
            _context.SaveChanges();
            return true;
        }
    }
}
