﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Domain;

namespace Tracker.Application.Contracts.Persistence
{
    public interface IAddressRepository : IGenericRepository<Address>
    {
    }
}
