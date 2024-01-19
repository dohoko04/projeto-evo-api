using System.ComponentModel.DataAnnotations;

namespace EVO.InputModels
{
    public class DepartamentoInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(3, ErrorMessage = "A Sigla não pode conter mais de 3 ")]
        public string Sigla { get; set; }
    }
}
