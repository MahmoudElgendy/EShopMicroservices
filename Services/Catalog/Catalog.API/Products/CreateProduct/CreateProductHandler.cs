using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(String Name, List<String> Categoris, string Description, String ImageFile, decimal Price)
         : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //ToDo:: Business Logic for creating product
            throw new NotImplementedException();
        }
    }
}
