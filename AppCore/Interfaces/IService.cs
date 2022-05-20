﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public interface IService<T>
    {
        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        List<T> GetAll();
    }
}