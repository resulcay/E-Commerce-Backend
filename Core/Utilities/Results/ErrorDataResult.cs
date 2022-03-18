﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {

        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }

        // Bu constructor çok yaygın değildir. --ctor
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        // Bu constructor da çok yaygın değildir. --ctor
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
