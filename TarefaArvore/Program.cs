// See https://aka.ms/new-console-template for more information

using TarefaArvore.Model;

Init();

void Init()
{
    Arvore arvore = new Arvore();

    Console.WriteLine("Informe o número da opção do array para imprimi-lo \n");

    Console.WriteLine("1 - " + arvore.Exibirlistas(arvore.PrimeiraLista) + "\n");

    Console.WriteLine("2 - " + arvore.Exibirlistas(arvore.SegundaLista) + "\n");
    string opcaoSelecionada = Console.ReadLine();
    Console.WriteLine();

    if ("1".Equals(opcaoSelecionada))
    {
        ImprimirArray(arvore.PrimeiraLista);
    }
    else if ("2".Equals(opcaoSelecionada))
    {
        ImprimirArray(arvore.SegundaLista);
    }
    else
    {
        Console.WriteLine("Opção inválida, somente as opções 1 ou 2 são válidas");
        Console.ReadKey();
        Console.Clear();
        Init();
    }
}

void ImprimirArray(List<int> lista)
{
    Arvore arvore = new Arvore();

    string raiz = arvore.ObtemValorRaiz(lista).ToString();
    string galhosEsquerda = arvore.ImprimirGalhosEsquerda(lista);
    string galhosDireita = arvore.ImprimirGalhosDireita(lista);

    Console.WriteLine("Raiz " + raiz + "\n");
    Console.WriteLine("Galhos da Esquerda " + galhosEsquerda + "\n");
    Console.WriteLine("Galhos da Direita " + galhosDireita + "\n");
    Console.ReadKey();
    Console.Clear();
    Init();
}