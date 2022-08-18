using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business;
using Models;

namespace ProjectOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly BusinessProgram _Business;

        public APIController()
        {
            this._Business = new BusinessProgram();
        }

        //
        //
        //
        //
        //
        [HttpGet("RequestsAsync")]
        [HttpGet("RequestsAsync/{type}")]
        [HttpGet("RequestsAsync/{type}/{id}")]
        [HttpGet("RequestsAsync/{id}")]

        public async Task<ActionResult<List<Request>>> RequestsAsync(string? type, Guid? id)
        {
            if (type.Equals("Pending"))
            {
                List<Request> requestList = await this._Business.RequestsAsync();
                return requestList;
            }
            return null;
        }

    }
}
