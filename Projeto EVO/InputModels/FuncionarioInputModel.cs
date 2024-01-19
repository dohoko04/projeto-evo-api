namespace EVO.InputModels
{
    public class FuncionarioInputModel
    {
        public string Nome { get; set; }
        public IFormFile? Foto { get; set; }
        public string Rg { get; set; }
        public int DepartamentoId { get; set; }
    }
}
