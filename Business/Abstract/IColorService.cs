﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);  
        IResult Delete(Color color);
        IResult Update(Color color);
        IResult Get(int colorId);
        IDataResult <List<Color>> GetAll();


    }
}
