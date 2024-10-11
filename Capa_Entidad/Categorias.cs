using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
  /*CREATE TABLE Categorias(
    Id_Categoria INT PRIMARY KEY IDENTITY (1,1),
    Categoria VARCHAR(50)
);*/
    public class Categorias
    {
        public int Id_Categoria { get; set; }
        public string Categoria { get; set; }
    }
}
