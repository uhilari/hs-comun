using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Comun.Dominio.Entidades
{
  public class Almacen: EntityBase
  {
    public virtual string Codigo { get; set; }
    public virtual string Nombre { get; set; }
  }
}
