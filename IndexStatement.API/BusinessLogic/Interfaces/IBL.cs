﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexStatement.API.BusinessLogic.Interfaces
{
    public interface IBL<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity GetById(int id);
        public int Post(TEntity entity);
        public TEntity Put(int id, TEntity entity);
        public int Delete(int id);
    }
}
