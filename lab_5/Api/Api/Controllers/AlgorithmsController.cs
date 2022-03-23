using Api.Data;
using Api.Data.Models;
using Api.Repositories;
using Api.Data.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {

        IAlgorithmService _algorithmService;

        public AlgorithmsController(IAlgorithmService algoritmService)
        {
            _algorithmService = algoritmService;
        }


        // GET: api/Algorithms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlgorithmDTO>> GetAlgorithm(int id)
        {
            AlgorithmDTO? algorithmDTO = await _algorithmService.getAlgorithm(id);

            if(algorithmDTO == null)
            {
                return NotFound();
            }

            return Ok(algorithmDTO);
        }

        // GET: api/Algorithms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlgorithmDTO>>> GetAllAlgorithm()
        {
            IEnumerable<AlgorithmDTO?> algorithmDTOs = await _algorithmService.getAllAlgorithms();

            if (algorithmDTOs == null)
            {
                return NotFound();
            }

            return Ok(algorithmDTOs);
        }

        // POST: api/Algorithms/
        [HttpPost]
        public async Task<ActionResult<PostResponse>> SaveAlgorithm([FromBody] AlgorithmDTO algorithmDTO)
        {
            return await _algorithmService.saveAlgorithm(algorithmDTO);
        }

        // DELETE: api/Algorithms/
        [HttpDelete("{id}")]
        public async Task<ActionResult<Response.Response>> DeleteAlgorithm(int id)
        {
            return await _algorithmService.deleteAlgorithm(id);
        }

        // PUT: api/Algorithms/
        [HttpPut("{id}")]
        public async Task<ActionResult<Response.Response>> UpdateAlgorithm(int id, [FromBody] AlgorithmDTO algorithmDTO)
        {
            return await _algorithmService.updateAlgorithm(id, algorithmDTO);
        }
    }
}
