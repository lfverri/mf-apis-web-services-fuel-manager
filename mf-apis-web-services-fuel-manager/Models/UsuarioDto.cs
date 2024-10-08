﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace mf_apis_web_services_fuel_manager.Models
{
    public class UsuarioDto
    {
        public int? Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Password { get; set; }

        public Perfil Perfil { get; set; }

     
    }
}

