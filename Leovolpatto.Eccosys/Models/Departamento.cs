using System.Collections.Generic;

namespace Leovolpatto.Eccosys.Models
{
    public class Departamento : CategoriaBase
    {
        public List<Categoria> categorias { get; set; }
    }
}