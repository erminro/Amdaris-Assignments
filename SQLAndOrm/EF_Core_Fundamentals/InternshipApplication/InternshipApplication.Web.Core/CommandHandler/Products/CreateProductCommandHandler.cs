using InernshipApplication.Web.Domain;
using InternshipApplication.Web.Core.Commands;
using InternshipApplication.Web.Core.Commands.Products;
using InternshipApplication.Web.Core.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InternshipApplication.Web.Core.CommandHandler.Products
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product=new Product();
            product.Name=request.ProductDto.Name;
            product.Description=request.ProductDto.Description;
            product.Price=request.ProductDto.Price;
            product.CompanyName=request.ProductDto.CompanyName;
            product.ImagePath=request.ProductDto.ImagePath;
            product.Id = new System.Guid();
            _unitOfWork.ProductRepository.Add(product);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
