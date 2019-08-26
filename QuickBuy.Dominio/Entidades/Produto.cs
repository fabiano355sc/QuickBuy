namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (Preco < 1)
                AdicionarCritica("Critica - Preço deve ser maior que zero!");
        }
    }
}
