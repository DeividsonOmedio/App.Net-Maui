using OficinaApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data
{
    public class SQLiteData
    {
         SQLiteAsyncConnection _conexaoBD;

        public UsuarioData UsuarioDataTable { get; set; }

        public SQLiteData()
        {
            string path = Constants.GetLocalFilePath("usuarios.db3");

            if (_conexaoBD is not null) { return; }
            _conexaoBD = new SQLiteAsyncConnection(path);
            _conexaoBD.CreateTableAsync<Usuario>();

            UsuarioDataTable = new UsuarioData(_conexaoBD);
            

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   }
    }
}
