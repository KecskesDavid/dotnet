using Api.Controllers.Response;
using Api.Data.Models;
using Api.Data.Models.DTO;
using Api.Data.Models.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Api.Repositories
{
    public class AlgoritmService : IAlgorithmService
    {
        IAlgorithmRepository _repository;
        public AlgoritmService(IAlgorithmRepository repository)
        {
            _repository = repository;
        }

        public Task<Response> deleteAlgorithm(int Id)
        {
            bool isDeleted = Task.Run(() => _repository.deleteAlgorithm(Id)).Result;
            string title = "Succesfully deleted!";

            if(!isDeleted)
            {
                title = "The algorithm was not deleted!";
            }

            return Task.Run(() => new Response(
                title,
                DateTime.Now,
                HttpStatusCode.OK,
                ""
                ));
        }

        public Task<AlgorithmDTO?> getAlgorithm(int Id) => Task.Run(() => AlgorithmMapper.ConvertToDTO(_repository.getAlgorithm(Id).Result));

        public Task<IEnumerable<AlgorithmDTO?>> getAllAlgorithms() => Task.Run(() => _repository
                                                                                        .getAllAlgorithms()
                                                                                        .Result
                                                                                        .Select(algorithm => AlgorithmMapper.ConvertToDTO(algorithm)));
        
        public Task<PostResponse> saveAlgorithm(AlgorithmDTO algorithmDTO)
        {
            DateTime currentTime = DateTime.Now;
            Algorithms? algorithms = AlgorithmMapper.ConvertToEntity(algorithmDTO);

            Algorithms? savedAlgorithm = _repository.saveAlgorithm(algorithms);

            if(savedAlgorithm == null)
            {
                return Task.Run(() => new PostResponse(
                    0,
                    currentTime,
                    HttpStatusCode.BadRequest,
                    "Wrong input values!"
                ));
            }

            return Task.Run(() => new PostResponse(
                savedAlgorithm.Id,
                currentTime,
                HttpStatusCode.OK
                ));
        }

        public Task<Response> updateAlgorithm(int Id, AlgorithmDTO algorithmDTO)
        {
            DateTime currentTime = DateTime.Now;
            Algorithms? algorithms = AlgorithmMapper.ConvertToEntity(algorithmDTO);

            bool isUpdated = _repository.updateAlgorithm(Id, algorithms);
            string title = "Succesfully updated!";

            if (!isUpdated)
            {
                title = "The algorithm was not updated!";
            }

            return Task.Run(() => new Response(
                title,
                DateTime.Now,
                HttpStatusCode.OK,
                ""
                ));
        }
    }
}
