using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace HS.Comun.Dominio
{
  public static class TestExtensions
  {
    public static void SetValor(this EntityBase entidad, string propiedadNoPublica, object valor)
    {
      var propiedad = entidad.GetType().GetProperty(propiedadNoPublica);
      if (propiedad == null)
        throw new InvalidOperationException(string.Format("No existe la propiedad '{0}'", propiedadNoPublica));
      propiedad.SetValue(entidad, valor);
    }
  }
}
