using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Dto
{
    public class ProcessorResultsDto:SummaryDto
    {
        public ProccesorInfoDto[] Proccesorinfo { get; set; }
    }
}
