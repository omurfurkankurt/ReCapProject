﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManger : IColorService
    {
        IColorDal _colorDal;
        public ColorManger(IColorDal colorDal)
        {
            _colorDal = colorDal;   
        }
        
      
    }
}

