using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MVC.Model
{
    public class Cliente
    {
        internal object[] filmeId;

        public int id { get; set; }
        public string nome { get; set; }
        public int filmeeId { get; set; }
        public virtual Filme filme { get; set; }
        public virtual string nomeFilme { get { return filme.descricao + "-" + filme.sinopse; } }
    }
}
