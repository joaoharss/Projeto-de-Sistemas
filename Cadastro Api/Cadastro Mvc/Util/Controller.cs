﻿using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Mvc.Util
{
    /// <summary>
    /// Classe criada para auxiliar o retorno do JSON devido à referência cíclica da classe Endereço na classe Pessoa.
    /// </summary>
    public static class Controller
    {
        public static class JsonOptionsUtil
        {
            private static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true 
            };

            public static JsonResult Create<T>(T data)
            {
                return new JsonResult(data, DefaultOptions);
            }
        }
    }
}
