﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameworkk
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapDbContext>, ICustomerDal
    {
    }
}