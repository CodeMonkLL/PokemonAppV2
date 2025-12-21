using Microsoft.EntityFrameworkCore;

namespace Authentification_PokemonApp.Data;


public class AuthentificationDbContext(DbContextOptions<AuthentificationDbContext> options) : DbContext(options)
{

}