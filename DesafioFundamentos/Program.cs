using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine(" -------------------------------------------- \n" +
                  "|          SISTEMA DE ESTACIONAMENTO         |\n" +
                  " -------------------------------------------- \n" +
                  "Digite o preço cobrado inicialmente para guardar o veículo:");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço cobrado por hora adicional:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Verificar valores das taxas");
    Console.WriteLine("5 - ENCERRAR");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            es.VerificarValores();
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.WriteLine("Pressione qualquer tecla para continuar.");
    Console.ReadLine();
}

Console.WriteLine(" -------------------------------------------- \n" +
                  "|             PROGRAMA ENCERRADO!            |\n" +
                  " -------------------------------------------- \n");