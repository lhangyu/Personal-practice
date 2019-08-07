using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;

namespace Personalpractice
{
    public class DataContext : FrameworkContext
    {
        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {
        }

    }
}
