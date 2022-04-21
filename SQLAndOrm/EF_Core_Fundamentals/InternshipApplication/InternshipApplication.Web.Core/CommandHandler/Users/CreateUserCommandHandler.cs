using InernshipApplication.Web.Domain;
using InternshipApplication.Web.Core.Commands.Users;
using InternshipApplication.Web.Core.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InternshipApplication.Web.Core.CommandHandler.Users
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user=new User();
            user.Name = request.UserDto.Name;
            user.Email = request.UserDto.Email;
            user.Surname = request.UserDto.Surname;
            user.Id=new System.Guid();
            _unitOfWork.UserRepository.Add(user);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
