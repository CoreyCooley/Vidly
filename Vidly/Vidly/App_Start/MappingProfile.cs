using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            //Mapper.Initialize(cfg =>
            //    cfg.CreateMap<Customer, CustomerDto>()
            //    );

            CreateMap<Customer, CustomerDto>();
            
            

            //https://jimmybogard.com/automapper-6-1-0-released/
            //https://github.com/AutoMapper/AutoMapper/wiki/Configuration


            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Customer, CustomerDto>();
            //});

            //IMapper mapper = config.CreateMapper();

            //Mapper.Map(new Customer(), new CustomerDto());
            //Mapper.Map(new CustomerDto(), new Customer());
        }
    }
}