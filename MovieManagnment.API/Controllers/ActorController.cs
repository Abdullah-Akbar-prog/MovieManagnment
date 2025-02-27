using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagnment.Domain.Repository;

namespace MovieManagnment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActorController(IUnitOfWork unitOfWork) 
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Get() 
        {
            var actor = _unitOfWork.Actor.GetAll();
            return Ok(actor);
        }
        
        [HttpGet("movies")]
        public ActionResult GetWithMovie() 
        {
            var actorWithMMovie = _unitOfWork.Actor.GetActorWithMovie();
            return Ok(actorWithMMovie);
        }
    }
}
