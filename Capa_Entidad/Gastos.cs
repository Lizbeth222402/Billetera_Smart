using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
  /*CREATE TABLE Gastos(
    Id_Gasto INT PRIMARY KEY IDENTITY (1,1),
    Id_Usuario INT,
    Monto DECIMAL(10,2),
    Id_Moneda INT,
    Forma_Pago VARCHAR(50),
    Fecha DATE,
    Id_Categoria INT,
    Nota VARCHAR(100),
    FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario),
    FOREIGN KEY(Id_Categoria) REFERENCES Categorias(Id_Categoria),
    FOREIGN KEY(Id_Moneda) REFERENCES Monedas(Id_Moneda)
  );*/
    public class Gastos
    {
        public int Id_Gasto {  get; set; }
        public int Id_Usuario { get; set; }
        public decimal Monto { get; set; }
        public int Id_Moneda { get; set; }
        public string Forma_Pago { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Categoria { get; set; }
        public string Nota { get; set; }
        public Usuario oUsuario { get; set; }
        public Categorias oCategorias { get; set; }
        public Monedas oMonedas { get; set; }

    }
}
