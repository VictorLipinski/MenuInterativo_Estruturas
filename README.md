# Documentação Técnica - DataStructuresApp

## Descrição

O **DataStructuresApp** é um aplicativo desenvolvido em **C#** que permite ao usuário interagir com diferentes **estruturas de dados** (vetores, matrizes, listas, filas, pilhas) e aplicar **algoritmos de pesquisa** (busca sequencial e binária). O objetivo é proporcionar uma interface simples e interativa para manipulação dessas estruturas e explorar técnicas básicas de pesquisa.

## Estrutura do Projeto

O projeto está organizado em dois namespaces principais:

- **DataStructures**: Contém as implementações das estruturas de dados, como Vetor, Matriz, Lista, Fila e Pilha.
- **Algorithms**: Contém os algoritmos de busca (busca sequencial e busca binária) que podem ser aplicados nas estruturas de dados.

A modularização do código facilita a manutenção e leitura, com cada estrutura de dados em seu próprio arquivo. O diretório `Algorithms` contém as implementações de pesquisa, enquanto o arquivo `Program.cs` é responsável pela interação com o usuário e a execução do menu principal.

### Estrutura de Diretórios

DataStructuresApp
├── DataStructures
│ ├── Vetor.cs
│ ├── Matriz.cs
│ ├── Lista.cs
│ ├── Fila.cs
│ └── Pilha.cs
├── Algorithms
│ └── Pesquisa.cs
└── Program.cs

kotlin
Copiar
Editar

## Descrição do Código

### 1. Namespaces Usados

- **System**: Usado para manipulação de entrada e saída de dados, manipulação de console e exceções.
- **DataStructures**: Namespace que contém as classes para as estruturas de dados como Vetor, Matriz, Lista, Fila e Pilha.
- **Algorithms**: Namespace que contém a classe `Pesquisa`, responsável pela implementação dos algoritmos de busca (sequencial e binária).
- **System.Collections.Generic**: Usado para trabalhar com coleções genéricas, como `List<T>`, que é utilizada nas pesquisas.

### 2. Main Loop e Menu Principal

A função `Main` exibe um menu principal que permite ao usuário escolher entre várias opções para manipular as estruturas de dados ou realizar operações de pesquisa. O menu é implementado como um loop contínuo até que o usuário escolha a opção de saída (0). Dependendo da escolha do usuário, o programa chama a função correspondente para gerenciar a estrutura de dados ou executar a pesquisa.

Exemplo de implementação do loop principal:

```csharp
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
Para cada tipo de estrutura de dados (Vetor, Matriz, Lista, Fila, Pilha), existe uma função correspondente que apresenta um menu de operações disponíveis, como Inserir Elemento, Remover Elemento, Exibir Elementos e Consultar Elemento.

Abaixo está um exemplo de como a função de gerenciamento do Vetor funciona:

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
Na opção 6 do menu principal, o usuário pode escolher entre realizar uma Busca Sequencial ou uma Busca Binária. Ambas as buscas são implementadas na classe Pesquisa no diretório Algorithms.

Busca Sequencial: Percorre todos os elementos da lista até encontrar o item desejado.

Busca Binária: Funciona em listas ordenadas, dividindo a lista ao meio até encontrar o item desejado.

Exemplo de implementação da Busca Sequencial:

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
Após a escolha de uma operação, o sistema retorna a saída correspondente. Aqui está um exemplo de como a interação pode acontecer:

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
Atualmente, o código não realiza validações avançadas sobre entradas erradas, como letras ou caracteres especiais em vez de números inteiros. Para uma versão futura, é recomendável adicionar tratamentos de exceção para garantir que as entradas sejam válidas e evitar falhas de execução.

Conclusão
O DataStructuresApp oferece uma interface simples e interativa para o gerenciamento de estruturas de dados e aplicação de algoritmos de busca. Através de um menu no console, o usuário pode realizar operações básicas sobre vetores, matrizes, listas, filas e pilhas, além de testar as buscas sequenciais e binárias.

Este projeto serve como uma ferramenta educativa e pode ser expandido com novas estruturas e algoritmos à medida que a necessidade cresce.

pgsql
Copiar
Editar

Essa documentação técnica proporciona uma visão geral clara e detalhada do funcionamento do projeto, além de explicar cada parte do código, como ele é modularizado e como o usuário interage com as estruturas de dados. Você pode utilizá-la diretamente em seu repositório no GitHub.



