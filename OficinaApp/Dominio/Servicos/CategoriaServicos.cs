using OficinaApp.Dominio.Interface.ICategoria;
using OficinaApp.Dominio.Interface.InterfaceServicos;
using OficinaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Dominio.Servicos
{
    class CategoriaServicos : ICategoriaServico
    {
        private InterfaceCategoria _interfaceCategoria;

        public CategoriaServicos(InterfaceCategoria interfaceCategoria)
        {
            _interfaceCategoria = interfaceCategoria;
        }

        public async Task AdicionarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidarPropriedadeString(categoria.Nome, "Nome");

            if (valido)
                await _interfaceCategoria.Add(categoria);
        }

        public async Task AtualizarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidarPropriedadeString(categoria.Nome, "Nome");

            if (valido)
                await _interfaceCategoria.Update(categoria);
        }
    }
}
