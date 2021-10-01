using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IDepoService
    {
        IDataResult<List<Depo>> GetAll();
        IDataResult<Depo> GetById(int id);
        IResult Add(Depo depo);
        IResult Delete(Depo depo);
        IResult Update(Depo depo);
    }
}
