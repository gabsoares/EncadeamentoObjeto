namespace EX_Encadeamento
{
    internal class Pessoa
    {
        string nome;
        int idade;
        Endereco endereco;

        public Pessoa(string nome, int idade, Endereco endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }

        public override string? ToString()
        {
            return $"Dados da Pessoa\n\n" +
                $"Nome: {nome}\n" +
                $"Idade: {idade} anos\n" +
                $"{endereco.ToString()}";
        }
    }
}
