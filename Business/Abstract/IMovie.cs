using DataAcces.Entity;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovie:IBaseService<MovieDTO,Movie,MovieDTO>
    {
    }
}
