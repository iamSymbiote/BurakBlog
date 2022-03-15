﻿using BurakBlog.Shared.Utilities.Results.ComplexTypes;

namespace BurakBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get;}
        public string Message { get;}
        public Exception Exception { get;}
    }
}
