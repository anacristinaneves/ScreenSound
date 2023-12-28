//Screen Sound
string  mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<string> listaDeBandas = new List<string>{"Iron Maiden", "AC/DC"}; 

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10, 9, 8});
bandasRegistradas.Add("Iron Maiden", new List<int>());

    void ExibirLogo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");

    Console.WriteLine(mensagemDeBoasVindas);
}
    void ExibirOpçoesDoMenu()
{    
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");


    string opçaoEscolhida = Console.ReadLine()!;
    int opçaoEscolhidaNumerica = int.Parse(opçaoEscolhida);


   switch (opçaoEscolhidaNumerica)
   {
        case 1: RegistrarBanda();
    break;
        case 2: MostrarBandasRegistradas();
    break;
        case 3: AvaliarUmaBanda();
    break;
        case 4: MediaDaBanda();
    break;
        case -1: Console.WriteLine("Tchau tchau :) * ");
    break;
    default: Console.WriteLine("Opção Inválida");
    break;
   }
}
    void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep (2000);
    Console.Clear();
    ExibirOpçoesDoMenu();
}
    void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas\n");

    //#Método FOR 
    // for(int i =0; i < listaDeBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDeBandas[i]}");
    // }

    //#Método FOREACH
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu();
}
    void AvaliarUmaBanda()
{
     //Digitar banda que deseja avaliar.
    Console.Clear();
    ExibirLogo();
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!.Trim();
 
     //Buscar a banda dentro do dicionário.
     if (bandasRegistradas.ContainsKey(nomeDaBanda))
     {
            Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece? ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\nA nota foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpçoesDoMenu();
     }
      else 
     {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçoesDoMenu();
     }

    //Atribuir uma nota (caso exista), senão volta ao menu principal
}
    void MediaDaBanda()
{
        Console.Clear();
        Console.WriteLine("Média da Banda\n");
        //Perguntar qual banca para ver a média
        Console.Write("Digite o nome da banca que gostaria de ver a média das avaliações: ");
        string nomeDaBanda = Console.ReadLine()!.Trim();
        //Se a banda está cadastrada
        if(bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            //Realizar o calculo da média
            List<int> notasDaBanda  = bandasRegistradas [nomeDaBanda];
            Console.WriteLine($"\nA media da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpçoesDoMenu();
        }else
        {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçoesDoMenu();
        }

    }

ExibirLogo();
ExibirOpçoesDoMenu();