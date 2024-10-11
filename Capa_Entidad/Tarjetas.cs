using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
  /*CREATE TABLE Tarjetas(
    Id_Tarjeta INT PRIMARY KEY IDENTITY (1,1),
    Id_Usuario INT,
    Numero_Tarjeta VARCHAR(20),
    Tipo_Tarjeta VARCHAR(50),
    Fecha_Vencimiento DATE,
    FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);*/

    public class Tarjetas
    {
        public int Id_Tarjeta {  get; set; }
        public int Id_Usuario { get; set; }
        public string Numero_Tarjeta { get; set; }
        public string Tipo_Tarjeta { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public Usuario oUsuario { get; set; }
    }
}
