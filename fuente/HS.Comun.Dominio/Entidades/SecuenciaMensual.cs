using System;
using System.Collections.Generic;
using System.Text;

namespace HS.Comun.Dominio.Entidades
{
  public class SecuenciaMensual : Secuencia
  {
    public SecuenciaMensual(string llave) : base(llave)
    {
    }

    protected SecuenciaMensual() { }

    protected override string GetLlaveInstancia(DateTime fecha)
    {
      return fecha.ToString("yyyyMM");
    }
  }
}
