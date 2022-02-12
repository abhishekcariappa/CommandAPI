using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using Microsoft.AspNetCore.Http;

namespace CommandAPI.Controllers
 {

    [Route("[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {        
        private readonly ICommandAPIRepo _repository;
        public HealthController(ICommandAPIRepo repository)
        {        
            _repository = repository;    
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string APIHealth = "API Health Good";
            string DBHealth = "Database Health not Good";

            try
            {
                var commandItem = _repository.GetAllCommands();                

                if (commandItem == null)
                    {
                        DBHealth = "NO records in database";
                        return NotFound(new string[] {APIHealth, DBHealth});
                    }
                DBHealth = "Database Health Good";    
                return Ok(new string[] {APIHealth, DBHealth});   
            }
            catch
            {
             return StatusCode(StatusCodes.Status500InternalServerError,new string[] {APIHealth, DBHealth} ); 
            }               
        }
    }
 }