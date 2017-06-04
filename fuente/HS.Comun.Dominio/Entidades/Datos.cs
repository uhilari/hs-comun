using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Comun.Dominio.Entidades
{
  public class Datos: EntityBase
  {
    public virtual string Codigo { get; set; }
    public virtual string Descripcion { get; set; }
  }
}
