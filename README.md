Documentação Técnica - DataStructuresApp
Esta documentação descreve a estrutura e o funcionamento do aplicativo DataStructuresApp, que é um projeto desenvolvido em C# para manipulação de estruturas de dados como vetores, matrizes, listas, filas, pilhas, e execução de algoritmos de pesquisa. O objetivo deste projeto é fornecer um menu interativo onde o usuário pode escolher entre diferentes operações para manipular essas estruturas de dados.

Estrutura do Projeto
O projeto está organizado em dois principais namespaces:

DataStructures: Contém as implementações de diferentes estruturas de dados, como Vetor, Matriz, Lista, Fila e Pilha.

Algorithms: Contém os algoritmos de busca (como busca sequencial e busca binária) que podem ser aplicados nas estruturas de dados.

O código é modularizado, e cada estrutura de dados está em um arquivo separado dentro do diretório DataStructures. O diretório Algorithms contém os algoritmos de pesquisa, enquanto o arquivo Program.cs é responsável pela interação com o usuário e execução do menu principal.

Estrutura de Diretórios
nginx
Copiar
Editar
DataStructuresApp
├── DataStructures
│    ├── Vetor.cs
│    ├── Matriz.cs
│    ├── Lista.cs
│    ├── Fila.cs
│    └── Pilha.cs
├── Algorithms
│    └── Pesquisa.cs
└── Program.cs
Descrição do Código
1. Namespaces Usados
System: Usado para manipulação de entrada e saída de dados, manipulação de console e exceções.

DataStructures: Namespace que contém as classes para as estruturas de dados como Vetor, Matriz, Lista, Fila, e Pilha.

Algorithms: Namespace que contém a classe Pesquisa que implementa os algoritmos de busca (sequencial e binária).

System.Collections.Generic: Usado para trabalhar com coleções genéricas, como List<T>, que é usada na pesquisa.

2. Main Loop e Menu Principal
A função Main apresenta um menu principal com opções para o usuário escolher a operação que deseja realizar. Este menu é um loop contínuo até que o usuário selecione a opção de saída (0). Para cada opção selecionada, o sistema chama a função correspondente que gerencia as operações das estruturas de dados.

csharp
Copiar
Editar
while (true)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Vetores");
    Console.WriteLine("2. Matrizes");
    Console.WriteLine("3. Listas");
    Console.WriteLine("4. Filas");
    Console.WriteLine("5. Pilhas");
    Console.WriteLine("6. Algoritmos de Pesquisa");
    Console.WriteLine("0. Sair");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            GerenciarVetor();
            break;
        case 2:
            GerenciarMatriz();
            break;
        case 3:
            GerenciarLista();
            break;
        case 4:
            GerenciarFila();
            break;
        case 5:
            GerenciarPilha();
            break;
        case 6:
            GerenciarPesquisa();
            break;
        case 0:
            Console.WriteLine("Encerrando...");
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
3. Gerenciamento das Estruturas de Dados
Para cada tipo de estrutura de dados (Vetor, Matriz, Lista, Fila, Pilha), existe uma função correspondente que apresenta um menu de operações disponíveis (Inserir Elemento, Remover Elemento, Exibir Elementos, Consultar Elemento). O fluxo de operações para cada estrutura segue o padrão abaixo:

Inserir Elemento: O usuário insere um valor para ser adicionado à estrutura.

Remover Elemento: O sistema remove o último ou o primeiro elemento da estrutura (dependendo da estrutura).

Exibir Elementos: O sistema exibe todos os elementos presentes na estrutura.

Consultar Elemento: O usuário insere um valor para consultar sua presença na estrutura.

Exemplo de gerenciamento de vetor:

csharp
Copiar
Editar
private static void GerenciarVetor()
{
    var vetor = new Vetor(5); // Criar um vetor de tamanho 5
    int opcao;
    do
    {
        Console.Clear();
        Console.WriteLine("Operações no Vetor:");
        Console.WriteLine("1. Inserir Elemento");
        Console.WriteLine("2. Remover Elemento");
        Console.WriteLine("3. Exibir Elementos");
        Console.WriteLine("4. Consultar Elemento");
        Console.WriteLine("0. Voltar");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Write("Digite o elemento a ser inserido: ");
                int elem = int.Parse(Console.ReadLine());
                vetor.InserirElemento(elem);
                break;
            case 2:
                vetor.RemoverElemento();
                break;
            case 3:
                vetor.ExibirElementos();
                break;
            case 4:
                Console.Write("Digite o elemento a ser consultado: ");
                int consulta = int.Parse(Console.ReadLine());
                vetor.ConsultarElemento(consulta);
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    } while (opcao != 0);
}
4. Algoritmos de Pesquisa
Na opção 6 do menu principal, o usuário pode escolher entre realizar uma Busca Sequencial ou uma Busca Binária. Ambas as buscas são implementadas na classe Pesquisa que está no diretório Algorithms.

A busca sequencial percorre todos os elementos da lista até encontrar o item desejado, enquanto a busca binária só funciona em listas ordenadas e procura o item dividindo a lista ao meio.

Exemplo de implementação de busca sequencial:

csharp
Copiar
Editar
public static int BuscaSequencial(List<int> lista, int chave)
{
    for (int i = 0; i < lista.Count; i++)
    {
        if (lista[i] == chave)
            return i; // Retorna o índice do elemento encontrado
    }
    return -1; // Retorna -1 se o elemento não for encontrado
}
5. Exemplo de Saída
O sistema irá interagir com o usuário e, após a escolha de uma operação, retornará a saída correspondente. Por exemplo:

markdown
Copiar
Editar
Escolha uma opção:
1. Vetores
2. Matrizes
3. Listas
4. Filas
5. Pilhas
6. Algoritmos de Pesquisa
0. Sair
1
Operações no Vetor:
1. Inserir Elemento
2. Remover Elemento
3. Exibir Elementos
4. Consultar Elemento
0. Voltar
Digite o elemento a ser inserido: 10
Pressione qualquer tecla para continuar...
6. Exceções e Validação de Entradas
O código atualmente não realiza validações avançadas sobre entradas erradas (como letras ou caracteres especiais em vez de números inteiros). Idealmente, as entradas devem ser tratadas para evitar falhas de execução.

Conclusão
Este aplicativo oferece uma interface simples e interativa para o gerenciamento de estruturas de dados em C#, possibilitando ao usuário realizar operações básicas sobre vetores, matrizes, listas, filas e pilhas, além de aplicar algoritmos de pesquisa.
