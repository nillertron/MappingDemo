using AppService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MappingDemo
{
    public class Pipe
    {
        private readonly IDiagnosticsService _service;
        public Pipe(IDiagnosticsService service)
        {
            this._service = service;
        }
        public async Task DoWork()
        {
          var result = await _service.GetDiagnostics();
        }
    }
}
