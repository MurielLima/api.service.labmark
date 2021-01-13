﻿using Labmark.Domain.Modules.Account.Infrastructure.Models.Dtos;
using Labmark.Domain.Modules.Solicitation.Infrastructure.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labmark.Domain.Modules.Sample.Infrastructure.Models.Dtos
{
    public class SampleDto
    {
        public string Description { get; set; }
        public int Lot { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime FabricationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Id { get; set; }
        public UserDto Person { get; set; }
        public SolicitationDto Solicitation { get; set; }
    }
}
