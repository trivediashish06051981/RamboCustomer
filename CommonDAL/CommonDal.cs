﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceDal;
namespace CommonDAL
{
    public abstract class AbstractDal<AnyType> : IRepository<AnyType>
    {
       
       protected List<AnyType> AnyTypes = new List<AnyType>();

        public virtual void Add(AnyType obj)
        {
            foreach (AnyType temp in AnyTypes)
            {
                if (obj.Equals(temp))
                {
                    return;
                }
            }
            AnyTypes.Add(obj);
        }

        public virtual void Update(AnyType obj)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<AnyType> Search()
        {
            throw new NotImplementedException();
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public virtual void SetUnitWork(IUow uow)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<AnyType> GetData()
        {
            return AnyTypes;
        }


        public virtual AnyType GetData(int Index)
        {
            return AnyTypes[Index];
        }


        public virtual void Cancel(int Index)
        {
            throw new NotImplementedException();
        }
    }
}
