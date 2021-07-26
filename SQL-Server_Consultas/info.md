# SQL Server

Banco SGBD podemos adicionar gerenciamento de usuarios.
Temos dois tipos de bancos de dados SGBD:
- **Relacionais**. __SQL Server, Oracle, MySQL__. São designados para sistemas que precisam de confiabilidade dos dados, como controle de estoque. Se preocupa com a consistencia dos dados em todas as instancias.
- **NoSQL**. __MongoDB, Neo4j, Firebase__. São bancos voltados para melhor performance e bons para armazenar grande quantidade de dados. Não se preocupa com a consistencia dos dados em todas as instancias.

Caracteristicas importantes para bancos relacionais:
- **Atomicidade**: Ele vai garantir que todos os dados estão corretos para enfim inseri-lo no banco, isso é muito importante para confiabilidade dos dados.
- **Consistência dos dados**: É a habilidade de sincronizar os dados atualizados para qualquer conexão ao banco. Por exemplo, os dados de venda devem estar relacionados com os de estoque. Talvez em casos de trocas grandes e recorrentes, seja legal utilizar ferramentas para duplicar dados em copias de bancos, ou até mesmo utilizar alguns bancos para venda e outros para estoque com dados sincronizados. A ideia é dados persistam somente se estiverem prontos para persistir em todas as intancias do banco.
- 