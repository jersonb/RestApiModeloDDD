using System.ComponentModel.DataAnnotations;

namespace RestApiModeloDDD.Application.DTOs
{
    public class EmpresaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]

        public string Nome { get; set; }

        public string Site { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de funcionários")]
        public int QuantidadeFuncionarios { get; set; }
    }
}
