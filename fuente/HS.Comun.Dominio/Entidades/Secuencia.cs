using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HS.Comun.Dominio.Entidades
{
  public abstract class Secuencia : EntityBase
  {
    public Secuencia(string llave): this()
    {
      Llave = llave;
      Prefijo = "";
    }

    protected Secuencia() { Instancias = new Lista<InstanciaSecuencia>(); }

    public virtual string Llave { get; protected set; }
    public virtual int Longitud { get; set; }
    public virtual string Prefijo { get; set; }
    public virtual ILista<InstanciaSecuencia> Instancias { get; protected set; }

    protected abstract string GetLlaveInstancia(DateTime fecha);

    public virtual InstanciaSecuencia this[DateTime fecha]
    {
      get
      {
        var llaveInstancia = GetLlaveInstancia(fecha);
        var instancia = Instancias.Buscar(c => c.Llave == llaveInstancia);
        if (instancia == null)
        {
          instancia = new InstanciaSecuencia
          {
            Llave = llaveInstancia,
            Definicion = this
          };
          Instancias.Add(instancia);
        }
        return instancia;
      }
    }
  }
}
