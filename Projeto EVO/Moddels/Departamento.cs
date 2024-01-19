﻿using EVO.Models;

namespace Projeto_EVO.Moddels
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sigla { get; set; }
        public IEnumerable<Funcionario> Funcionarios { get; set; }

    }
}
