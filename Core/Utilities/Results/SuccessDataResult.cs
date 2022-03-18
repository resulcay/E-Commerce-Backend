using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        // Bu constructor çok yaygın değildir. --ctor
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        // Bu constructor da çok yaygın değildir. --ctor
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
