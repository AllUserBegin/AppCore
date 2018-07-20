using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace AppCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IEnumerable<User> Users;
        /// <summary>
        /// 
        /// </summary>
        public ValuesController()
        {
            Users = new User[] {
                new User() { Id=1,Name="book",Age=1},
                new User() { Id=2,Name="asp.net core",Age=10},
            };
        }
        // GET api/values
        [HttpGet]
        [Produces("application/proto")]
        public IEnumerable<User> Get()
        {
            return Users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
