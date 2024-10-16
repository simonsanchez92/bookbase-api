﻿using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Application.Services
{
    public class UserService : BaseService<User, UserResponseDto, UserResponseDto, CreateUserDto, UpdateUserDto>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordEncryptionService _passwordEncryptionService;


        public UserService(IUserRepository userRepository, IPasswordEncryptionService passwordEncryptionService, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _passwordEncryptionService = passwordEncryptionService;
        }


        public async Task<User?> GetOne(Expression<Func<User, bool>> predicate)
        {
            return await _userRepository.GetOne(predicate);
        }


        public override async Task<UserResponseDto> Create(CreateUserDto body)
        {

            var emailExists = await _userRepository.GetOne(u => u.Email == body.Email);

            if (emailExists != null)
            {
                throw new BadRequestException($"Email is already taken: {body.Email}")
                {
                    ErrorCode = "006"
                };
            }

            var usernameExists = await _userRepository.GetOne(u => u.Username == body.Username);


            if (usernameExists != null)
            {
                throw new BadRequestException($"Username is already taken: {body.Email}")
                {
                    ErrorCode = "006"
                };
            }

            body.Password = _passwordEncryptionService.HashPassword(body.Password);

            return await base.Create(body);
        }

        public override async Task<UserResponseDto> Update(int userId, UpdateUserDto body)
        {

            body.Password = _passwordEncryptionService.HashPassword(body.Password);
            return await base.Update(userId, body);
        }

        //public async Task<bool> Delete(int userId)
        //{
        //    var user = await _userRepository.GetOne(userId);

        //    if (user == null)
        //    {
        //        return false;
        //    }

        //    user.Deleted = true;
        //    await _userRepository.Update(user);

        //    return true;
        //}

        //Task<GenericResponseDto> IBaseService<User, UserResponseDto, UserResponseDto, CreateUserDto, UpdateUserDto>.Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
