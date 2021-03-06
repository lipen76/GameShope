﻿using GaameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaameStore.Domain.Abstract
{
   public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
