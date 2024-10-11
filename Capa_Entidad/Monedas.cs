using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{

  /*CREATE TABLE Monedas(
    Id_Moneda INT PRIMARY KEY IDENTITY (1,1),
    Nombre_Moneda VARCHAR(50),
    Simbolo VARCHAR(10)
);*/
    public class Monedas
    {
        public int Id_Moneda { get; set; }
        public string Nombre_Moneda { get; set; }
        public string Simbolo {  get; set; }
    }
}
