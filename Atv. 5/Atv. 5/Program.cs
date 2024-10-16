using Atv._5;

//Instanciando a classe Funcionario
Funcionario func1 = new Funcionario { Nome = "José", Idade = 30};

//Chamando o método envelhecer
func1.Envelhecer(10);//Somar a idade que você passou oara a variável mais 10

// Exibindo as informaçãoes do funcionário
Console.WriteLine($"Nome: {func1.Nome}, Idade {func1.Idade}");

Funcionario func2 = new Funcionario { Nome = "Brazz", Idade = 16 };
func2.FontVida(10);
Console.WriteLine($"Nome: {func2.Nome}, Idade {func2.Idade}");

Funcionario func3 = new Funcionario { Nome = "Sabrina", Idade = 20 };
func2.Envelhecer(10);
Console.WriteLine($"Nome: {func3.Nome}, Idade {func3.Idade}");

//Encerra o programa!
Console.WriteLine("Pressione qualquer tecla para sair!");
Console.ReadKey();