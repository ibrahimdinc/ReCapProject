using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _colorDal.GetAll() ;
        }

        public Color GetCarsByBrandId(int Id)
        {
            return _colorDal.GetByFilter(Id);
        }

        public Color GetCarsByColorId(int Id)
        {

            return _colorDal.GetByFilter(Id);

        }
    }
}
