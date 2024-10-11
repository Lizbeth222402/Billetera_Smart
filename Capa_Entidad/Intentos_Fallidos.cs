using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{

  /*CREATE TABLE Intentos_Fallidos(
    Id_Intento INT PRIMARY KEY IDENTITY (1,1),
    Id_Usuario INT,
    Fecha_Intento DATETIME DEFAULT GETDATE(),
    FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);*/
    public class Intentos_Fallidos
    {
        public int Id_Intento { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Fecha_Intento { get; set; }
        public Usuario oUsuario { get; set; }

    }
}
