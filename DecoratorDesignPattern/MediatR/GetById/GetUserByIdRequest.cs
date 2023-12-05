using DecoratorDesignPattern.CoreL.Entities;
using MediatR;

namespace DecoratorDesignPattern.MediatR.GetById;

public record GetUserByIdRequest(int Id) : IRequest<User>;