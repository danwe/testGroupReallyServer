using Microsoft.AspNetCore.Mvc;
using projectApiCore.Interfaces;
using projectApiCore.Models;
using projectApiCore.Repository;

namespace projectApiCore.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationRepository _organizationRepository;


        public OrganizationController(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }



        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Worker>))]
        public IActionResult GetWorkers()
        {
            // var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());
            var users = _organizationRepository.GetWorkerList();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }

        [HttpGet("GetMoreDetails")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Worker>))]
        public IActionResult GetWorkers(int workerId)
        {
            var user = _organizationRepository.GetWorkerList().Where(c => c.Id == workerId).ToArray()[0];
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(user);
        }
    }
}
