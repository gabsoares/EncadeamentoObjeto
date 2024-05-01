namespace EX_Encadeamento
{
    internal class Endereco
    {
        string cep;
        string localidade;
        string uf;
        string logradouro;
        string tipo_logradouro;
        string bairro;
        int numero;
        string complemento;

        public Endereco(string cep, string localidade, string uf, string logradouro, string tipo_logradouro, string bairro, int numero, string complemento)
        {
            this.cep = cep;
            this.localidade = localidade;
            this.uf = uf;
            this.logradouro = logradouro;
            this.tipo_logradouro = tipo_logradouro;
            this.bairro = bairro;
            this.numero = numero;
            this.complemento = complemento;
        }

        public override string? ToString()
        {
            if (complemento != "")
            {
                return $"Endereco\nLogradouro: {tipo_logradouro} {logradouro}\n" +
                        $"Bairro: {bairro}\n" +
                        $"Numero: {numero}\n" +
                        $"Complemento: {complemento}\n" +
                        $"CEP: {cep}\n" +
                        $"Cidade: {localidade}-{uf}\n";
            }
            else
            {
                return $"\nEndereco\n\nLogradouro: {tipo_logradouro} {logradouro}\n" +
                        $"Bairro: {bairro}\n" +
                        $"Numero: {numero}\n" +
                        $"CEP: {cep}\n" +
                        $"Cidade: {localidade}-{uf}\n";
            }
        }
    }
}
