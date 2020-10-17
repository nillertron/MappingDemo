using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Dto
{
    public class DtoMapProfile:Profile
    {
        public DtoMapProfile()
        {
            CreateMap<DiagnosticsDto, Diagnostics>();
            CreateMap<SummaryDto, Summary>().IncludeAllDerived();
            CreateMap<ProcessorResultsDto, ProcessorResults>();
            CreateMap<DiagnosticsDto, Diagnostics>();
            CreateMap<ProccesorInfoDto, ProccesorInfo>();


        }
    }
}
