using Api.Controllers.Response;
using Api.Data.Models;
using Api.Data.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public interface IAlgorithmService
    {
        public Task<PostResponse> saveAlgorithm(AlgorithmDTO algorithmDTO);
        public Task<AlgorithmDTO?> getAlgorithm(int Id);
        public Task<IEnumerable<AlgorithmDTO?>> getAllAlgorithms();
        public Task<Response> deleteAlgorithm(int Id);
        public Task<Response> updateAlgorithm(int Id, AlgorithmDTO algorithmDTO);
    }
}
