﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IEntityService<T> where T : class 
    {
        ICollection<T> Get();
        T Post(T t);
        T Put(T t);
        bool Delete(int id);
    }
}
