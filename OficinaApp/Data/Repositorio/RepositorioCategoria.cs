using OficinaApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Generics
{
    class RepositorioCategoria
    {
        private SQLiteAsyncConnection _conexaoBD;
        public RepositorioCategoria(SQLiteAsyncConnection conexaoBD)
        {
            _conexaoBD = conexaoBD;
        }
        
        public async Task<IList<Categoria>> ListarCategoriaUsuario(string emailUuario)
        {
 
            var lista = _conexaoBD
                .Table<Categoria>()
                .ToListAsync();

            return (IList<Categoria>)lista;
        }
        public Task<Categoria> AdicionarCategoria(string categoria)
        {
            Categoria adiciona = new Categoria();
            adiciona.Nome = categoria;
            adiciona.IdSistema = 1;
            var table = _conexaoBD
                .Table<Categoria>();

            var conferencia =  _conexaoBD
                .Table<Categoria>()
                .Where(x => x.Nome == categoria)
                .FirstOrDefaultAsync();
            if (conferencia == default)
                return conferencia;
            var add = _conexaoBD.InsertOrReplaceAsync(adiciona);
            var adicionado = _conexaoBD
                .Table<Categoria>()
                .Where(x => x.Nome == categoria)
                .FirstOrDefaultAsync();

            return adicionado;
                

        }
    }
}
