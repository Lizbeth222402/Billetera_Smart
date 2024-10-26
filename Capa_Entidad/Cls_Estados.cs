using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*CREATE TABLE Cls_Estados
(
    Id_Estado INT PRIMARY KEY IDENTITY (1,1),
    Estado VARCHAR(80) NOT NULL,
    Fecha_Creacion DATETIME NOT NULL,
    Fecha_Modificacion DATETIME NOT NULL,
    Activo BIT NOT NULL
);
*/
    public class Cls_Estados
    {
        public int Id_Estado { get; set; }
        public string Estado { get; set;}
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public bool Activo {  get; set; }
    }
}
