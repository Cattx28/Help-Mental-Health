using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ModeradorService
    {
        private ModeradorRepository _repository;

        public ModeradorService()
        {
            _repository = new ModeradorRepository();
        }

        public string Update(int? id, string nome, string email)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var moderador = new Moderador
            {
                id = id,
                nome = nome,
                email = email,
            };

                return _repository.Update(moderador);
        }

        public string UpdateSenha(int? id, string senha)
        {
            var moderador = new Moderador { id = id, senha = senha };

            return _repository.UpdateSenha(moderador);
        }

        public string Insert(string nome, string email, string senha)
        {
            var moderador = new Moderador
            {
                nome = nome,
                email = email,
                senha = senha
            };

            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Insert(moderador);

        }
        public string Delete(int idModerador)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Delete(idModerador);

        }

        public DataTable getAll()
        {
            return _repository.getAll();
        }

        public DataTable getAllMod()
        {
            return _repository.getAllModerador();
        }

        public DataTable getAllAdm() 
        { 
         return _repository.getAllAdm();
        }

        public DataTable filterById(int? idModerador)
        {
            return _repository.filterById(idModerador);
        }

        public string TornarAdm(int idModerador)
        {

            return _repository.TornarAdm(idModerador);
        }

        public bool acessar(string login, string senha)
        {
            bool resultado = _repository.login(login, senha);
            return resultado;
        }

        public bool adm(int adm)
        {
            bool resultado = _repository.adm(adm);
            return resultado;
        }
    }
}
