using Atv._06;

Gato gato = new Gato
{
    Especie = "Persa"
};
Console.WriteLine($"A espécie do meu gato é: {gato.Especie}");
gato.EmitirSom();

Porco porco = new Porco
{
    Especie = "Mini Pig"
};
Console.WriteLine($"A espécie do meu porco é: {porco.Especie}");
porco.EmitirSom();

Capivara capi = new Capivara
{
    Especie = "Capi"
};
Console.WriteLine($"A espécie da minha capivara é: {capi.Especie}");
capi.EmitirSom();