using OficinaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Dominio.Interface.InterfaceServicos
{
    public interface ISistemaFinanceiroServico
    {
        Task AdicionarSistemaFinanceiroServico(SistemaFinanceiro sistemaFinanceiro);
        Task AtualizarSistemaFinanceiroServico(SistemaFinanceiro sistemaFinanceiro);
    }
}
