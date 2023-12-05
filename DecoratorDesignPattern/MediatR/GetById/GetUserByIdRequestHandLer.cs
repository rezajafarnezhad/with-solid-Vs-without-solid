using DecoratorDesignPattern.CoreL;
using DecoratorDesignPattern.CoreL.Entities;
using MediatR;

namespace DecoratorDesignPattern.MediatR.GetById;

public class GetUserByIdRequestHandLer : IRequestHandler<GetUserByIdRequest, User>
{
    private readonly IUserRepository _userRepository;

    public GetUserByIdRequestHandLer(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetBy(request.Id);
        return user;

    }
}