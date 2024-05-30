namespace Blitz.Exercises.Business.Interfaces;

public interface IContractService
{
    Task TerminateContractsAsync(long teamId, IEnumerable<long> playersIds);
}