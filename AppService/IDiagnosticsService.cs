using Domain;
using System.Threading.Tasks;

namespace AppService
{
    public interface IDiagnosticsService
    {
        Task<Diagnostics> GetDiagnostics();
    }
}