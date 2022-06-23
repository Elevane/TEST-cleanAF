using AutoMapper;
using cleanAf.Application.Models;
using cleanAf.Domain.Entitites;
using cleanAf.infrastructure.Repositories;
using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanAf.Application.Services
{
    public class UserService
    {
        private readonly UserRepository _repo;
        private readonly IMapper _mapper;

        public UserService(UserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Result<List<UserDto>>> GetAll(){

            ///logique métier, retour d'erreurs, vérifications
            List<User> users=  await _repo.getAll();
            if (users == null)
                return Result.Failure<List<UserDto>>("Could not fetch entitites");
            List<UserDto> mappedUsers = _mapper.Map<List<UserDto>>(users);
            if (mappedUsers == null)
                return Result.Failure<List<UserDto>>("Could not map entitites into dtos");
            return Result.Success<List<UserDto>>(mappedUsers);
        }

        public async Task<Result> Create(CreateUserDto toCreate)
        {

            
            User mappedUser = _mapper.Map<User>(toCreate);
            if (mappedUser == null)
                return Result.Failure<UserDto>("Could not map dto into entity");
            await _repo.Add(mappedUser);
           
            return Result.Success();
        }
    }
}
