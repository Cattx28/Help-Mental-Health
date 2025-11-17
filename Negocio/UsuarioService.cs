using Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioService
    {
        private UsuarioRepository _repository;

        public UsuarioService()
        {
            _repository = new UsuarioRepository();
        }

        public string Update(int? id, string nome, int idade, string email)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var usuario = new Usuario
            {
                id = id,
                nome = nome,
                idade = idade,
                email = email,
            };

            if (id == null)
                return _repository.Insert(usuario);
            else
                return _repository.Update(usuario);

        }

        public string Insert(Usuario usuario)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Insert(usuario);

        }

        public string Inative(int idUsuario) { 

            return _repository.Inativar(idUsuario);
        }
        public string Delete(int idUsuario)
        {
           

            return _repository.Delete(idUsuario);

        }
        public DataTable getAll()
        {
            return _repository.getAll();
        }
        public DataTable GetAllInativos() { 
            return _repository.getAllInativos();   
        }
        public DataTable filterById(int? idUsuario)
        {
            return _repository.filterById(idUsuario);
        }
    }
}
