using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Shared.ControllerBases
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController: ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}