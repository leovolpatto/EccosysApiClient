using System.Collections.Generic;

namespace Leovolpatto.Eccosys.Models
{
    public class Categoria : CategoriaBase
    {
        public int idDepartamento { get; set; }
        public List<SubCategoria> subcategorias { get; set; }
    }
}