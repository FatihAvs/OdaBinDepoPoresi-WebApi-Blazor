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
    public class BinaManager : IBinaService
    {
        IBinaDal _binaDal;
       
        public BinaManager(IBinaDal binaDal)
        {
            _binaDal = binaDal;
            
        }
        public IResult Add(Bina bina)
        {
            _binaDal.Add(bina);
            return new SuccessResult(Messages.BinaAdded);

        }
        public IResult Delete(Bina bina)
        {

            _binaDal.Delete(bina);
            return new SuccessResult(Messages.BinaDeleted);
        }

        public IResult Update(Bina bina)
        {
            _binaDal.Update(bina);
            return new SuccessResult(Messages.BinaUpdated);

        }

        public IDataResult<List<Bina>> GetAll()
        {
            return new SuccessDataResult<List<Bina>>(_binaDal.GetAll(), Messages.OdalarListed);
        }

        public IDataResult<Bina> GetById(int id)
        {
            return new SuccessDataResult<Bina>(_binaDal.Get(p => p.BinaId == id), Messages.GetBina);
        }
      
    }
}
