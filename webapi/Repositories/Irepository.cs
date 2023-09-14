using System.Collections;
using webapi.Models;
using webapi.Utils;

namespace webapi.Repositories
{
    public interface Irepository<T, U>
    {
        Task<ICollection<T>> Get();
        Task<RepositoryResponse<T>> GetById(int id);
        Task<RepositoryResponse<T>> Create(U postData);
        Task<RepositoryResponse<T>> Update(int id, U putData);
        Task<RepositoryResponse<T>> Delete(int id);
    }
}
