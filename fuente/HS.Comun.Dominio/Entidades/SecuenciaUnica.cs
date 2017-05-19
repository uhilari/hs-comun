using System;
using System.Collections.Generic;
using System.Text;

namespace HS.Comun.Dominio.Entidades
{
  public class SecuenciaUnica : Secuencia
  {
    public SecuenciaUnica(string llave) : base(llave) { }

    protected SecuenciaUnica() { }

    protected override string GetLlaveInstancia(DateTime fecha)
    {
      return "UNICO";
    }
  }
}
