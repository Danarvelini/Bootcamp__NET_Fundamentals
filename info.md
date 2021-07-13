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

## Conceitos

Os principais conceitos organizacionais em C# são:
- Programas (consistem em um ou mais arquivos)
- namespaces
- tipos (classes e interfaces)
- membros (campos, métodos, propriedades e eventos)
- assemblies (são as DLLs)

## Classes e objetos

Classes são os tipos mais fundamentais de C#. Uma classe é uma estrutura de dados que combina estado (campos) e ações (métodos)

Objetos são instâncias de uma classe. As classes suportam herança e polimorfismo, mecanismos pelos quais as classes derivadas podem estender e especializas as classes base.

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

### Métodos

É quem determina as ações que uma classe ou objeto poderá realizar.
Uma boa pratica nomear os métodos como verbos, e suas propriedades como substantivos.
