using AutoMapper;
using Domain;
using Repo.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class DiagnosticRepository : IDiagnosticRepository
    {
        private readonly IMapper _mapper;
        private DiagnosticsDto diagnostics;
        public DiagnosticRepository(IMapper mapper)
        {
            _mapper = mapper;
            var proccesInfo = new ProcessorResultsDto { Proccesorinfo = new ProccesorInfoDto[] { new ProccesorInfoDto { info = "bob" } } };
            diagnostics = new DiagnosticsDto();
            diagnostics.Summaries = new SummaryDto[] {proccesInfo };
        }

        public Task<Diagnostics> ConvertDto()
        {
            var mapped = _mapper.Map<Diagnostics>(diagnostics);
            return Task.FromResult(mapped);
        }

    }
}
