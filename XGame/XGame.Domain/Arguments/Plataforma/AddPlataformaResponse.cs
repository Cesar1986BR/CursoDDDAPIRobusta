﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame
{
    public class AddPlataformaResponse
    {
        public Guid Id { get; set; }
        public string  Nome { get; set; }
        public string Message { get { return "Plataforma cadastrada com sucesso."; } }

        public static explicit operator AddPlataformaResponse(Plataforma plataforma)
        {
            return new AddPlataformaResponse
            {
                Id = plataforma.ID,
                Nome = plataforma.Nome
            };

        }
    }
}
