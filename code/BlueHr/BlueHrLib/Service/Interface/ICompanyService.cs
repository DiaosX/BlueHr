﻿using BlueHrLib.Data;
using BlueHrLib.Data.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueHrLib.Service.Interface
{
    public interface ICompanyService
    {
        IQueryable<Company> Search(CompanySearchModel searchModel);
    }
}
