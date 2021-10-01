using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBinaService
    {
       IDataResult<List<Bina>> GetAll();
       IDataResult<Bina> GetById(int id);
       IResult Add(Bina bina);
       IResult Delete(Bina bina);
       IResult Update(Bina Bina);
    }
}
