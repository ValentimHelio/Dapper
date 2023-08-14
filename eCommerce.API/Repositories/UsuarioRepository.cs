using eCommerce.API.IRepositories;
using eCommerce.API.Models;
using System.Collections.Generic;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private static List<Usuario> _db = new List<Usuario>()
        {
            new Usuario(){ Id=1, Nome="Filipe Rodrigues", Email="filipe.rodrigues@gmail.com" },
            new Usuario(){ Id=2, Nome="Marcelo Rodrigues", Email="marcelo.rodrigues@gmail.com"},
            new Usuario(){ Id=3, Nome="Jessica Rodrigues", Email="jessica.rodrigues@gmail.com"}
        };

        public List<Usuario> Get()
        {
            return _db;
        }
       
        public Usuario GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
