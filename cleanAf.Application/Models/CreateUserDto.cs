using AutoMapper;
using cleanAf.Application.Mapping;
using cleanAf.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanAf.Application.Models
{
    public class CreateUserDto : IMapFrom<User>
    {
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, CreateUserDto>().ReverseMap();
        }
    }
}
