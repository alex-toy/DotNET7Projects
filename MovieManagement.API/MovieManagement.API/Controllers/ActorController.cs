using Microsoft.AspNetCore.Mvc;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActorController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            IEnumerable<Actor> actorDbs = _unitOfWork.ActorRepository.GetAll();
            return Ok(actorDbs);
        }
    }
}
