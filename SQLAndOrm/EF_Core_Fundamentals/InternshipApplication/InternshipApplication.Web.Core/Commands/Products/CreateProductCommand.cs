using InernshipApplication.Web.Domain;
using InternshipApplication.Web.Core.Dto;
using MediatR;

namespace InternshipApplication.Web.Core.Commands.Products
{
    public class CreateProductCommand : IRequest
    {
        public NewProductDto ProductDto { get; set; }

    }
}
