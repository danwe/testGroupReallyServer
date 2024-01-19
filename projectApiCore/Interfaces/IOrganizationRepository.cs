using projectApiCore.Models;

namespace projectApiCore.Interfaces
{
    public interface IOrganizationRepository
    {
        List<Worker> GetWorkerList();
    }
}
