﻿using System;
using System.Collections.Generic;
using System.Text;
using CTrlSoft.Core.Api.Models.Dto;
using CTrlSoft.Core.Api.Models;
using Microsoft.AspNetCore.Hosting;

namespace CTrlSoft.Core.Api.Bll
{
    interface IAkun : IBase<Akun>
    {
        JsonResult Get(long id);
        JsonResult GetByKode(string kode);
        JsonResult GetByNama(string name);
        JsonResult GetByFilter(List<DataFilters> filters);

        //JsonResult Save(Akun obj);
        JsonResult Save(Akun obj, ref ValidationError validationError);
        JsonResult Update(Akun obj, ref ValidationError validationError);
    }
}
