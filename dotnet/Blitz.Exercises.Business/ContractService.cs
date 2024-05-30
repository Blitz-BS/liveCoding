using Blitz.Exercises.Business.Interfaces;
using Blitz.Exercises.Data.Models;
using Blitz.Exercises.Data.Repositories.Interfaces;

namespace Blitz.Exercises.Business;

public class ContractService : IContractService
{
    private readonly ITeamRepository _teamRepository;
    private readonly IContractRepository _contractRepository;

    public ContractService(ITeamRepository teamRepository, IContractRepository contractRepository)
    {
        _teamRepository = teamRepository;
        _contractRepository = contractRepository;
    }

    public async Task TerminateContractsAsync(long teamId, IEnumerable<long> playersIds)
    {
        IEnumerable<Contract> contractsToTerminate = _contractRepository.GetAll()
            .Where(c => c.TeamId == teamId && playersIds.Contains(c.PlayerId))
            .ToArray();

        foreach (Contract contract in contractsToTerminate)
        {
            contract.LeaveDate = DateTime.Today;
            await _contractRepository.UpdateAsync(contract);
        }
    }
}