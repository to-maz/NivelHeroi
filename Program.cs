string heroi = "CachorroLouco";
float xpHeroi = 15000;

if (xpHeroi < 1000)
{
    Console.WriteLine("O herói: " + heroi + " esta no nivel: Ferro");
}
else if (xpHeroi > 1000 && xpHeroi <= 2000)
{
    Console.WriteLine("O herói: " + heroi + " esta no nivel: Bronze");
}
else if (xpHeroi > 2000 && xpHeroi <= 5000)
{
    Console.WriteLine("O herói: " + heroi + " esta no nivel: Prata");
}
else if (xpHeroi > 5000 && xpHeroi <= 7000)
{
    Console.WriteLine("O herói: " + heroi + " esta no nivel: Ouro");
}
else if (xpHeroi > 7000 && xpHeroi <= 8000)
{
    Console.WriteLine("O herói: " + heroi + " esta no nivel: Platina");
}
else if (xpHeroi > 8000 && xpHeroi <= 9000)
{
    Console.WriteLine("O herói: " + heroi + " esta no nivel: Ascendente");
}
else if (xpHeroi > 9000 && xpHeroi <= 10000)
{
    Console.WriteLine("O herói: " + heroi + " esta no nivel: Imortal");
}
else if (xpHeroi > 10000)
{
    Console.WriteLine("O herói: " + heroi + " esta no nivel: Radiante");
}
else
{
    Console.WriteLine("Herói inválido");
}
