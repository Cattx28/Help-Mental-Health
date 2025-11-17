using Dados;
using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LogsService
    {
        private LogsRepository _repository;

        public LogsService(){
            _repository = new LogsRepository();
            }

        public string CriarLog(int? id, int idModerador, string acao, int? idAlterado, string comentario)
        {
            var log = new Logs
            {
                id = id,
                idModerador = idModerador,
                acao = acao,
                idAlterado = idAlterado,
                comentario = comentario
            };

            return _repository.CriarLog(log);
        }

        public DataTable getAll()
        {
            return _repository.getAll();
        }
    }
}
