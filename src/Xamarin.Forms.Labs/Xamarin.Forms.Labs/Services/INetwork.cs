﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.Labs.Services
{
    public interface INetwork
    {
        Task<bool> IsReachable(string host, TimeSpan timeout);
    }
}
