﻿using Microsoft.Extensions.Options;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApi.PetClient
{
    public class PetBaseClient
    {
        public PetBaseClient(IOptionsSnapshot<PetClientOptions> options)
        {

        }
    }
}
