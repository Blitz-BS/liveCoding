using Blitz.Exercises.Data.Models;
using Blitz.Exercises.Data.Repositories.Core;
using Blitz.Exercises.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Blitz.Exercises.Data.Repositories;

public class TeamRepository(IDbContextFactory<Context> contextFactory)
    : FullRepository<Team, long>(contextFactory), ITeamRepository;