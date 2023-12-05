using DecoratorDesignPattern.CoreL;
using DecoratorDesignPattern.CoreL.Entities;
using MediatR;

namespace DecoratorDesignPattern.MediatR.GetByEmail;

public class GetUserByEmailHandLerRequest : IRequestHandler<GetUserByEmailRequest, User>
{
    private readonly IUserRepository _userRepository;

    public GetUserByEmailHandLerRequest(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle(GetUserByEmailRequest request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetBy(request.Email);
        if (user is null)
        {
            throw new ArgumentNullException("ایمیل یافت نشد");
        }
        return user;
    }
}