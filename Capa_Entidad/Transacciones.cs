using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*CREATE TABLE tbl_Tansacciones
(
	Id_Transaccion INT PRIMARY KEY IDENTITY (1,1),
	id_Persona INT REFERENCES Tbl_Datos_Personales (Id_Persona),
	Tipo_Transaccion INT REFERENCES Cls_Tipo_Catalogos (Id_Tipo_Catalogo),
	Transaccion INT REFERENCES Cls_Catalogos (Id_Catalogo),
	Monto DECIMAL (10,2) NOT NULL,
	Moneda INT REFERENCES Cls_Catalogos (Id_Catalogo),
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Modificacion DATETIME NOT NULL,
	Id_Edtado INT REFERENCES Cls_Estados (Id_Estado)
	);*/
    public class Transacciones
    {
		public int Id_Transaccion {  get; set; }
		public Tbl_Datos_Personales Id_Persona {  get; set; }
		public Cls_Tipo_Catalogos Tipo_Transaccion { get; set; }
		public Cls_Catalogos Transaccion {  get; set; }
		public decimal Monto { get; set; }
		public Cls_Catalogos Moneda { get; set; }
		public DateTime Fecha_Creacion { get; set; }
		public DateTime Fecha_Modificacion { get; set; }
		public Cls_Estados Id_Estado { get; set; }

    }
}

--holanicol--