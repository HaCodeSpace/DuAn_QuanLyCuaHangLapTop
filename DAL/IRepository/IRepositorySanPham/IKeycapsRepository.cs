﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.IRepository.IRepositorySanPham
{
    public interface IKeycapsRepository
    {
        Boolean Add(KeyCaps keyCaps);
        int FindId(KeyCaps keyCaps);
    }
}
