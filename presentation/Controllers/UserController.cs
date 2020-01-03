using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dao;
using BL.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dao.DB.Model;

namespace presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static UserServices service=new UserServices();
        private readonly ILogger<User> _logger;

        public UserController(ILogger<User> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get() => Ok(service.getUsers());

        [HttpGet("{id}")]
        public ActionResult Get(string id)=> Ok(service.getUser(id));

        
    
    }
}
