﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    class Usuário
    {
        public class Usuario
        {
            public int Codigo { get; set; }
            public string? Login { get; set; }
            public string? Senha { get; set; }
            public string? ConfirmarSenha { get; set; }
            public DateTime DataCadastro { get; set; }
            public TimeOnly HoraCadastro { get; set; }

            public static
                List<Usuario> ListaUsuarios = new List<Usuario>();
        }
    }
}
