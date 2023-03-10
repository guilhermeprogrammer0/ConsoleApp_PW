using ConsoleApp_PW;
Produto p1 = new Produto(1, 10.90M, "Coca");
Console.WriteLine(p1.getDescricao() + " "+p1.getId());
p1.setValor(11.85M);
p1.setDescricao("Coca 2 Litros");
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());