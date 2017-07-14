using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
    public abstract class BaseEntities
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}
