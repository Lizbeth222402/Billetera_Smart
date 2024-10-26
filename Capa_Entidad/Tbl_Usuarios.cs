using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*CREATE TABLE Tbl_Usuarios
(
    Id_Usuario INT PRIMARY KEY IDENTITY (1,1),
	Id_Persona INT REFERENCES Tbl_Datos_Personales (Id_Persona),
	Usuario VARCHAR (50) NOT NULL,
	Contraseña VARCHAR (255) NOT NULL,
	Ultima_Sesion DATETIME NULL,
	Ultimo_Cambio_Credenciales DATETIME NULL,
	Intentos_Sesion INT NULL,
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Modificacion DATETIME NOT NULL,
	Id_Estado INT REFERENCES Cls_Estados (Id_Estado)
	);*/
    public class Tbl_Usuarios
    {
		public int Id_Usuario {  get; set; }
		public Tbl_Datos_Personales Id_Persona { get; set; }
		public string Usuario { get; set; }
		public string Contraseña { get; set; }
		public DateTime Ultima_Sesion {  get; set; }
		public DateTime Ultimo_Cambio_Credenciales { get; set; }
		public int Intentos_Sesion { get; set; }
		public DateTime Fecha_Creacion { get; set; }
		public DateTime Fecha_Modificacion	{ get; set; }
		public Cls_Estados Id_Estado { get; set; }
    }
}
