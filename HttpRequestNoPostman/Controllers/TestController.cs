using Microsoft.AspNetCore.Mvc;

namespace HttpRequestNoPostman.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public string Get()
        {

            string test1 = "Şuan sinirden gülüyorum  yemin ederim... !! ";
            return test1;
        }

        [HttpPost]
        public string Post([FromBody] string NAME ) 
        {

            string CUMLE = $"{NAME} naberrrrrrrrrrr";

            return CUMLE;
            
        
        
        }

    }
}
