using Microsoft.EntityFrameworkCore;
using System.Collections;
using webapi.Dto;
using webapi.Models;
using webapi.Utils;

namespace webapi.Repositories
{
    public class UserRepository : Irepository<User, UserData>
    {
        private readonly AppDbContext _db;

        public UserRepository(AppDbContext context)
        {
            _db = context;
        }
        public async Task<RepositoryResponse<User>> Create(UserData postData)
        {
            var result = new RepositoryResponse<User>(StatusCodes.Status500InternalServerError, "Error en la base de datos", false);
            if (_db.Users != null)
            {
                var user = new User(postData);
                await _db.AddAsync(user);
                try
                {
                    await _db.SaveChangesAsync();
                    result = new RepositoryResponse<User>(StatusCodes.Status201Created, user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    result = new RepositoryResponse<User>(StatusCodes.Status400BadRequest, "Error en los datos enviados", false);
                }
            }
            return result;
        }

        private object User(UserData postData)
        {
           Name
        }

        public RepositoryResponse<User> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> Get()
        {
            throw new NotImplementedException();
        }

        public RepositoryResponse<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public RepositoryResponse<User> Update(int id, UserData putData)
        {
            throw new NotImplementedException();
        }
    }
}
