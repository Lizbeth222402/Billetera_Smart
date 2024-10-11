using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
  /*CREATE TABLE Ingresos(
    Id_Ingreso INT PRIMARY KEY IDENTITY (1,1),
    Id_Usuario INT,
    Monto DECIMAL(10,2),
    Id_Moneda INT,
    Forma_Pago VARCHAR(50),
    Fecha DATE,
    FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario),
    FOREIGN KEY(Id_Moneda) REFERENCES Monedas(Id_Moneda)
);*/
    public class Ingresos
    {
        public int Id_Ingreso {  get; set; }
        public int Id_Usuario { get; set; }
        public decimal Monto { get; set; }
        public string Forma_Pago { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario oUsuario { get; set; }
        public Monedas oMoneda { get; set; }
    }
}
