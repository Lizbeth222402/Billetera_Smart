using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{

    /*CREATE TABLE Recuperacion_Contraseña(
    Id_Recuperacion INT PRIMARY KEY IDENTITY (1,1),
    Id_Usuario INT,
    Token VARCHAR(100),
    Fecha_Solicitud DATETIME DEFAULT GETDATE(),
    Token_Usado BIT DEFAULT 0,
    FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);*/
    public class Recuperacion_Contraseña
    {
        public int Id_Recuperacion { get; set; }
        public int Id_Usuario { get; set; }
        public string Token { get; set; }
        public DateTime Fecha_Solicitud { get; set; }
        public bool Token_Usado { get; set; }
        public Usuario oUsuario { get; set; }

    }
}
