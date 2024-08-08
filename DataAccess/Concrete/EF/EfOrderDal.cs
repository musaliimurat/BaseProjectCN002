﻿using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class EfOrderDal : BaseEntityRepository<Order, EcommerceCN002Context>, IOrderDal
    {
        public EfOrderDal(EcommerceCN002Context context): base(context)
        {
            
        }
    }
}
