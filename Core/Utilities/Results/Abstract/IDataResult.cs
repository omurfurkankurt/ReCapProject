using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    // IResult tan implemente edip Don't repeat yourself kuralına bağlı kaldık
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
