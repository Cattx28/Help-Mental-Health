using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Logs
    {
        public int? id {  get; set; }
        public int? idModerador { get; set; }
        public string acao { get; set; }
        public int? idAlterado { get; set; }
        public string comentario { get; set;}

        public Logs() { }

        public Logs (int id, int? idModerador, string acao, int? idAlterado, string comentario)
        {
            this.id = id;
            this.idModerador = idModerador;
            this.acao = acao;
            this.idAlterado = idAlterado;
            this.comentario = comentario;
        }
    }
}
