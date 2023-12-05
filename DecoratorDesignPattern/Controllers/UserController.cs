using DecoratorDesignPattern.CoreL;
using DecoratorDesignPattern.CoreL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorDesignPattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("GetAll")]
    public async Task<ApiResponse> Get()
    {
        var result = await _userRepository.GetList();
        return new ApiResponse<List<User>>(true, ApiStatusCode.Success, result);
    }

    [HttpGet("GetById")]
    public async Task<ApiResponse> GetById([FromQuery] int id)
    {
        var result = await _userRepository.GetBy(id);
        return result != null ? new ApiResponse<User>(true, ApiStatusCode.Success, result) :
            new ApiResponse(false,"خطا", ApiStatusCode.NotFound);
    }

    [HttpGet("GetByEmail/{email}")]
    public async Task<ApiResponse> GetByEmail([FromRoute] string email)
    {
        var result = await _userRepository.GetBy(email);
        return result != null ? new ApiResponse<User>(true, ApiStatusCode.Success, result) :
            new ApiResponse(false,"خطا", ApiStatusCode.NotFound);
    }

    [HttpPost]
    public async Task<ApiResponse> Create([FromForm] User user)
    {
        await _userRepository.Create(user);
        return new ApiResponse(true,"خطا", ApiStatusCode.Success);
    }

    [HttpPut]
    public async Task<ApiResponse> Update([FromForm] User user)
    {
        await _userRepository.Update(user);
        return new ApiResponse(true,"خطا", ApiStatusCode.Success);
    }

    [HttpPut("{userId}/{isActive}")]
    public async Task<ApiResponse> ChangeStatus(int userId, bool isActive)
    {
        await _userRepository.ChangeStatus(userId, isActive);
        return new ApiResponse(true,"خطا", ApiStatusCode.Success);
    }
}
