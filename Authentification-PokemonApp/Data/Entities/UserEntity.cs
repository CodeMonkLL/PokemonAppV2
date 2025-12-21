using Microsoft.AspNetCore.Identity;

namespace Authentification_PokemonApp.Data.Entities;

public class UserEntity : IdentityUser
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public int RoleId { get; set; }

}