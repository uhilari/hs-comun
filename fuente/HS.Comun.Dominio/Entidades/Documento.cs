﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HS.Comun.Dominio.Entidades
{
  public class Documento : EntityBase
  {
    public virtual int Serie { get; set; }
    public virtual int Numero { get; set; }
    public virtual DateTime Fecha { get; set; }
    public virtual TipoDocumento Tipo { get; set; }

    public static string NumeroComoCadena(int serie, int numero)
    {
      return serie.Cadena(3) + "-" + numero.Cadena(8);
    }

    public virtual string NumeroComoCadena()
    {
      return Documento.NumeroComoCadena(Serie, Numero);
    }
  }
}
