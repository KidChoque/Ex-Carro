using carro;

List<Carro> carros = new List<Carro>();

for (var i = 0; i < 2; i++)
{
    
Carro carro = new Carro();
Console.WriteLine($"Qual a marca do carro ?");
carro.Marca = Console.ReadLine();

Console.WriteLine($"Qual a cor do carro ?");
carro.Cor = Console.ReadLine();

carros.Add(

new Carro( carro.Marca, carro.Cor ));
}
    


foreach (var item in carros)
{
    Console.WriteLine($"Marca:{item.Marca},Cor:{item.Cor}");
    
}

