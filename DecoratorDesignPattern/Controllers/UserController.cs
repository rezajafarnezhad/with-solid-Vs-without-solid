using DecoratorDesignPattern.CoreL;
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
    public async Task<IActionResult> Get()
    {
        var result = await _userRepository.GetList();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById([FromQuery]int id)
    {
        var result = await _userRepository.GetBy(id);
        return Ok(result);
    }

    [HttpGet("GetByEmail/{email}")]
    public async Task<IActionResult> GetById([FromRoute] string email)
    {
        var result = await _userRepository.GetBy(email);
        return Ok(result);
    }
}
