using Microsoft.AspNetCore.Mvc;
using SomeWebApi.Domain;

namespace SomeWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<SomeModel> Get()
        {
            var something = new[]
            {
                new SomeModel
                {
                    Id = Guid.NewGuid(),
                    SomeName = "Name1",
                    SomeNumber = 42,
                    SomeDate = DateTime.Today,
                    SomeEnum = SomeEnum.B
                },
                new SomeModel
                {
                    Id = Guid.NewGuid(),
                    SomeName = "Name2",
                    SomeNumber = 69,
                    SomeDate = DateTime.Today.AddDays(-1),
                    SomeEnum = SomeEnum.C
                }
            };

            return something;
        }
    }
}
