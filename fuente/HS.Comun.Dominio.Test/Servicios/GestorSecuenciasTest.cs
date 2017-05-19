using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HS.Comun.Dominio.Servicios
{
  public class GestorSecuenciasTest
  {
    [Fact]
    public void ProbarMock()
    {
      var mock = new GestorSecuenciasMock();
      Assert.NotNull(mock);
    }
  }
}
