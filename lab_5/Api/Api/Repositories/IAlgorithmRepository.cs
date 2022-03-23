using Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public interface IAlgorithmRepository 
    {
        public Algorithms? saveAlgorithm(Algorithms algorithms);
        public Task<Algorithms?> getAlgorithm(int Id);
        public Task<IEnumerable<Algorithms>> getAllAlgorithms();
        public bool deleteAlgorithm(int Id);
        public bool updateAlgorithm(int Id, Algorithms algorithm);
    }
}
