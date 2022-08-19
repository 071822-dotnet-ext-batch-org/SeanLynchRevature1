using Business;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ProjectOne.Controller;

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
    //[HttpGet("RequestsAsync/{type}/{id}")]
    //[HttpGet("RequestsAsync/{id}")]

    public async Task<ActionResult<List<Request>>> RequestsAsync(int type, Guid? id)
    {
        {
            List<Request> requestList = await this._Business.RequestsAsync(type, id);
            return Ok(requestList);
        }
        //return null;

       
    }
    [HttpPut("UpdateTheRequest")]
    public async Task<ActionResult<UpdatedRequestDTO>>   JimmyAsync(ApprovalDTO approval)
    { //call updatedrequestDTO to get your updated request, ApprovalDTO is what you wish to show up on swagger for the approval process
        if (ModelState.IsValid)
        {
            UpdatedRequestDTO approvedRequest = await this._Business.UpdateRequestAsync(approval);
            return approvedRequest;
        }
        else return Conflict(approval);

    }
    //Part 3

    [HttpPut("Tickets")]
    public async Task<ActionResult<Request>> JamesAsync(TicketsDTO Ticketobject)
    {
        if (ModelState.IsValid)
        {
            Request Ticketobj = await this._Business.TicketAsync(Ticketobject);
            //Creating a tickets DTO object called "approvedRequest", the object is coming out of the result of the business layer
            //function TicketAsync, which is using the request object with the name approval as the argument
            return Ticketobj;
        }
        else return Conflict(Ticketobject);

    }







}


