using System;
using System.Collections.Generic;
using System.Text;

namespace HS.Comun.Dominio.Entidades
{
  public class SecuenciaDiaria : Secuencia
  {
    public SecuenciaDiaria(string llave) : base(llave)
    {
    }

    protected SecuenciaDiaria() { }

    protected override string GetLlaveInstancia(DateTime fecha)
    {
      return fecha.ToString("yyyyMMdd");
    }
  }
}
