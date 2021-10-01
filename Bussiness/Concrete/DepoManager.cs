using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class DepoManager : IDepoService
    {
        IDepoDal _depoDal;


        public DepoManager(IDepoDal depoDal)
        {
            _depoDal = depoDal;
        }
        public IResult Add(Depo depo)
        {
            _depoDal.Add(depo);
            return new SuccessResult(Messages.DepoAdded);
        }

        public IResult Delete(Depo depo)
        {
            _depoDal.Delete(depo);
            return new SuccessResult(Messages.DepoDeleted);
        }

        public IDataResult<List<Depo>> GetAll()
        {
            return new SuccessDataResult<List<Depo>>(_depoDal.GetAll(), Messages.DeposListed);
        }

        public IDataResult<Depo> GetById(int id)
        {
            return new SuccessDataResult<Depo>(_depoDal.Get(p => p.DepoId == id), Messages.DepoListed);
        }

        public IResult Update(Depo depo)
        {
            _depoDal.Update(depo);
            return new SuccessResult(Messages.DepoUpdated);
        }
    }
}
