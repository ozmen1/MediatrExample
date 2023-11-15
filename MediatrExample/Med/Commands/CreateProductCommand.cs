using MediatR;

namespace MediatrExample.Med.Commands
{
	public class CreateProductCommand : IRequest<Guid>
	{
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }


    }
}
