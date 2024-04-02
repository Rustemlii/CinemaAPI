using AutoMapper;
using Business.Abstract;
using DataAcces.Context;
using DataAcces.Entity;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieService : BaseService<MovieDTO, Movie, MovieDTO>,IMovie
    {
        public MovieService(IMapper mapper, AppDbContext context) : base(mapper, context)
        {
        }
    }
}
