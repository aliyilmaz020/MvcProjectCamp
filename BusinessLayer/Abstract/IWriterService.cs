﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService : IGenericService<Writer>
    {
        bool TIsLogin(string username, string password);
        string TWriterName(string username);
        int TWriterId(string username);
    }
}
