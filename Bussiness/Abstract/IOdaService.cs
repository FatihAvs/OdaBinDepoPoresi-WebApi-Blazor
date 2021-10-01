using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IOdaService
    {
        IDataResult<List<Oda>> GetAll();
        IDataResult<Oda> GetById(int id);
        IResult Add(Oda oda);
        IResult Delete(Oda oda);
        IResult Update(Oda oda);
    }
}
