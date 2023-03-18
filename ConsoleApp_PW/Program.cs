using ConsoleApp_PW;
using ConsoleApp_PW.Heranca;
/*Console.WriteLine("------------------------------------");
Produto p1 = new Produto(1, 10.90M, "Coca");
Console.WriteLine(p1.getDescricao() + " "+p1.getId());
p1.setValor(11.85M);
p1.setDescricao("Coca 2 Litros");
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());
Endereco endereco = new Endereco(
    "Avenida Alzira dos Santos Petrovick",
    "216",
    "Mariana 1",
    "1484000",
    "Guariba",
    "SP");
/*Cliente c1 = new Cliente(1, "Guilherme", "16996091036",endereco);
Cliente c2 = new Cliente(2, "Matheus", "16998521478", endereco);
Cliente c3 = new Cliente(3, "Émerson", "16995412574", endereco);
Cliente c4 = new Cliente(4, "Daniel", "16997452016", endereco);
Cliente c5 = new Cliente(5, "João", "16996325415", endereco);
Console.WriteLine("------------------------------------");
Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());
c2.getEndereco().setNumero("261");

Endereco endereco2 = new Endereco(
    "Rua Jornalista Costa",
    "100",
    "Nova Guariba",
    "1484000",
    "Guariba",
    "SP");
Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());
c2.setEndereco(endereco2);//Setando o obheto endereco2 para o c2
Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());
Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("O cliente: " + c1.getNome() + ", tem como endereço: " + c1.getEndereco().enderecoCompleto());//Aprensentando um método que mostra o endereco completo*/

Carro gol = new Carro();
gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssentos = 5;
gol.fabricante = "VW";
gol.cintoSeguranca = true;
gol.arCondicionado = false;

Carro saveiro = new Carro();
Carro palio = new Carro();
Carro uno = new Carro();

saveiro.fabricante = "VW";
palio.fabricante = "Fiat";
uno.fabricante = "Fiat";

Bike caloi = new Bike();
Bike speed = new Bike();
speed.temMotor = false;
speed.numeroPortas = 0;

caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;

Console.WriteLine(speed.exibirDados());//speed herdou o método exibir dados da classe pai
Console.WriteLine(gol.exibirDados());//gol herdou o método exibir dados da classe pai


List<Carro> listaCarros = new List<Carro>();
listaCarros.Add(gol);
listaCarros.Add(palio);
listaCarros.Add(uno);
listaCarros.Add(saveiro);
//Console.WriteLine(ListaCarros[0].fabricante);
//ListaCarros.Remove(palio);

foreach(var item in listaCarros)//Percorre cada item de uma lista
{
    Console.WriteLine(item.exibirMarca());
}










