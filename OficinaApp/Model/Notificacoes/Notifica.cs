using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OficinaApp.Model.Notificacoes
{
    public class Notifica
    {
        public Notifica()
        {
            notificacoes = new List<Notifica>();
        }


        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string mensagem { get; set; }

        [NotMapped]
        public List<Notifica> notificacoes;


    
    public bool ValidarPropriedadeString(string valor, string nomePropriedade)
    {
        if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
        {
            notificacoes.Add(new Notifica
            {
                mensagem = "Campo Obrigatório",
                NomePropriedade = nomePropriedade
            });

            return false;
        }

        return true;
    }


    public bool ValidarPropriedadeInt(int valor, string nomePropriedade)
    {

        if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
        {
            notificacoes.Add(new Notifica
            {
                mensagem = "Campo Obrigatório",
                NomePropriedade = "nomePropriedade"
            });

            return false;
        }

        return true;

    }

}
}