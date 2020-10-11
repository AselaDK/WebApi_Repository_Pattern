using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_Repository_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        // injecting only the IUnitOfWork object

        private readonly IUnitOfWork _unitOfWork;
        public DeveloperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // https://localhost:xxxx/api/developer?count=10
        public IActionResult GetPopularDevelopers([FromQuery]int count)
        {
            var popularDevelopers = _unitOfWork.Developers.GetPopularDevelopers(count);
            return Ok(popularDevelopers);
        }

        [HttpPost]
        public IActionResult AddDeveloperAndProject()
        {
            var developer = new Developer
            {
                Followers = 35,
                Name = "Asela Kotagama"
            };
            var project = new Project
            {
                Name = "aseladk"
            };
            _unitOfWork.Developers.Add(developer);
            _unitOfWork.Projects.Add(project);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}