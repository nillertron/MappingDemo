using Domain;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDiagnosticRepository
    {
        Task<Diagnostics> ConvertDto();
    }
}