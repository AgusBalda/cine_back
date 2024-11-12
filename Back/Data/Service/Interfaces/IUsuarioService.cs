﻿using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<bool> EliminarUsuario(int id);
        Task<bool> GuardarUsuario(Usuario usuario);
        Task<Usuario>? Login(string nombre, string usuario);
        Task<Usuario>? ObtenerUsuarioPorId(int id);
        Task<List<Usuario>> ObtenerUsuarios();
    }
}
