using InernshipApplication.Web.Domain;
using InternshipApplication.Web.Core;
using InternshipApplication.Web.Core.CommandHandler.Categories;
using InternshipApplication.Web.Core.CommandHandler.Products;
using InternshipApplication.Web.Core.CommandHandler.Users;
using InternshipApplication.Web.Core.Commands;
using InternshipApplication.Web.Core.Commands.Categories;
using InternshipApplication.Web.Core.Commands.Products;
using InternshipApplication.Web.Core.Commands.Users;
using InternshipApplication.Web.Core.Dto;
using InternshipApplication.Web.Infrastructure.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InternshipApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cancel = new CancellationToken();
            NewCategoryDto category1 = new NewCategoryDto() {Name="aaa" }; 
            NewProductDto product1=new NewProductDto() { Name = "abc", CompanyName = "asd", Description = "asdf", Price=8.22M };
            NewUserDto user1 = new NewUserDto {Name = "User2",Surname="User1" ,Email="user2@gmail.com"};
            var dbContext = new DataContext();
            var unitOfWork = new UnitOfWork(dbContext); //Add Users 
            var createUserCommandHander = new CreateUserCommandHandler(unitOfWork);
            var createProductCommandHandler = new CreateProductCommandHandler(unitOfWork);
            var createCategoryCommandHandler = new CreateCategoryCommandHandler(unitOfWork);
            var userCommand = new CreateUserCommand
            {
                UserDto = user1,
            };
            var productCommand = new CreateProductCommand
            {
                ProductDto = product1,
            };
            var categoryCommand = new CreateCategoryCommand
            {
                CategoryDto = category1,
            };
            await createUserCommandHander.Handle(userCommand,cancel);
            await createProductCommandHandler.Handle(productCommand,cancel);
            await createCategoryCommandHandler.Handle(categoryCommand,cancel);
            var test = "yes";
        }
    }
}
