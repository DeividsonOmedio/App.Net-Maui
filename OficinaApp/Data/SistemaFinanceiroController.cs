using OficinaApp.Dominio.Interface.InterfaceServicos;
using OficinaApp.Dominio.Interface.ISistemaFinanceiro;
using OficinaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data
{
    public class SistemaFinanceiroController
    {
        private readonly InterfaceSistemaFinanceiro _interfaceSistemaFinanceiro;
        private readonly ISistemaFinanceiroServico _iSistemaFinanceiroServico;

        public SistemaFinanceiroController(InterfaceSistemaFinanceiro interfaceSistemaFinanceiro, ISistemaFinanceiroServico sistemaFinanceiroServico)
        {
            _interfaceSistemaFinanceiro = interfaceSistemaFinanceiro;
            _iSistemaFinanceiroServico = sistemaFinanceiroServico;
        }

        public async Task<object> ListarSistemasUsuario(string emailUsuario)
        {
            return await _interfaceSistemaFinanceiro.ListarSistemasUsuario(emailUsuario);
        }

          public async Task<object> AdicionarSistemasFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            await _iSistemaFinanceiroServico.AdicionarSistemaFinanceiroServico(sistemaFinanceiro);
            return Task.FromResult(sistemaFinanceiro);
        }
    }
}
