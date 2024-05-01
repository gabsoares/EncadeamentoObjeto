using EX_Encadeamento;

Pessoa p;
Endereco e = new Endereco("14801534", "Araraquara", "SP", "Rodrigo Fernando Grillo", "Av.", "Jardim dos Manacás", 587, "Torre A4 Apt 51");
p = new Pessoa("Gabriel", 23, e);

Console.WriteLine(p.ToString());