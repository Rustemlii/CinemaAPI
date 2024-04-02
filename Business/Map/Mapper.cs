using AutoMapper;
using DataAcces.Entity;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Map
{
    public class Mapper:Profile
    {
        public Mapper() 
        {
            CreateMap<MovieDTO, Movie>();
            CreateMap<Movie,MovieDTO>();
        }
    }
}
