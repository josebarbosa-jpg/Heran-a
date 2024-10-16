using Atv._07;

ContaCorrente conta1 = new ContaCorrente
{
    Banco = "C6Bank",
    Agencia = 001,
    Conta = "Corrente",
    Saldo = 5000,
    limite = 10000
};
Console.WriteLine($"Seu banco é: {conta1.Banco}, sua agencia é: {conta1.Agencia}, sua conta é: {conta1.Conta}, seu saldo é de: {conta1.Saldo}, seu limite é de: {conta1.limite}.");

ContaCorrente conta2 = new ContaCorrente
{
    Banco = "Do Brasil",
    Agencia = 002,
    Conta = "Corrente",
    Saldo = 10000,
    limite = 150000
    };
Console.WriteLine($"Seu banco é: {conta2.Banco}, sua agencia é: {conta2.Agencia}, sua conta é: {conta2.Conta}, seu saldo é de: {conta2.Saldo}, seu limite é de: {conta2.limite}.");

ContaCorrente conta3 = new ContaCorrente
{
    Banco = "Santander",
    Agencia = 003,
    Conta = "Corrente",
    Saldo = 15000,
    limite = 20000
};
Console.WriteLine($"Seu banco é: {conta3.Banco}, sua agencia é: {conta3.Agencia}, sua conta é: {conta3.Conta}, seu saldo é de: {conta3.Saldo}, seu limite é de: {conta3.limite}.");
Console.ReadKey();