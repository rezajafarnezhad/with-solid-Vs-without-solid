using DecoratorDesignPattern.CoreL.Entities;
using MediatR;

namespace DecoratorDesignPattern.MediatR.GetByEmail;

public record GetUserByEmailRequest(string Email) : IRequest<User>;