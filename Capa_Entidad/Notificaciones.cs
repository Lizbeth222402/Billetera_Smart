using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
  /*CREATE TABLE Notificaciones(
    Id_Notificacion INT PRIMARY KEY IDENTITY (1,1),
    Id_Usuario INT,
    Mensaje VARCHAR(250),
    Fecha_Envio DATETIME DEFAULT GETDATE(),
    FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);*/
    public class Notificaciones
    {
        public int Id_Notificacion {  get; set; }
        public int Id_Usuario { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha_Envio { get; set; }
        public Usuario oUsuario { get; set; }
    }
}
