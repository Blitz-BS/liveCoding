using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Blitz.Exercises.Data;

public class Context : IdentityDbContext<IdentityUser>;