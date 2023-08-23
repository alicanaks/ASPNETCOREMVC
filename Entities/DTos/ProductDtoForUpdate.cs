using System;
namespace Entities.DTos
{
	public record ProductDtoForUpdate : ProductDto
	{
		public bool Showcase { get; set; }


	}
}

