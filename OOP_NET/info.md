# Orientação a objetos em .NET

## O que são paradigmas de programação

São modos diferentes de estruturar o código e a execução de um código.
Um paradigma de programação fornece e determina a visão que o programador possui sobre a estruturação e execução do programa.

Cada para surgiu de necessidades diferentes. Dados isso, cada um apresenta maiores vantagens sobre os outros dentro do desenvolvimento de determinado sistema. Sendo assim, um paradigma pode oferecer técnicas apropriadas para uma aplicação específica. Entre eles, estão a **programação orientada a objetos** (POO) e **a programação estruturada** (PE).

## Paradigmas: Programação estruturada x Programação orientada a objetos

### Programação estruturada PE
Tem como principal característica sua interpretação linha por linha, em pequenos trechos de código, podendo eles nçao estar em uma ordem específica. Há três tipos de estruturas básicas para navegar pelo código: **sequência, seleção e repetição**

Estruturas:
- Seguências: são os comandos a serem executados de cima pra baixo, linha a linha do programa, de forma sequencial
- Seleções: são os códigos sequenciais que só devem ser executadas se uma condição for satisfeita (if, switch e coisas parecidas)
- Repetições: são sequencias que devem ser executadas repetidamente até uma condição (for, while, e outros)

### Programação Orientada a Objetos POO
É baseado no conceito de "objetos", que podem conter dados na forma de campos (**atributos**) e códigos, na forma de procedimentos (**métodos**). Uma característica é que um procedimento de objeto pode acessar, e geralmente modificar, os campos de dados do objeto com o qual eles estão associados e cada um é de receber, processar e enviar dadsos, podendo ser visto como uma "márquina independente"

Para que uma linguagem possa ser considerada POO é preciso atender aos " **4 pilares da Programação Orientada a Objeto**":
- Abstração
- Encapsulamento
- Herança
- Polimorfismo

## Orientação a objetos em .NET
A importância da POO é simples e direta. **Tudo em .NET é objeto**. Mesmo os tipos de dados mais simples são considerados objetos, já estes também contém métodos e propriedades. Implicitamente, todo e qualquer tipo ou objeto em .NET possui um ancestral em comum.

## Principais conceitos de classes objetos e visibilidade
### Classes
Pode ser considerada um molde para o objeto, contendo dentro de si as principais informações para a sua criação. Defini os atributos e métodos comuns que serão compartilhados por um objeto.
Objetos que são similares fazem parte da mesma classe, como carros diferentes que fazem parte da mesma classe Carro.

### Objetos
Considera um objeto tudo aquilo em geral que possua atributos, compartamentos e um estado.
A classe em si é um conceito abstrato, só tem prática, só se torna algo concreto através da criação de um objeto.
Na programação, o objeto é uma instanciação de uma classe, que é criar a partir de uma classe. Utilizando o operador __new__.


### Visibilidade
É importante para a proteção do código e para suas funcionaidades.
- Public (representada pelo símbolo "+"). Sem limitações de acesso
- Private (representada pelo símbolo "-"). Acesso limitado à propria classe
- Protected (representada pelo símbolo "#"). Acesso limitado à propria classe e às classes derivadas
- Internal
- Protected Internal


## Métodos
O envio de mensagens, chamada de métodos, pode alterar o estado de um objeto. Esses métodos temos difundidos os Getter, os Setters e o Construct
Os **Getters** ou métodos acessores solicitam o acesso a informaççoes de um determinado produto sem dar acesso diretamente a ele, colocando ali uma barreira de proteção de dados.

Os **Setters** ou métodos modificadores enviam o pedido de alteração de uma determinada informação de um objeto sem que se altere diretamente o mesmo

A função do **Construct** ou método construtor é inicializar ou dar forma à classe. É nele que indicamos os valores dos campos de uma classe. Esse valores podem ser internos (no código) ou externos (passados por parâmetros). O Construct possui algumas regras para dedinição:
- O construtor deve ter o mesmo nome da classe
- Não tem tipo de retorno
- É executado apenas um, apenas uma vez, no momento da criação do objeto
- Não pode ser chamado diretamente
- Deve ser public

## Propriedades
Uma forma mais inteligente de fazer implementações de campos em classes são as **propriedades**. Propriedades consistem em um par de métodos __get__ e __set__ que respectivamente servem para recuperar e atribuir o valor a um campo.

Geralmente, para cada método existe uma variável dentro da classe que armazena o valor da propriedade.

## Eventos
Os eventos são mensagens, chamadas, que a classe dispara em uma determinada situação. Para que o evento funcione, é necessário que um método seja escrito para ser executado quando ocorrer o evento. A classe apenas fica sabendo que existe esse método em tempo de execução. A POO permite em tempo de execução que a classe responda ao evento.

Para que isso ocorra utilizamos uma estrutura chamada de **Delegate**, que é uma variavel que guarda o endereço de uma função. Assim, quando o evento é disparado, essa variável chama a função associada a ela