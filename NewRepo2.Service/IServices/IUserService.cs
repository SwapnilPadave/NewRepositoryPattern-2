using NewRepo2.DTO.UserAddDTO;
using NewRepo2.DTO.UserDTO;
using NewRepo2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<UserModel>> GetAllUsers();
        Task<UserModel> GetUserById(int id);
        Task<UserModel> AddUser(UserAddDTO addDTO);
        Task<UserModel> UpdateUser(UserUpdateDTO updateDTO);
        Task<UserModel> DeleteUser(int id);
    }
}
