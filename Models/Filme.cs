using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MVC.Model
{
    [Table("Filmes")]
    public class Filme
    {
        

        public Filme()
        {
            this.Clientes = new HashSet<Cliente>(); 
        }
     
       
        public int id { get; set; }
        public string descricao { get; set; }
        public string  sinopse { get; set; }
        public int quantidade { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }

    }
 


}


