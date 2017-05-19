using System;
using System.Collections.Generic;
using System.Text;

namespace HS.Comun.Dominio.Entidades
{
  public class SecuenciaAnual : Secuencia
  {
    public SecuenciaAnual(string llave) : base(llave)
    {
    }

    protected SecuenciaAnual() { }

    protected override string GetLlaveInstancia(DateTime fecha)
    {
      return fecha.ToString("yyyy");
    }
  }
}
