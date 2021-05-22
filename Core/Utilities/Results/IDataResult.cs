using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{//IResult implemantastonu ile succes ve message'ı alıyoruz.
 //Hme success hem message hem de veri dönüdren işlemler için bu result kullanılır. IResult void işlemler içindir.(ör.Add)
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
