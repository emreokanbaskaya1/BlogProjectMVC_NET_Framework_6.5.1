﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntityFramework
{
    public class EfCategoryDal: GenericRepository<Category>, ICategoryDal
    {
    }
}
