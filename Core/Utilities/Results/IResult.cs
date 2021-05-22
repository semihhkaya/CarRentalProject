using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; } //True-False
        string Message { get; } //Mesaj içerikleri
    }
}
