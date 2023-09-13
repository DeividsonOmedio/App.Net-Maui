using OficinaApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Generics
{
    class RepositorioSistemaFinanceiro
    {
        private SQLiteAsyncConnection _conexaoBD;

        public RepositorioSistemaFinanceiro(SQLiteAsyncConnection conexaoBD)
        {
            _conexaoBD = conexaoBD;
        }
        public async Task<IList<SistemaFinanceiro>> ListaSistemaFinanceiro(string emailUsuario)
        {
            var lista = _conexaoBD
                .Table<SistemaFinanceiro>()
                .ToListAsync();

            return (IList<SistemaFinanceiro>)lista;
        }
        public Task<SistemaFinanceiro> AdicionarSistema(string sistema)
        {

            
            SistemaFinanceiro adiciona = new SistemaFinanceiro();
                adiciona.Nome = sistema;
                adiciona.Ano = DateTime.Now.Year;
                adiciona.Mes = DateTime.Now.Month;
                adiciona.GerarCopiaDespesa = false;
                adiciona.AnoCopia = DateTime.Now.Year;
                var table = _conexaoBD
                    .Table<SistemaFinanceiro>();

                var conferencia = _conexaoBD
                    .Table<SistemaFinanceiro>()
                    .Where(x => x.Nome == sistema)
                    .FirstOrDefaultAsync();
                if (conferencia == default)
                    return conferencia;
                var add = _conexaoBD.InsertOrReplaceAsync(adiciona);
                var adicionado = _conexaoBD
                    .Table<SistemaFinanceiro>()
                    .Where(x => x.Nome == sistema)
                    .FirstOrDefaultAsync();

                return conferencia;
            
            
        }
    }
}
