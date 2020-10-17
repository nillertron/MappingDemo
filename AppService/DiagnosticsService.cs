using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService
{
    public class DiagnosticsService : IDiagnosticsService
    {
        private readonly IDiagnosticRepository _diagnosticRepository;
        public DiagnosticsService(IDiagnosticRepository _diagnosticRepository)
        {
            this._diagnosticRepository = _diagnosticRepository;
        }
        public async Task<Diagnostics> GetDiagnostics()
        {
            return await _diagnosticRepository.ConvertDto();
        }
    }
}
