using System;
using System.ComponentModel.DataAnnotations;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Empresa : Base
    {
        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }
        [MaxLength(255)]
        public string Site { get; set; }
        [Required]
        public int QuantidadeFuncionarios { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
