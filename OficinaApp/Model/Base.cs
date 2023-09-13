using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OficinaApp.Model.Notificacoes;

namespace OficinaApp.Model
{
    
        public class Base : Notifica
        {
            [Display(Name = "Código")]
            public int Id { get; set; }

            [Display(Name = "Nome")]
            public string Nome { get; set; }
        }
    }


