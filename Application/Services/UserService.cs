using Domain.Entities;
using Domain.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService
    {
        private readonly IGenericRepository<User> _userRepository;


        public UserService(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> GetAllUsersAsync() => await _userRepository.GetAllAsync();

        public async Task<User> GetUserByIdAsync(int id) => await _userRepository.GetByIdAsync(id);

        public async Task AddUserAsync(User user) => await _userRepository.AddAsync(user);

        public async Task UpdateUserAsync(User user) => await _userRepository.UpdateAsync(user);

        public async Task DeleteUserAsync(User user) => await _userRepository.DeleteAsync(user);



    }
}
