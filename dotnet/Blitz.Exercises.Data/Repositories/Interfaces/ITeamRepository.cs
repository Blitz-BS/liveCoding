using Blitz.Exercises.Data.Models;
using Blitz.Exercises.Data.Repositories.Interfaces.Core;

namespace Blitz.Exercises.Data.Repositories.Interfaces;

public interface ITeamRepository : IFullRepository<Team, long>;