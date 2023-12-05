using DecoratorDesignPattern.CoreL;
using DecoratorDesignPattern.CoreL.Entities;
using MediatR;

namespace DecoratorDesignPattern.MediatR.GetUsers;

public class GetUsersRequest : IRequest<List<User>>
{
}


public class GetUserRequestHandLer : IRequestHandler<GetUsersRequest, List<User>>
{
    private readonly IUserRepository _userRepository;

    public GetUserRequestHandLer(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetList();
        return users;
    }
}