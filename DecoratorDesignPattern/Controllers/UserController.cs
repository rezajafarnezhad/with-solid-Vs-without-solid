using System.Runtime.InteropServices.ComTypes;
using DecoratorDesignPattern.ActionFilter;
using DecoratorDesignPattern.CoreL;
using DecoratorDesignPattern.CoreL.Entities;
using DecoratorDesignPattern.MediatR.GetByEmail;
using DecoratorDesignPattern.MediatR.GetById;
using DecoratorDesignPattern.MediatR.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorDesignPattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IMediator _mediator;
    public UserController(IUserRepository userRepository, IMediator mediator)
    {
        _userRepository = userRepository;
        _mediator = mediator;
    }

    [HttpGet("GetAll")]
    [Log]
    public async Task<ApiResponse> Get()
    {
        //var result = await _userRepository.GetList();
        var result = await _mediator.Send(new GetUsersRequest());
        return new ApiResponse<List<User>>(true, ApiStatusCode.Success, result);
    }
    [HttpGet("GetById")]
    public async Task<ApiResponse> GetById([FromQuery] int id)
    {
        //var result = await _userRepository.GetBy(id);
        var result = await _mediator.Send(new GetUserByIdRequest(id));
        return result != null ? new ApiResponse<User>(true, ApiStatusCode.Success, result) :
            new ApiResponse(false,"خطا", ApiStatusCode.NotFound);
    }

    [HttpGet("GetByEmail/{email}")]
    public async Task<ApiResponse> GetByEmail([FromRoute] string email)
    {
        //var result = await _userRepository.GetBy(email);
        var result = await _mediator.Send(new GetUserByEmailRequest(email));
        return result != null ? new ApiResponse<User>(true, ApiStatusCode.Success, result) :
            new ApiResponse(false,"خطا", ApiStatusCode.NotFound);
    }

    [HttpPost]
    public async Task<ApiResponse> Create([FromForm] User user)
    {
        await _userRepository.Create(user);
        return new ApiResponse(true, ApiStatusCode.Success);
    }

    [HttpPut]
    public async Task<ApiResponse> Update([FromForm] User user)
    {
        await _userRepository.Update(user);
        return new ApiResponse(true, ApiStatusCode.Success);
    }

    [HttpPut("{userId}/{isActive}")]
    public async Task<ApiResponse> ChangeStatus(int userId, bool isActive)
    {
        await _userRepository.ChangeStatus(userId, isActive);
        return new ApiResponse(true, ApiStatusCode.Success);
    }

    [HttpGet("Filter")]
    public  ApiResponse RedirectFilterUser()
    {
        return new ApiResponse(false, "شما فیلتر هستید", ApiStatusCode.BadRequest);
    }
}
