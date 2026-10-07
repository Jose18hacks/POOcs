//Program.cs
//1 Arquivo por projeto

//COMO INSTANCIO UM OBJETO?

//1. Criar classe
//**1 Classe - 1 Arquivo

//2. Defino Atributos

//public TIPO NOME

//3. Defino Metodos
//public RETOrNO NOME() { }

//Variavel
//TIPO NOME 
using POOFundamentos;

//Instanciar
Carros carroZe = new Carros();

carroZe.Modelo = "Onix";
carroZe.Marca = "Chevrolet";
carroZe.Ano = 2018;
carroZe.ExibirInformacoes();

Console.WriteLine();

Carros carroBB = new();

carroBB.Modelo = "Uno";
carroBB.Marca = "Fiat";
carroBB.Ano = 2006;
carroBB.ExibirInformacoes();

Console.WriteLine();

Pedido ordem1 = new Pedido();

ordem1.Item = "Hamburguer";
ordem1.Quantidade = 3;
ordem1.Preco = 31.32;
ordem1.NomeDoCliente = "João";

Console.WriteLine(ordem1.Item);
Console.WriteLine(ordem1.Quantidade);
Console.WriteLine(ordem1.Preco);
Console.WriteLine(ordem1.NomeDoCliente);
