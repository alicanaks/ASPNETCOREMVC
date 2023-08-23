using System;
using Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTos
{
	public record  ProductDto
	{
        public int ProductId { get; init; }

        [Required(ErrorMessage = "Product Name is required.")]
        public string? ProductName { get; init;} = String.Empty;

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; init; }

        public string? Summary { get; init; } = string.Empty;

        public String? ImageUrl { get; set; }

        public int? CategoryId { get; init; }

       

    }
}

