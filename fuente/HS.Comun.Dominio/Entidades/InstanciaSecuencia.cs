using System;
using System.Collections.Generic;
using System.Text;

namespace HS.Comun.Dominio.Entidades
{
  public class InstanciaSecuencia: EntityBase
  {
    internal protected InstanciaSecuencia()
    {
      Valor = 0;
    }

    public virtual string Llave { get; internal protected set; }
    public virtual int Valor { get; protected set; }
    public virtual Secuencia Definicion { get; internal protected set; }


    public virtual string Cadena()
    {
      return Definicion.Prefijo + Valor.Cadena(Definicion.Longitud - Definicion.Prefijo.Length);
    }

    public virtual InstanciaSecuencia Siguiente()
    {
      Valor += 1;
      return this;
    }
  }
}
