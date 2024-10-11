using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{

  /*CREATE TABLE Usuarios(
    Id_Usuario INT PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(50),
    Correo VARCHAR(100),
    Contraseña VARCHAR(50),
    Foto_Perfil VARCHAR(100),
    Cuenta_Bloqueada BIT DEFAULT 0,
    Fecha_Registro DATETIME DEFAULT GETDATE()
);*/
    public class Usuario
    {
        public int Id_Usuario {  get; set; }
        public string Nombre { get; set; }
        public string  Correo { get; set; }
        public string Contraseña { get; set; }
        public string Foto_Perfil { get; set; }
        public bool Cuenta_Bloquada { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
