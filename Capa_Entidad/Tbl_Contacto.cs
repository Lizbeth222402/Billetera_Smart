using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*--Tabla de contactos
CREATE TABLE Tbl_Contacto
(
	Id_Contacto INT PRIMARY KEY IDENTITY (1,1),
	Id_Persona INT REFERENCES Tbl_Datos_Personales (Id_Persona),
	Tipo_Contacto INT REFERENCES Cls_Catalogos (Id_Catalogo),
	Contacto VARCHAR (10) NOT NULL,
	Codigo_Postal VARCHAR (10) NULL,
	Pais INT REFERENCES Cls_Catalogos (Id_Catalogo),
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Modificacion DATETIME NOT NULL,
	Id_Estado INT REFERENCES Cls_Estados (Id_Estado)
	);*/
    public class Tbl_Contacto
    {
		public int Id_Contacto { get; set; }
		public Tbl_Datos_Personales Id_Persona {  get; set; }
		public Cls_Catalogos Tipo_Contacto { get; set; }
		public string Contacto {  get; set; }
		public string Codigo_Postal { get; set; }
		public Cls_Catalogos Pais {  get; set; }
		public DateTime Fecha_Creacion { get; set; }
		public DateTime Fecha_modificacion { get; set; }
		public Cls_Estados Id_Estado { get; set; }
    }
}
