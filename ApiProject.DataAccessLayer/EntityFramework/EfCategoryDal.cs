﻿using ApiProject.DataAccessLayer.Abstract;
using ApiProject.DataAccessLayer.Context;
using ApiProject.DataAccessLayer.Repositories;
using ApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(ApiContext context) : base(context)
        {
        }

        public int CategoryCount()
        {
            var context = new ApiContext();
            var values = context.Categories.Count();
            return values;
        }
    }
}
