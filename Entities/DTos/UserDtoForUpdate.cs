using Entities.DTos;

namespace Entities.DTos
{
    public record UserDtoForUpdate : UserDto
    {
        public HashSet<string> UserRoles { get; set; } = new HashSet<string>();
         
    }
}
