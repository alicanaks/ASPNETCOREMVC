using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTos
{
	public record ResetPasswordDto
	{
		public String? UserName { get; init; }

		[DataType(DataType.Password)]
		[Required(ErrorMessage ="Password is required.")]
		public String? Password { get; init; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required twice for confirm.")]
		[Compare("Password",ErrorMessage ="Passwords are not matched" )]
        public String? ConfirmPassword { get; init; }
	}
}

