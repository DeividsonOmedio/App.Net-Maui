using OficinaApp.Dominio.Interface.IDespesa;
using OficinaApp.Dominio.Interface.InterfaceServicos;
using OficinaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Dominio.Servicos
{
    class DespesaServico : IDespesaServico
    {
        private readonly InterfaceDespesa _interfaceDespesa;

        public DespesaServico(InterfaceDespesa interfaceDespesa)
        {
            _interfaceDespesa = interfaceDespesa;
        }

        public async Task AdicionarDespesa(Despesa despesa)
        {
            var data = DateTime.UtcNow;
            despesa.DataCadastro = data;
            despesa.Ano = data.Year;
            despesa.Mes = data.Month;

            var valido = despesa.ValidarPropriedadeString(despesa.Nome, "Nome");
            if (valido)
                await _interfaceDespesa.Add(despesa);
        }

        public async Task AtualizarDespesa(Despesa despesa)
        {
            var data = DateTime.UtcNow;
            despesa.DataAlteracao = data;

            if(despesa.Pago)
                despesa.DataPagamento = data;

            var valido = despesa.ValidarPropriedadeString(despesa.Nome, "Nome");
                if (valido)
                await _interfaceDespesa.Update(despesa);
        }

        public async Task<object> CarregaGraficos(string emailUsuario)
        {
            var despesaUsuario = await _interfaceDespesa.ListarDespesasUsuario(emailUsuario);
            var despesasAnterior = await _interfaceDespesa.ListarDespesasUsuarioNaoPagasMesesAnteriores(emailUsuario);

            var despesas_naoPagasMesesAnteriores = despesasAnterior
                .ToList().Sum(x => x.Valor);

            var despesa_pagas = despesaUsuario.Where(d => d.Pago && d.TipoDespesa == Model.Enum.EnumTipoDespesa.Contas)
                .Sum(x => x.Valor);

            var despesa_pendentes = despesaUsuario.Where(d => !d.Pago && d.TipoDespesa == Model.Enum.EnumTipoDespesa.Contas)
                .Sum(x => x.Valor);

            var investimentos = despesaUsuario.Where(d => d.TipoDespesa == Model.Enum.EnumTipoDespesa.Investimento)
                .Sum(x => x.Valor);

            return new
            {
                sucesso = "OK",
                despesas_pagas = despesa_pagas,
                despesa_pendentes = despesa_pendentes,
                despesas_naoPagasMesesAnteriores = despesas_naoPagasMesesAnteriores,
                investimentos = investimentos
            };
        }
    }
}
