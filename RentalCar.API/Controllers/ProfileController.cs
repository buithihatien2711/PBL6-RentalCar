// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using AutoMapper;
// using Microsoft.AspNetCore.Mvc;
// using RentalCar.API.Models;
// using RentalCar.Service;
// using AutoMapper.QueryableExtensions;
// using RentalCar.Model.Models;

// namespace RentalCar.API.Controllers
// {
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProfileController : ControllerBase
//    {
//        private readonly IUserService _userService;
//        private readonly IMapper _mapper;

//        public ProfileController(IUserService userService, IMapper mapper)
//        {
//            _userService = userService;
//            _mapper = mapper;
//        }

//        [HttpGet]
//        public ActionResult<IEnumerable<UserProfile>> Get()
//        {
//             var profile = Mapper.Map<User, UserProfile>(_userService.GetUsers());
//             return Ok();
//        }

//        [HttpGet("{id}")]
//        public ActionResult<string> Get(int id)
//        {
//            return "value";
//        }

//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
// }