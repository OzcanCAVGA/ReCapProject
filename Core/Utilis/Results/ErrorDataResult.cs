﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilis.Results
{
    public class ErrorDataResult<T> : DataResult<T> where T : class
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }

        public ErrorDataResult(T data, bool success, string message) : base(data, success, message)
        {
        }

        public ErrorDataResult(T data, bool success) : base(data, success)
        {
        }
    }
}
