# Anotações

.NET está na versão .NET 5
.NET framwork já não será mais atualizado. O foco é o Azure e .NET Core

O professor recomenda, para hoje, estudar .NET Core e C#. Caso queira desenvolver para mobile, utilizar o Xamarin. 

Hoje com tudo multiplataforma e open source, o .NET está crescendo cada vez mais.

## Links úteis

https://dotnetfoundation.org
https://docs.microsoft.com/en-us/dotnet/
https://dotnet.microsoft.com/download
https://azure.microsoft.com/pt-br/
https://mono-project.com
https://dotnet.microsoft.com/apps/xamarin

Aplicação CONSOLE é uma aplicação que é executada via terminal.

## Truques

* Pressionar ao selecionar um método para ser direcionado à sua origem
* Pressionar F1 para abrir os comandos do VScode
*

## Conceitos

Os principais conceitos organizacionais em C# são:
- Programas (consistem em um ou mais arquivos)
- namespaces
- tipos (classes e interfaces)
- membros (campos, métodos, propriedades e eventos)
- assemblies (são as DLLs)

## Classes e objetos

Classes são os tipos mais fundamentais de C#. Uma classe é uma estrutura de dados que combina estado (campos) e ações (métodos)

**Objetos são instâncias de uma classe**. As classes suportam herança e polimorfismo, mecanismos pelos quais as classes derivadas podem estender e especializas as classes base.

Instâncias de classes (objetos) são criadas usando o operador new, que aloca memória para uma nova instância, chama um construtor para inicializar a instância e retorna uma referencia à instância:
* Ponto p1 = new Ponto(0,0);
* Ponto p2 = new Ponto(10,20);

A memória ocupada por um objeto é recuperada automaticamente quando o objeto não está mais acessível. Não é necessário nem possível desalocar explicitamente objetos em C#

### Membros

São membros de uma classe que podem ser **estáticos**, que são pertencentes à classe, ou **instancia** que pertencem ao objeto.
Constantes, variáveis, métodos, propriedades, construtores, etc...

Cada membro possui uma acessibilidade associada, que controla as regiões (public, protected, internal, private)

### Herança

Podemos especificar uma classe, que herdará os membros de outra classe base.
Omitir uma especificação de classe base é o mesmo que derivar do tipo object.

Por enquanto, no C#, é possível herdar apenas uma classe.

### Métodos

É quem determina as ações que uma classe ou objeto poderá realizar.
Uma boa pratica nomear os métodos como verbos, e suas propriedades como substantivos.

Método **virtual** é o método que permite, através do **override**, sobreescrever sua ação.

### Structs

Como as classes, as structs são estruturas de dados que podem conter membros de dados e membros de ação, mas , diferentemente das classes, as structs são tipos de valor e não requerem alocação de **heap** (qque gera a referencia da posição).

**stack** é o local que fica armazenada as variáveis struct.

São do tipo valor.
Uma variável de um tipo de struct armazena diretamente os dados da estrutura, enquanto uma variável de um de classe armazena uma referência a um objeto alocado na memória.

Structs não aceitam herança determinada pelo desenvolvedor.
São úteis para pequenas estruturas de dados que possuem semântica de valor: números complexos, pontos em um sistema de coordenadas ou pares de chave-valor em um dicionário são bons exemplos de utilização.

O uso de structs faz menor uso de alocação de memória, e isso é uma vantagem.

Construtores de struct são chamados com o operador new, semelhante a um construtor de classe, mas em vez de alocar dinamicamente um objeto no heap gerenciado e retornar uma referencia a ele, como as classes, o construtor struct simplesmente retorna o proprio valor struct (normalmente em um local temporário na stack), e esse valor é copado conforme necessário
https://www.eximiaco.tech/pt/category/fundamentos

### Interfaces

Ela é como um contrato que pode ser implementado por classes e structs
Uma interface pode conter métodos, propriedades, eventos e indexadores
A interface não fornece implementações dos membros, somente suas assinaturas. As interfaces podem empregar herança múltipla
A ideia aqui é implementar algo que obriga os que herdarem este algo, que possuem todos os métodos de sua origem.

### Enums

É um tipo de valor distinto com um conjunto de constantes nomeadas.
Fornecem significados semanticos e valores discretos.
Você define enumerações quando precisa definir um tipo que pode ter um conjunto de valores discretos. Eles usam um dos tipos de valor integral como armazenamento subjacente. Eles fornecem significado semântico aos valores discretos.

Cada tipo de enum possui um tipo integral correspondente chamado tipo subjacente do tipo de enum.
Um tipo de enumeração que não declara explicitamente um tipo subjacente tem um tipo subjacente int.