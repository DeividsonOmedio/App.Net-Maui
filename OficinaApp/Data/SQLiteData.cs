using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using OficinaApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data
{
    public class SQLiteData : IdentityDbContext<ApplicatioUser>
    {
         SQLiteAsyncConnection _conexaoBD;

        public UsuarioData UsuarioDataTable { get; set; }

        public SQLiteData()
        {
            string path = Constants.GetLocalFilePath("usuarios.db3");

            if (_conexaoBD is not null) { return; }
            _conexaoBD = new SQLiteAsyncConnection(path);


            _conexaoBD.CreateTableAsync<Usuario>();
            _conexaoBD.CreateTableAsync<SistemaFinanceiro>();
            _conexaoBD.CreateTableAsync<Categoria>();
            _conexaoBD.CreateTableAsync<Despesa>();


            UsuarioDataTable = new UsuarioData(_conexaoBD);
            

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   }

        
    }
}
