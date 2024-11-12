using Back.Data.Models;

namespace Back.Data.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllAsync();
        Task<Usuario>? GetByIdAsync(int id);
        Task<Usuario>? login(string name, string contrasena);
        Task<bool> SaveAsync(Usuario usuario);
        Task<bool> DeleteAsync(int id);
    }
}
