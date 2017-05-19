using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HS.Comun.Dominio.Servicios
{
  public static class GestorSecuencias
  {
    [ThreadStatic]
    private static IRepository<Entidades.Secuencia> _secuenciaRepository;

    public static IRepository<Entidades.Secuencia> RepositorioSecuencias { get => _secuenciaRepository; set => _secuenciaRepository = value; }

    public static Entidades.InstanciaSecuencia Obtener(string llave, DateTime fecha)
    {
      llave.NoEsNull(nameof(llave));

      var secuencia = _secuenciaRepository.BuscarUno(c => c.Llave.Equals(llave));
      return secuencia[fecha];
    }
  }
}
