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
    public async Task<ApiResponse<List<User>>> Get()
    {
        var result = await _userRepository.GetList();
        return new ApiResponse<List<User>>(true,ApiStatusCode.Success,result);
    }

    [HttpGet("GetById")]
    public async Task<ApiResponse<User>> GetById([FromQuery]int id)
    {
        var result = await _userRepository.GetBy(id);
        return new ApiResponse<User>(true, ApiStatusCode.Success,result);
    }

    [HttpGet("GetByEmail/{email}")]
    public async Task<ApiResponse<User>> GetByEmail([FromRoute] string email)
    {
        var result = await _userRepository.GetBy(email);
        return new ApiResponse<User>(true, ApiStatusCode.Success, result);
    }
}
