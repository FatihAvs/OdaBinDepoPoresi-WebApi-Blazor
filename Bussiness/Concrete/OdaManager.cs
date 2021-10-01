using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class OdaManager : IOdaService
    {
        IOdaDal _odaDal;
        public OdaManager(IOdaDal odaDal)
        {
            _odaDal = odaDal;
        }
        public IResult Add(Oda oda)
        {
            _odaDal.Add(oda);
            return new SuccessResult(Messages.OdaAdded);
        }

        public IResult Delete(Oda oda)
        {
            _odaDal.Delete(oda);
            return new SuccessResult(Messages.OdaDeleted);
        }

        public IDataResult<List<Oda>> GetAll()
        {
            return new SuccessDataResult<List<Oda>>(_odaDal.GetAll(), Messages.OdalarListed);
        }

        public IDataResult<Oda> GetById(int id)
        {
            return new SuccessDataResult<Oda>(_odaDal.Get(p => p.OdaId == id), Messages.OdaGetted);
        }

        public IResult Update(Oda oda)
        {
            _odaDal.Update(oda);
            return new SuccessResult(Messages.odaUpdated);
        }
    }
}
