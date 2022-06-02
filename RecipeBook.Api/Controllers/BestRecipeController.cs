using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestRecipeController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<BestRecipe> GetBestRecipe()
        {
            //return new string[] { "value1", "value2" };
            var ReturningThis = new BestRecipe();

            ReturningThis.RandomMessage = "i think this will work? idk lol";
            


            return Ok(ReturningThis);

        }
        /*
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
