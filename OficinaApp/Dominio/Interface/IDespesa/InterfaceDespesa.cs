using OficinaApp.Dominio.Interface.Generics;
using OficinaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Dominio.Interface.IDespesa
{
    public interface InterfaceDespesa : InterfaceGeneric<Despesa>
    {
        Task<IList<Despesa>> ListarDespesasUsuario(string emailUsuario);
        Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnteriores(string emailUsuario);
    }
}
