using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTos
{
	public record UserDtoForCreation : UserDto
	{
		[DataType(DataType.Password)]
		[Required(ErrorMessage ="Password is required")]
		public string? Password { get; init; }

	}
}

