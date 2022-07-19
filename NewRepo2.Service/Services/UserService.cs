using NewRepo2.DTO.UserAddDTO;
using NewRepo2.DTO.UserDTO;
using NewRepo2.Model.Models;
using NewRepo2.Repository.Repositories;
using NewRepo2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserModel> AddUser(UserAddDTO addDTO)
        {
            try
            {
                var user = new UserModel();
                user.Username = addDTO.Username;
                user.Password = addDTO.Password;
                user.EmailAddress = addDTO.EmailAddress;
                user.Surname = addDTO.Surname;
                user.RoleId = addDTO.RoleId;
                await _userRepository.Add(user);
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<UserModel> DeleteUser(int id)
        {
            UserModel user = await GetUserById(id);
            if (user != null)
            {
                await _userRepository.Delete(user);
                return user;
            }
            return user;
        }

        public async Task<IEnumerable<UserModel>> GetAllUsers()
        {
            return await _userRepository.Get();
        }

        public async Task<UserModel> GetUserById(int id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<UserModel> UpdateUser(UserUpdateDTO updateDTO)
        {
            try
            {              

                var _user = await GetUserById(updateDTO.UserId);
                if (_user != null)
                {
                    _user.UserId = updateDTO.UserId;
                    _user.Username = updateDTO.Username.Trim();
                    _user.Password = updateDTO.Password;
                    _user.EmailAddress = updateDTO.EmailAddress;
                    _user.Surname = updateDTO.Surname;
                    _user.RoleId = updateDTO.RoleId;
                    await _userRepository.Update(_user);
                }
                return _user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
